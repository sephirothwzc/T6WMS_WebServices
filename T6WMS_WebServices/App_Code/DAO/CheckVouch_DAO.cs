using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Sephiroth_IDao;
using System.ComponentModel.DataAnnotations.Schema;
using Sephiroth_DAO;

/*************************************************************************************
    * CLR 版本：       4.0.30319.33440
    * 类 名 称：       CheckVouch
    * 机器名称：       WUZHANCHAO
    * 命名空间：       DAO
    * 文 件 名：       CheckVouch
    * 创建时间：       2015-10-11 13:58
    * 作    者：       
    * 说    明：       
    * 修改时间：
    * 修 改 人：
*************************************************************************************/

namespace DAO
{
    /// <summary>
    /// 盘点单主表
    /// </summary>
    [Table("CheckVouch")]
    public class CheckVouch_DAO : BaseDAO<CheckVouch>
    {
        private Sephiroth_IDao.IDAO dao = new DapperDAO(
            Sephiroth_DAO.CreateDB_Connection.GetSephiroth_System(datasource: "datasourceUF"));
        public override Sephiroth_IDao.IDAO absORM 
        {
            get { return dao; }
            set { dao = value; }
        }

        /// <summary>
        /// 保存盘点表
        /// </summary>
        /// <param name="CheckVouch"></param>
        /// <returns></returns>
        internal bool SaveCheckVouch(CheckVouch CheckVouch)
        {
            var dbtran = this.absORM.CreateIDbTransaction();//开启事务
            try
            {
                var ua_identity = new UA_Identity_DAO().Query(new UA_Identity
                {
                    cAcc_Id = System.Configuration.ConfigurationManager.AppSettings["cAccID"],
                    cVouchType = "ch"
                }).FirstOrDefault();
                string sql = @"select isnull(max(cCVCode),'0000000000') cCVCode from CheckVouch ";
                var dcode = this.QueryDynamic(sql, new RdRecord(), dbtran).FirstOrDefault();

                string code = (Convert.ToInt32(dcode.cCVCode) + 1).ToString();

                CheckVouch.cCVCode = code.PadLeft(10, '0');
                CheckVouch.ID = ua_identity.iFatherId;

                //子表赋值
                CheckVouch.CheckVouchsS.ForEach(p =>
                {
                    p.ID = CheckVouch.ID;
                    p.autoID = Convert.ToInt32(ua_identity.iChildId);
                    p.cCVCode = CheckVouch.cCVCode;
                    ua_identity.iChildId = ua_identity.iChildId + 1;
                    //更新现存量
                    sql = @"select isnull(iQuantity,0)  iQuantity from CurrentStock where cInvCode = @cInvCode and cWhCode=@cWhCode";
                    var sl = this.QueryDynamic(sql, new { cInvCode = p.cInvCode, cWhCode = CheckVouch.cWhCode }, dbtran).FirstOrDefault();
                    p.iCVQuantity = float.Parse(sl.iQuantity.ToString() ?? 0);
                });
                this.Insert(CheckVouch, dbtran);
                new CheckVouchs_DAO().Insert(CheckVouch.CheckVouchsS, idbtransaction: dbtran);

                //更新主键
                new UA_Identity_DAO().Execute(@"update ua_identity set iFatherId = @iFatherId ,iChildId = @iChildId 
                                                                    where cAcc_Id = @cAcc_Id and cVouchType='ch' ", ua_identity);
                dbtran.Commit();
            }
            catch (Exception ex)
            {
                dbtran.Rollback();
                return false;
            }
            return true;
        }
    }
}


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
    * 类 名 称：       RdRecord
    * 机器名称：       WUZHANCHAO
    * 命名空间：       DAO
    * 文 件 名：       RdRecord
    * 创建时间：       2015-10-11 13:49
    * 作    者：       
    * 说    明：       
    * 修改时间：
    * 修 改 人：
*************************************************************************************/

namespace DAO
{
    /// <summary>
    /// 收发记录主表（出入库）
    /// </summary>
    [Table("RdRecord")]
    public class RdRecord_DAO : BaseDAO<RdRecord>
    {
        private Sephiroth_IDao.IDAO dao = new DapperDAO(
            Sephiroth_DAO.CreateDB_Connection.GetSephiroth_System(datasource: "datasourceUF"));
        public override Sephiroth_IDao.IDAO absORM 
        {
            get { return dao; }
            set { dao = value; }
        }

        /// <summary>
        /// 保存出入库记录
        /// </summary>
        /// <param name="RdRecord"></param>
        /// <returns></returns>
        internal bool SaveRdRecord(RdRecord rdRecord)
        {
            var dbtran = this.absORM.CreateIDbTransaction();//开启事务
            try
            {
                var ua_identity = new UA_Identity_DAO().Query(new UA_Identity
                {
                    cAcc_Id = System.Configuration.ConfigurationManager.AppSettings["cAccID"],
                    cVouchType = "Rd"
                }).FirstOrDefault();
                string sql = @"select isnull(max(cCode),'0000000000') cCode from RdRecord where cBusType = @cBusType";
                var dcode = this.QueryDynamic(sql,new RdRecord { cBusType = rdRecord.cBusType },  dbtran).FirstOrDefault();
                string code = (Convert.ToInt32(dcode.cCode) + 1).ToString();
                rdRecord.cCode = code.PadLeft(10, '0');
                ua_identity.iFatherId = ua_identity.iFatherId + 1;
                rdRecord.ID = Convert.ToInt32(ua_identity.iFatherId);
                rdRecord.cSource = "库存";
                rdRecord.dDate = Convert.ToDateTime(DateTime.Now.ToString("YYYY-MM-DD 00:00:00"));
                //子表赋值
                rdRecord.rds.ForEach(p => 
                {
                    p.ID = rdRecord.ID;
                    ua_identity.iChildId = ua_identity.iChildId + 1;
                    p.AutoID = Convert.ToInt32(ua_identity.iChildId);
                });
                this.Insert(rdRecord, dbtran);
                new RdRecords_DAO().Insert(rdRecord.rds, idbtransaction: dbtran);
                //更新主键
                new UA_Identity_DAO().Execute(@"update ua_identity set iFatherId = @iFatherId ,iChildId = @iChildId 
                                                                    where cAcc_Id = @cAcc_Id and cVouchType='Rd' ", ua_identity);
                dbtran.Commit();
            }
            catch(Exception ex)
            {
                dbtran.Rollback();
                return false;
            }
            return true;
        }
    }
}


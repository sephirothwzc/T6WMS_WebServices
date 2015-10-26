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
    * 类 名 称：       UA_User
    * 机器名称：       SEPHIROTHBF0C
    * 命名空间：       DAO
    * 文 件 名：       UA_User
    * 创建时间：       2015-10-04 10:09
    * 作    者：       
    * 说    明：       
    * 修改时间：
    * 修 改 人：
*************************************************************************************/

namespace DAO
{
    /// <summary>
    /// 
    /// </summary>
    [Table("UA_User")]
    public class UA_User_DAO : BaseDAO<UA_User>
    {
        private Sephiroth_IDao.IDAO dao = new DapperDAO(Sephiroth_DAO.CreateDB_Connection.GetSephiroth_System());
        public override Sephiroth_IDao.IDAO absORM 
        {
            get { return dao; }
            set { dao = value; }
        }

    }
}


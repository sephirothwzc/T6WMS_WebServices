﻿using System;
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
    * 类 名 称：       Department
    * 机器名称：       WUZHANCHAO
    * 命名空间：       DAO
    * 文 件 名：       Department
    * 创建时间：       2015-10-26 16:04
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
    [Table("Department")]
    public class Department_DAO : BaseDAO<Department>
    {
        private Sephiroth_IDao.IDAO dao = new DapperDAO(Sephiroth_DAO.CreateDB_Connection.GetSephiroth_System(datasource: "datasourceUF"));
        public override Sephiroth_IDao.IDAO absORM 
        {
            get { return dao; }
            set { dao = value; }
        }

    }
}


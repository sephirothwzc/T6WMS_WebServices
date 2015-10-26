using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Sephiroth_IDao;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/*************************************************************************************
    * CLR 版本：       4.0.30319.33440
    * 类 名 称：       UA_Identity
    * 机器名称：       WUZHANCHAO
    * 命名空间：       Entity
    * 文 件 名：       UA_Identity
    * 创建时间：       2015/10/14 22:02:50
    * 作    者：       
    * 说    明：       
    * 修改时间：
    * 修 改 人：
*************************************************************************************/

namespace Entity
{
    /// <summary>
    /// 主键对象
    /// </summary>
    [Table("UA_Identity")]
    public class UA_Identity: BaseEntity
    {
        

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cAcc_Id")]
        [MaxLength(3)]
        [Required]
        public string cAcc_Id { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVouchType")]
        [MaxLength(50)]
        public string cVouchType { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iFatherId")]
        [MaxLength(10)]
        [Required]
        public int? iFatherId { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iChildId")]
        [MaxLength(10)]
        [Required]
        public int? iChildId { get; set; }

    }
}


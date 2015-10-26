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
    * 类 名 称：       Warehouse
    * 机器名称：       WUZHANCHAO
    * 命名空间：       Entity
    * 文 件 名：       Warehouse
    * 创建时间：       2015/10/11 13:33:30
    * 作    者：       
    * 说    明：       
    * 修改时间：
    * 修 改 人：
*************************************************************************************/

namespace Entity
{
    /// <summary>
    /// 仓库档案
    /// </summary>
    [Table("Warehouse")]
    [Serializable]
    public class Warehouse: BaseEntity
    {
        

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cWhCode")]
        [MaxLength(10)]
        [Key]
        [Required]
        public string cWhCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cWhName")]
        [MaxLength(100)]
        public string cWhName { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDepCode")]
        [MaxLength(12)]
        public string cDepCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cWhAddress")]
        [MaxLength(30)]
        public string cWhAddress { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cWhPhone")]
        [MaxLength(20)]
        public string cWhPhone { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cWhPerson")]
        [MaxLength(10)]
        public string cWhPerson { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cWhValueStyle")]
        [MaxLength(12)]
        [Required]
        public string cWhValueStyle { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bWhPos")]
        [MaxLength(1)]
        [Required]
        public bool? bWhPos { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iWhFundQuota")]
        [MaxLength(53)]
        public float? iWhFundQuota { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cMonth")]
        [MaxLength(6)]
        public string cMonth { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cWhMemo")]
        [MaxLength(20)]
        public string cWhMemo { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bFreeze")]
        [MaxLength(1)]
        [Required]
        public bool? bFreeze { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cBarCode")]
        [MaxLength(30)]
        public string cBarCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bMRP")]
        [MaxLength(1)]
        [Required]
        public bool? bMRP { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [NotMapped]
        [Column("pubufts")]
        [MaxLength(8)]
        public TimeSpan? pubufts { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bROP")]
        [MaxLength(1)]
        [Required]
        public bool? bROP { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iWHProperty")]
        [MaxLength(5)]
        public int? iWHProperty { get; set; }

    }
}


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
    * 类 名 称：       Department
    * 机器名称：       WUZHANCHAO
    * 命名空间：       Entity
    * 文 件 名：       Department
    * 创建时间：       2015/10/26 16:04:27
    * 作    者：       
    * 说    明：       
    * 修改时间：
    * 修 改 人：
*************************************************************************************/

namespace Entity
{
    /// <summary>
    /// 部门主数据
    /// </summary>
    [Table("Department")]
    public class Department: BaseEntity
    {
        

        
        /// <summary>
        /// 部门编码
        /// </summary>
        [Column("cDepCode")]
        [MaxLength(12)]
        [Key]
        [Required]
        public string cDepCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bDepEnd")]
        [MaxLength(1)]
        [Required]
        public bool? bDepEnd { get; set; }

        
        /// <summary>
        /// 部门名称
        /// </summary>
        [Column("cDepName")]
        [MaxLength(20)]
        [Required]
        public string cDepName { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iDepGrade")]
        [MaxLength(3)]
        [Required]
        public int? iDepGrade { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDepPerson")]
        [MaxLength(10)]
        public string cDepPerson { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDepProp")]
        [MaxLength(10)]
        public string cDepProp { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDepPhone")]
        [MaxLength(20)]
        public string cDepPhone { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDepAddress")]
        [MaxLength(30)]
        public string cDepAddress { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDepMemo")]
        [MaxLength(20)]
        public string cDepMemo { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iCreLine")]
        [MaxLength(53)]
        public float? iCreLine { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cCreGrade")]
        [MaxLength(20)]
        public string cCreGrade { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iCreDate")]
        [MaxLength(10)]
        public int? iCreDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cOfferGrade")]
        [MaxLength(20)]
        public string cOfferGrade { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iOfferRate")]
        [MaxLength(53)]
        public float? iOfferRate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("pubufts")]
        [MaxLength(8)]
        [NotMapped]
        public TimeSpan? pubufts { get; set; }

    }
}


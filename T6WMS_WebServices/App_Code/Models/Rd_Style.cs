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
    * 类 名 称：       Rd_Style
    * 机器名称：       WUZHANCHAO
    * 命名空间：       Entity
    * 文 件 名：       Rd_Style
    * 创建时间：       2015/10/26 08:54:39
    * 作    者：       
    * 说    明：       
    * 修改时间：
    * 修 改 人：
*************************************************************************************/

namespace Entity
{
    /// <summary>
    /// 收发类别档案
    /// </summary>
    [Table("Rd_Style")]
    public class Rd_Style: BaseEntity
    {
        

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cRdCode")]
        [MaxLength(5)]
        [Key]
        [Required]
        public string cRdCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cRdName")]
        [MaxLength(12)]
        [Required]
        public string cRdName { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iRdGrade")]
        [MaxLength(3)]
        [Required]
        public int? iRdGrade { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bRdFlag")]
        [MaxLength(10)]
        [Required]
        public int? bRdFlag { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bRdEnd")]
        [MaxLength(1)]
        [Required]
        public bool? bRdEnd { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cOppHead")]
        [MaxLength(15)]
        public string cOppHead { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("pubufts")]
        [MaxLength(8)]
        [NotMapped]
        public TimeSpan? pubufts { get; set; }

    }
}


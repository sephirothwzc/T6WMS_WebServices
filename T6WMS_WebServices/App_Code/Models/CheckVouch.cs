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
    * 类 名 称：       CheckVouch
    * 机器名称：       WUZHANCHAO
    * 命名空间：       Entity
    * 文 件 名：       CheckVouch
    * 创建时间：       2015/10/11 13:58:44
    * 作    者：       
    * 说    明：       
    * 修改时间：
    * 修 改 人：
*************************************************************************************/

namespace Entity
{
    /// <summary>
    /// 盘点
    /// </summary>
    [Table("CheckVouch")]
    [Serializable]
    public class CheckVouch: BaseEntity
    {

        /// <summary>
        /// 盘点子表对象  CurrentStock。iQuantity 现存量 =账面数量
        /// </summary>
        [NotMapped]
        public List<CheckVouchs> CheckVouchsS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [Column("cCVCode")]
        [MaxLength(30)]
        [Key]
        [Required]
        public string cCVCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dCVDate")]
        [MaxLength(23)]
        [Required]
        public DateTime dCVDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDepCode")]
        [MaxLength(12)]
        public string cDepCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cPersonCode")]
        [MaxLength(8)]
        public string cPersonCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cIRdCode")]
        [MaxLength(5)]
        public string cIRdCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cORdCode")]
        [MaxLength(5)]
        public string cORdCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cWhCode")]
        [MaxLength(10)]
        public string cWhCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cCVBatch")]
        [MaxLength(60)]
        public string cCVBatch { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cCVMemo")]
        [MaxLength(60)]
        public string cCVMemo { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine1")]
        [MaxLength(20)]
        public string cDefine1 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine2")]
        [MaxLength(20)]
        public string cDefine2 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine3")]
        [MaxLength(20)]
        public string cDefine3 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine4")]
        [MaxLength(23)]
        public DateTime? cDefine4 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine5")]
        [MaxLength(10)]
        public int? cDefine5 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine6")]
        [MaxLength(23)]
        public DateTime? cDefine6 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine7")]
        [MaxLength(53)]
        public float? cDefine7 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine8")]
        [MaxLength(4)]
        public string cDefine8 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine9")]
        [MaxLength(8)]
        public string cDefine9 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine10")]
        [MaxLength(60)]
        public string cDefine10 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cAccounter")]
        [MaxLength(20)]
        public string cAccounter { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cMaker")]
        [MaxLength(20)]
        public string cMaker { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iNetLock")]
        [MaxLength(24)]
        public double? iNetLock { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cPosition")]
        [MaxLength(20)]
        public string cPosition { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dACDate")]
        [MaxLength(23)]
        public DateTime? dACDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("ID")]
        [MaxLength(10)]
        public int? ID { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("VT_ID")]
        [MaxLength(10)]
        public int? VT_ID { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bTransFlag")]
        [MaxLength(1)]
        public bool? bTransFlag { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine11")]
        [MaxLength(120)]
        public string cDefine11 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine12")]
        [MaxLength(120)]
        public string cDefine12 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine13")]
        [MaxLength(120)]
        public string cDefine13 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine14")]
        [MaxLength(120)]
        public string cDefine14 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine15")]
        [MaxLength(10)]
        public int? cDefine15 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine16")]
        [MaxLength(10)]
        public int? cDefine16 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("ufts")]
        [MaxLength(8)]
        public TimeSpan? ufts { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bposcheck")]
        [MaxLength(10)]
        [Required]
        public string bposcheck { get; set; }

    }
}


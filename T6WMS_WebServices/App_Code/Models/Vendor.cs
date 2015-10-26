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
    * 类 名 称：       Vendor
    * 机器名称：       WUZHANCHAO
    * 命名空间：       Entity
    * 文 件 名：       Vendor
    * 创建时间：       2015/10/20 14:30:14
    * 作    者：       
    * 说    明：       
    * 修改时间：
    * 修 改 人：
*************************************************************************************/

namespace Entity
{
    /// <summary>
    /// 供应商
    /// </summary>
    [Table("Vendor")]
    public class Vendor: BaseEntity
    {
        

        
        /// <summary>
        /// 供应商编码
        /// </summary>
        [Column("cVenCode")]
        [MaxLength(20)]
        [Key]
        [Required]
        public string cVenCode { get; set; }

        
        /// <summary>
        /// 供应商名称
        /// </summary>
        [Column("cVenName")]
        [MaxLength(98)]
        public string cVenName { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenAbbName")]
        [MaxLength(60)]
        [Required]
        public string cVenAbbName { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVCCode")]
        [MaxLength(12)]
        public string cVCCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDCCode")]
        [MaxLength(12)]
        public string cDCCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cTrade")]
        [MaxLength(10)]
        public string cTrade { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenAddress")]
        [MaxLength(200)]
        public string cVenAddress { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenPostCode")]
        [MaxLength(6)]
        public string cVenPostCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenRegCode")]
        [MaxLength(50)]
        public string cVenRegCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenBank")]
        [MaxLength(100)]
        public string cVenBank { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenAccount")]
        [MaxLength(50)]
        public string cVenAccount { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dVenDevDate")]
        [MaxLength(23)]
        public DateTime? dVenDevDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenLPerson")]
        [MaxLength(10)]
        public string cVenLPerson { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenPhone")]
        [MaxLength(100)]
        public string cVenPhone { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenFax")]
        [MaxLength(20)]
        public string cVenFax { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenEmail")]
        [MaxLength(60)]
        public string cVenEmail { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenPerson")]
        [MaxLength(60)]
        public string cVenPerson { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenBP")]
        [MaxLength(20)]
        public string cVenBP { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenHand")]
        [MaxLength(20)]
        public string cVenHand { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenPPerson")]
        [MaxLength(10)]
        public string cVenPPerson { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iVenDisRate")]
        [MaxLength(53)]
        public float? iVenDisRate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iVenCreGrade")]
        [MaxLength(6)]
        public string iVenCreGrade { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iVenCreLine")]
        [MaxLength(53)]
        public float? iVenCreLine { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iVenCreDate")]
        [MaxLength(10)]
        public int? iVenCreDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenPayCond")]
        [MaxLength(20)]
        public string cVenPayCond { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenIAddress")]
        [MaxLength(200)]
        public string cVenIAddress { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenIType")]
        [MaxLength(10)]
        public string cVenIType { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenHeadCode")]
        [MaxLength(20)]
        public string cVenHeadCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenWhCode")]
        [MaxLength(10)]
        public string cVenWhCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenDepart")]
        [MaxLength(12)]
        public string cVenDepart { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iAPMoney")]
        [MaxLength(53)]
        public float? iAPMoney { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dLastDate")]
        [MaxLength(23)]
        public DateTime? dLastDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iLastMoney")]
        [MaxLength(53)]
        public float? iLastMoney { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dLRDate")]
        [MaxLength(23)]
        public DateTime? dLRDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iLRMoney")]
        [MaxLength(53)]
        public float? iLRMoney { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dEndDate")]
        [MaxLength(23)]
        public DateTime? dEndDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iFrequency")]
        [MaxLength(10)]
        public int? iFrequency { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bVenTax")]
        [MaxLength(1)]
        [Required]
        public bool? bVenTax { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenDefine1")]
        [MaxLength(20)]
        public string cVenDefine1 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenDefine2")]
        [MaxLength(20)]
        public string cVenDefine2 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenDefine3")]
        [MaxLength(20)]
        public string cVenDefine3 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cCreatePerson")]
        [MaxLength(20)]
        public string cCreatePerson { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cModifyPerson")]
        [MaxLength(20)]
        public string cModifyPerson { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dModifyDate")]
        [MaxLength(23)]
        public DateTime? dModifyDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cRelCustomer")]
        [MaxLength(20)]
        public string cRelCustomer { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iId")]
        [MaxLength(10)]
        public int? iId { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cBarCode")]
        [MaxLength(30)]
        public string cBarCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenDefine4")]
        [MaxLength(60)]
        public string cVenDefine4 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenDefine5")]
        [MaxLength(60)]
        public string cVenDefine5 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenDefine6")]
        [MaxLength(60)]
        public string cVenDefine6 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenDefine7")]
        [MaxLength(120)]
        public string cVenDefine7 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenDefine8")]
        [MaxLength(120)]
        public string cVenDefine8 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenDefine9")]
        [MaxLength(120)]
        public string cVenDefine9 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenDefine10")]
        [MaxLength(120)]
        public string cVenDefine10 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenDefine11")]
        [MaxLength(10)]
        public int? cVenDefine11 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenDefine12")]
        [MaxLength(10)]
        public int? cVenDefine12 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenDefine13")]
        [MaxLength(53)]
        public float? cVenDefine13 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenDefine14")]
        [MaxLength(53)]
        public float? cVenDefine14 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenDefine15")]
        [MaxLength(23)]
        public DateTime? cVenDefine15 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVenDefine16")]
        [MaxLength(23)]
        public DateTime? cVenDefine16 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("pubufts")]
        [MaxLength(8)]
        [NotMapped]
        public TimeSpan? pubufts { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("fRegistFund")]
        [MaxLength(53)]
        public float? fRegistFund { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iEmployeeNum")]
        [MaxLength(10)]
        public int? iEmployeeNum { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iGradeABC")]
        [MaxLength(5)]
        public int? iGradeABC { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cMemo")]
        [MaxLength(240)]
        public string cMemo { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bLicenceDate")]
        [MaxLength(1)]
        [Required]
        public bool? bLicenceDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dLicenceSDate")]
        [MaxLength(23)]
        public DateTime? dLicenceSDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dLicenceEDate")]
        [MaxLength(23)]
        public DateTime? dLicenceEDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iLicenceADays")]
        [MaxLength(10)]
        public int? iLicenceADays { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bBusinessDate")]
        [MaxLength(1)]
        [Required]
        public bool? bBusinessDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dBusinessSDate")]
        [MaxLength(23)]
        public DateTime? dBusinessSDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dBusinessEDate")]
        [MaxLength(23)]
        public DateTime? dBusinessEDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iBusinessADays")]
        [MaxLength(10)]
        public int? iBusinessADays { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bProxyDate")]
        [MaxLength(1)]
        [Required]
        public bool? bProxyDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dProxySDate")]
        [MaxLength(23)]
        public DateTime? dProxySDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dProxyEDate")]
        [MaxLength(23)]
        public DateTime? dProxyEDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iProxyADays")]
        [MaxLength(10)]
        public int? iProxyADays { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bPassGMP")]
        [MaxLength(1)]
        [Required]
        public bool? bPassGMP { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("caccountpid")]
        [MaxLength(30)]
        public string caccountpid { get; set; }

    }
}


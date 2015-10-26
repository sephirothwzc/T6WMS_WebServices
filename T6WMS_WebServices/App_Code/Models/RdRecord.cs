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
    * 类 名 称：       RdRecord
    * 机器名称：       WUZHANCHAO
    * 命名空间：       Entity
    * 文 件 名：       RdRecord
    * 创建时间：       2015/10/11 13:49:12
    * 作    者：       
    * 说    明：       
    * 修改时间：
    * 修 改 人：
*************************************************************************************/

namespace Entity
{
    /// <summary>
    /// 入库单主表
    /// </summary>
    [Table("RdRecord")]
    [Serializable]
    public class RdRecord: BaseEntity
    {
        #region 自定义属性
        [NotMapped]
        public List<RdRecords> rds { get; set; }
        #endregion 


        /// <summary>
        /// 
        /// </summary>
        [Column("ID")]
        [MaxLength(10)]
        [Key]
        [Required]
        public int ID { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bRdFlag")]
        [MaxLength(10)]
        //[Required]
        public int? bRdFlag { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVouchType")]
        [MaxLength(2)]
        [Required]
        public string cVouchType { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cBusType")]
        [MaxLength(12)]
        public string cBusType { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cSource")]
        [MaxLength(50)]
        [Required]
        public string cSource { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cBusCode")]
        [MaxLength(30)]
        public string cBusCode { get; set; }

        
        /// <summary>
        /// 仓库编码
        /// </summary>
        [Column("cWhCode")]
        [MaxLength(10)]
        [Required]
        public string cWhCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dDate")]
        [MaxLength(23)]
        [Required]
        public DateTime dDate { get; set; }

        
        /// <summary>
        /// 单据编号
        /// </summary>
        [Column("cCode")]
        [MaxLength(30)]
        [Required]
        public string cCode { get; set; }

        
        /// <summary>
        /// 出入库类型
        /// </summary>
        [Column("cRdCode")]
        [MaxLength(5)]
        public string cRdCode { get; set; }

        
        /// <summary>
        /// 部门编号（出库用）
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
        [Column("cPTCode")]
        [MaxLength(2)]
        public string cPTCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cSTCode")]
        [MaxLength(2)]
        public string cSTCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cCusCode")]
        [MaxLength(20)]
        public string cCusCode { get; set; }

        
        /// <summary>
        /// 供应商编码
        /// </summary>
        [Column("cVenCode")]
        [MaxLength(20)]
        public string cVenCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cOrderCode")]
        [MaxLength(30)]
        public string cOrderCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cARVCode")]
        [MaxLength(30)]
        public string cARVCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cBillCode")]
        [MaxLength(10)]
        public int? cBillCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDLCode")]
        [MaxLength(10)]
        public int? cDLCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cProBatch")]
        [MaxLength(50)]
        public string cProBatch { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cHandler")]
        [MaxLength(20)]
        public string cHandler { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cMemo")]
        [MaxLength(60)]
        public string cMemo { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bTransFlag")]
        [MaxLength(1)]
        [Required]
        public bool bTransFlag { get; set; }

        
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
        [Column("dKeepDate")]
        [MaxLength(5)]
        public string dKeepDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dVeriDate")]
        [MaxLength(23)]
        public DateTime? dVeriDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bpufirst")]
        [MaxLength(1)]
        public bool? bpufirst { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("biafirst")]
        [MaxLength(1)]
        public bool? biafirst { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iMQuantity")]
        [MaxLength(53)]
        public float? iMQuantity { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dARVDate")]
        [MaxLength(23)]
        public DateTime? dARVDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cChkCode")]
        [MaxLength(30)]
        public string cChkCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dChkDate")]
        [MaxLength(23)]
        public DateTime? dChkDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cChkPerson")]
        [MaxLength(20)]
        public string cChkPerson { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("VT_ID")]
        [MaxLength(10)]
        public int? VT_ID { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bIsSTQc")]
        [MaxLength(1)]
        [Required]
        public bool? bIsSTQc { get; set; }

        
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
        [MaxLength(53)]
        public float? cDefine16 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cPsPcode")]
        [MaxLength(20)]
        public string cPsPcode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cMPoCode")]
        [MaxLength(30)]
        public string cMPoCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("gspcheck")]
        [MaxLength(10)]
        public string gspcheck { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("ipurorderid")]
        [MaxLength(10)]
        public int? ipurorderid { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("ipurarriveid")]
        [MaxLength(10)]
        public int? ipurarriveid { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iproorderid")]
        [MaxLength(10)]
        public int? iproorderid { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iarriveid")]
        [MaxLength(30)]
        public string iarriveid { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("isalebillid")]
        [MaxLength(30)]
        public string isalebillid { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("ufts")]
        [MaxLength(8)]
        [NotMapped]
        public TimeSpan? ufts { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cBomSoCode")]
        [MaxLength(50)]
        public string cBomSoCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cOMrdType")]
        [MaxLength(30)]
        public string cOMrdType { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cBusCode2")]
        [MaxLength(30)]
        public string cBusCode2 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iTaxRate")]
        [MaxLength(53)]
        public float? iTaxRate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cAccountPID")]
        [MaxLength(3)]
        public string cAccountPID { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cAccountPDate")]
        [MaxLength(23)]
        public DateTime? cAccountPDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cPayCode")]
        [MaxLength(3)]
        public string cPayCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bgxljz")]
        [MaxLength(1)]
        public bool? bgxljz { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bisomqc")]
        [MaxLength(1)]
        public bool? bisomqc { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cvenbank")]
        [MaxLength(100)]
        public string cvenbank { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cvenaddress")]
        [MaxLength(200)]
        public string cvenaddress { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cvenphone")]
        [MaxLength(100)]
        public string cvenphone { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cvenfax")]
        [MaxLength(20)]
        public string cvenfax { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cvenpostcode")]
        [MaxLength(6)]
        public string cvenpostcode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cvenperson")]
        [MaxLength(60)]
        public string cvenperson { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cvenaccount")]
        [MaxLength(50)]
        public string cvenaccount { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cvenregcode")]
        [MaxLength(50)]
        public string cvenregcode { get; set; }

    }
}


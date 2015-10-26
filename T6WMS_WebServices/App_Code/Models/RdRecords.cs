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
    * 类 名 称：       RdRecords
    * 机器名称：       WUZHANCHAO
    * 命名空间：       Entity
    * 文 件 名：       RdRecords
    * 创建时间：       2015/10/11 13:49:41
    * 作    者：       
    * 说    明：       
    * 修改时间：
    * 修 改 人：
*************************************************************************************/

namespace Entity
{
    /// <summary>
    /// 入库单子表
    /// </summary>
    [Table("RdRecords")]
    [Serializable]
    public class RdRecords: BaseEntity
    {
        #region 辅助字段
        /// <summary>
        /// 存货名称
        /// </summary>
        [NotMapped]
        public string cInvName { get; set; }
        #endregion 


        /// <summary>
        /// 主键
        /// </summary>
        [Column("AutoID")]
        [MaxLength(10)]
        [Key]
        [Required]
        public int AutoID { get; set; }

        
        /// <summary>
        /// 主表id RdRecord.ID
        /// </summary>
        [Column("ID")]
        [MaxLength(10)]
        [Required]
        public int ID { get; set; }

        
        /// <summary>
        /// 存货编码
        /// </summary>
        [Column("cInvCode")]
        [MaxLength(20)]
        [Required]
        public string cInvCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iNum")]
        [MaxLength(53)]
        public float? iNum { get; set; }

        
        /// <summary>
        /// 数量
        /// </summary>
        [Column("iQuantity")]
        [MaxLength(53)]
        public float? iQuantity { get; set; }

        
        /// <summary>
        /// 单价
        /// </summary>
        [Column("iUnitCost")]
        [MaxLength(53)]
        public float? iUnitCost { get; set; }

        
        /// <summary>
        /// 金额
        /// </summary>
        [Column("iPrice")]
        [MaxLength(19)]
        public decimal? iPrice { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iAPrice")]
        [MaxLength(19)]
        public decimal? iAPrice { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iPUnitCost")]
        [MaxLength(53)]
        public float? iPUnitCost { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iPPrice")]
        [MaxLength(19)]
        public decimal? iPPrice { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cBatch")]
        [MaxLength(60)]
        public string cBatch { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cObjCode")]
        [MaxLength(12)]
        public string cObjCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cVouchCode")]
        [MaxLength(10)]
        public string cVouchCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cFree1")]
        [MaxLength(20)]
        public string cFree1 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cFree2")]
        [MaxLength(20)]
        public string cFree2 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iFlag")]
        [MaxLength(3)]
        [Required]
        public int iFlag { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dSDate")]
        [MaxLength(23)]
        public DateTime? dSDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iTax")]
        [MaxLength(19)]
        public decimal? iTax { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iSQuantity")]
        [MaxLength(53)]
        public float? iSQuantity { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iSNum")]
        [MaxLength(53)]
        public float? iSNum { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iMoney")]
        [MaxLength(19)]
        public decimal? iMoney { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iSOutQuantity")]
        [MaxLength(53)]
        public float? iSOutQuantity { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iSOutNum")]
        [MaxLength(53)]
        public float? iSOutNum { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iFNum")]
        [MaxLength(53)]
        public float? iFNum { get; set; }

        
        /// <summary>
        /// 实际数量
        /// </summary>
        [Column("iFQuantity")]
        [MaxLength(53)]
        public float? iFQuantity { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dVDate")]
        [MaxLength(23)]
        public DateTime? dVDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iTrIds")]
        [MaxLength(10)]
        public int? iTrIds { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cPosition")]
        [MaxLength(20)]
        public string cPosition { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine22")]
        [MaxLength(60)]
        public string cDefine22 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine23")]
        [MaxLength(60)]
        public string cDefine23 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine24")]
        [MaxLength(60)]
        public string cDefine24 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine25")]
        [MaxLength(60)]
        public string cDefine25 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine26")]
        [MaxLength(53)]
        public float? cDefine26 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine27")]
        [MaxLength(53)]
        public float? cDefine27 { get; set; }

        
        /// <summary>
        /// 项目大类编码
        /// </summary>
        [Column("cItem_class")]
        [MaxLength(10)]
        public string cItem_class { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cItemCode")]
        [MaxLength(20)]
        public string cItemCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iPOsID")]
        [MaxLength(10)]
        public int? iPOsID { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("fACost")]
        [MaxLength(53)]
        public float? fACost { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iDLsID")]
        [MaxLength(10)]
        public int? iDLsID { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iSBsID")]
        [MaxLength(10)]
        public int? iSBsID { get; set; }

        
        /// <summary>
        /// 本次发货数量
        /// </summary>
        [Column("iSendQuantity")]
        [MaxLength(53)]
        public float? iSendQuantity { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iSendNum")]
        [MaxLength(53)]
        public float? iSendNum { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cName")]
        [MaxLength(60)]
        public string cName { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cItemCName")]
        [MaxLength(20)]
        public string cItemCName { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iEnsID")]
        [MaxLength(10)]
        public int? iEnsID { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cFree3")]
        [MaxLength(20)]
        public string cFree3 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cFree4")]
        [MaxLength(20)]
        public string cFree4 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cFree5")]
        [MaxLength(20)]
        public string cFree5 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cFree6")]
        [MaxLength(20)]
        public string cFree6 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cFree7")]
        [MaxLength(20)]
        public string cFree7 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cFree8")]
        [MaxLength(20)]
        public string cFree8 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cFree9")]
        [MaxLength(20)]
        public string cFree9 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cFree10")]
        [MaxLength(20)]
        public string cFree10 { get; set; }

        
        /// <summary>
        /// 对应条形码编码
        /// </summary>
        [Column("cBarCode")]
        [MaxLength(200)]
        public string cBarCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iNQuantity")]
        [MaxLength(53)]
        public float? iNQuantity { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iNNum")]
        [MaxLength(53)]
        public float? iNNum { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cAssUnit")]
        [MaxLength(10)]
        public string cAssUnit { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dMadeDate")]
        [MaxLength(23)]
        public DateTime? dMadeDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iMassDate")]
        [MaxLength(10)]
        public int? iMassDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine28")]
        [MaxLength(120)]
        public string cDefine28 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine29")]
        [MaxLength(120)]
        public string cDefine29 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine30")]
        [MaxLength(120)]
        public string cDefine30 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine31")]
        [MaxLength(120)]
        public string cDefine31 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine32")]
        [MaxLength(120)]
        public string cDefine32 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine33")]
        [MaxLength(120)]
        public string cDefine33 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine34")]
        [MaxLength(10)]
        public int? cDefine34 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine35")]
        [MaxLength(10)]
        public int? cDefine35 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine36")]
        [MaxLength(23)]
        public DateTime? cDefine36 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefine37")]
        [MaxLength(23)]
        public DateTime? cDefine37 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iMPoIds")]
        [MaxLength(10)]
        public int? iMPoIds { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iCheckIds")]
        [MaxLength(10)]
        public int? iCheckIds { get; set; }

        
        /// <summary>
        /// 供应商编码
        /// </summary>
        [Column("cBVencode")]
        [MaxLength(20)]
        public string cBVencode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInVouchCode")]
        [MaxLength(30)]
        public string cInVouchCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bGsp")]
        [MaxLength(1)]
        public bool? bGsp { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cGspState")]
        [MaxLength(20)]
        public string cGspState { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iArrsId")]
        [MaxLength(10)]
        public int? iArrsId { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cCheckCode")]
        [MaxLength(30)]
        public string cCheckCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iCheckIdBaks")]
        [MaxLength(10)]
        public int? iCheckIdBaks { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cRejectCode")]
        [MaxLength(30)]
        public string cRejectCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iRejectIds")]
        [MaxLength(10)]
        public int? iRejectIds { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cCheckPersonCode")]
        [MaxLength(8)]
        public string cCheckPersonCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dCheckDate")]
        [MaxLength(23)]
        public DateTime? dCheckDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iTookQuantity")]
        [MaxLength(18)]
        public decimal? iTookQuantity { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iInvalidQuantity")]
        [MaxLength(18)]
        public decimal? iInvalidQuantity { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iOMMPoIds")]
        [MaxLength(10)]
        public int? iOMMPoIds { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iPBVQuantity")]
        [MaxLength(53)]
        public float? iPBVQuantity { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iPBVyQuantity")]
        [MaxLength(53)]
        public float? iPBVyQuantity { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iBalance")]
        [MaxLength(10)]
        public int? iBalance { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iHXQuantity")]
        [MaxLength(18)]
        public decimal? iHXQuantity { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cCAItemCode")]
        [MaxLength(20)]
        public string cCAItemCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cCBGJDXCode")]
        [MaxLength(60)]
        public string cCBGJDXCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bfilled")]
        [MaxLength(10)]
        public int? bfilled { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iarrptrintype")]
        [MaxLength(10)]
        public int? iarrptrintype { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("ichkautoid")]
        [MaxLength(10)]
        public int? ichkautoid { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("irejid")]
        [MaxLength(10)]
        public int? irejid { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("crejtext")]
        [MaxLength(255)]
        public string crejtext { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iTaxCost")]
        [MaxLength(53)]
        public float? iTaxCost { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iTaxPrice")]
        [MaxLength(53)]
        public float? iTaxPrice { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iTaxRate")]
        [MaxLength(53)]
        public float? iTaxRate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iSum")]
        [MaxLength(53)]
        public float? iSum { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iATaxCost")]
        [MaxLength(53)]
        public float? iATaxCost { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iATaxPrice")]
        [MaxLength(53)]
        public float? iATaxPrice { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iATaxRate")]
        [MaxLength(53)]
        public float? iATaxRate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iASum")]
        [MaxLength(53)]
        public float? iASum { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("MakePrice")]
        [MaxLength(18)]
        public decimal? MakePrice { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("MakeMny")]
        [MaxLength(18)]
        public decimal? MakeMny { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("HadBalanceQuantity")]
        [MaxLength(18)]
        public decimal? HadBalanceQuantity { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("HadBalanceMny")]
        [MaxLength(18)]
        public decimal? HadBalanceMny { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("OrgMakePrice")]
        [MaxLength(18)]
        public decimal? OrgMakePrice { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cBOMSoCode")]
        [MaxLength(100)]
        public string cBOMSoCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("csocode")]
        [MaxLength(30)]
        public string csocode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("ccbgjdxname")]
        [MaxLength(30)]
        public string ccbgjdxname { get; set; }

    }
}


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
    * 类 名 称：       Inventory
    * 机器名称：       WUZHANCHAO
    * 命名空间：       Entity
    * 文 件 名：       Inventory
    * 创建时间：       2015/10/11 13:31:05
    * 作    者：       
    * 说    明：       
    * 修改时间：
    * 修 改 人：
*************************************************************************************/

namespace Entity
{
    /// <summary>
    /// 存货档案
    /// </summary>
    [Table("Inventory")]
    [Serializable]
    public class Inventory: BaseEntity
    {
        

        
        /// <summary>
        /// 存货编码
        /// </summary>
        [Column("cInvCode")]
        [MaxLength(20)]
        [Key]
        [Required]
        public string cInvCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvAddCode")]
        [MaxLength(30)]
        public string cInvAddCode { get; set; }

        
        /// <summary>
        /// 存货名称
        /// </summary>
        [Column("cInvName")]
        [MaxLength(60)]
        [Required]
        public string cInvName { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvStd")]
        [MaxLength(60)]
        public string cInvStd { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvCCode")]
        [MaxLength(12)]
        public string cInvCCode { get; set; }

        
        /// <summary>
        /// 供应商编码
        /// </summary>
        [Column("cVenCode")]
        [MaxLength(20)]
        public string cVenCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cReplaceItem")]
        [MaxLength(20)]
        public string cReplaceItem { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cPosition")]
        [MaxLength(20)]
        public string cPosition { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bSale")]
        [MaxLength(1)]
        //[Required]
        public bool? bSale { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bPurchase")]
        [MaxLength(1)]
        //[Required]
        public bool? bPurchase { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bSelf")]
        [MaxLength(1)]
        //[Required]
        public bool? bSelf { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bComsume")]
        [MaxLength(1)]
        //[Required]
        public bool? bComsume { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bProducing")]
        [MaxLength(1)]
        //[Required]
        public bool? bProducing { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bService")]
        [MaxLength(1)]
        //[Required]
        public bool? bService { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bAccessary")]
        [MaxLength(1)]
        //[Required]
        public bool? bAccessary { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iTaxRate")]
        [MaxLength(53)]
        public float? iTaxRate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iInvWeight")]
        [MaxLength(53)]
        public float? iInvWeight { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iVolume")]
        [MaxLength(53)]
        public float? iVolume { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iInvRCost")]
        [MaxLength(53)]
        public float? iInvRCost { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iInvSPrice")]
        [MaxLength(53)]
        public float? iInvSPrice { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iInvSCost")]
        [MaxLength(53)]
        public float? iInvSCost { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iInvLSCost")]
        [MaxLength(53)]
        public float? iInvLSCost { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iInvNCost")]
        [MaxLength(53)]
        public float? iInvNCost { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iInvAdvance")]
        [MaxLength(53)]
        public float? iInvAdvance { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iInvBatch")]
        [MaxLength(53)]
        public float? iInvBatch { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iSafeNum")]
        [MaxLength(53)]
        public float? iSafeNum { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iTopSum")]
        [MaxLength(53)]
        public float? iTopSum { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iLowSum")]
        [MaxLength(53)]
        public float? iLowSum { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iOverStock")]
        [MaxLength(53)]
        public float? iOverStock { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvABC")]
        [MaxLength(1)]
        public string cInvABC { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bInvQuality")]
        [MaxLength(1)]
        //[Required]
        public bool? bInvQuality { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bInvBatch")]
        [MaxLength(1)]
        //[Required]
        public bool? bInvBatch { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bInvEntrust")]
        [MaxLength(1)]
        //[Required]
        public bool? bInvEntrust { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bInvOverStock")]
        [MaxLength(1)]
        //[Required]
        public bool? bInvOverStock { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dSDate")]
        [MaxLength(23)]
        public DateTime? dSDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dEDate")]
        [MaxLength(23)]
        public DateTime? dEDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bFree1")]
        [MaxLength(1)]
        //[Required]
        public bool? bFree1 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bFree2")]
        [MaxLength(1)]
        //[Required]
        public bool? bFree2 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvDefine1")]
        [MaxLength(20)]
        public string cInvDefine1 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvDefine2")]
        [MaxLength(20)]
        public string cInvDefine2 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvDefine3")]
        [MaxLength(20)]
        public string cInvDefine3 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("I_id")]
        [MaxLength(10)]
        //[Required]
        public int? I_id { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bInvType")]
        [MaxLength(1)]
        public bool? bInvType { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iInvMPCost")]
        [MaxLength(53)]
        public float? iInvMPCost { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cQuality")]
        [MaxLength(100)]
        public string cQuality { get; set; }

        
        /// <summary>
        /// 零售单价
        /// </summary>
        [Column("iInvSaleCost")]
        [MaxLength(53)]
        public float? iInvSaleCost { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iInvSCost1")]
        [MaxLength(53)]
        public float? iInvSCost1 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iInvSCost2")]
        [MaxLength(53)]
        public float? iInvSCost2 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iInvSCost3")]
        [MaxLength(53)]
        public float? iInvSCost3 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bFree3")]
        [MaxLength(1)]
        //[Required]
        public bool? bFree3 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bFree4")]
        [MaxLength(1)]
        //[Required]
        public bool? bFree4 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bFree5")]
        [MaxLength(1)]
        //[Required]
        public bool? bFree5 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bFree6")]
        [MaxLength(1)]
        //[Required]
        public bool? bFree6 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bFree7")]
        [MaxLength(1)]
        //[Required]
        public bool? bFree7 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bFree8")]
        [MaxLength(1)]
        //[Required]
        public bool? bFree8 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bFree9")]
        [MaxLength(1)]
        //[Required]
        public bool? bFree9 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bFree10")]
        [MaxLength(1)]
        //[Required]
        public bool? bFree10 { get; set; }

        
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
        [Column("fSubscribePoint")]
        [MaxLength(53)]
        public float? fSubscribePoint { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("fVagQuantity")]
        [MaxLength(53)]
        public float? fVagQuantity { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cValueType")]
        [MaxLength(20)]
        public string cValueType { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bFixExch")]
        [MaxLength(1)]
        //[Required]
        public bool? bFixExch { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("fOutExcess")]
        [MaxLength(53)]
        public float? fOutExcess { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("fInExcess")]
        [MaxLength(53)]
        public float? fInExcess { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iMassDate")]
        [MaxLength(5)]
        public int? iMassDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iWarnDays")]
        [MaxLength(5)]
        public int? iWarnDays { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("fExpensesExch")]
        [MaxLength(53)]
        public float? fExpensesExch { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bTrack")]
        [MaxLength(1)]
        //[Required]
        public bool? bTrack { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bSerial")]
        [MaxLength(1)]
        //[Required]
        public bool? bSerial { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bBarCode")]
        [MaxLength(1)]
        //[Required]
        public bool? bBarCode { get; set; }

        
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
        [Column("cInvDefine4")]
        [MaxLength(60)]
        public string cInvDefine4 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvDefine5")]
        [MaxLength(60)]
        public string cInvDefine5 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvDefine6")]
        [MaxLength(60)]
        public string cInvDefine6 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvDefine7")]
        [MaxLength(120)]
        public string cInvDefine7 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvDefine8")]
        [MaxLength(120)]
        public string cInvDefine8 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvDefine9")]
        [MaxLength(120)]
        public string cInvDefine9 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvDefine10")]
        [MaxLength(120)]
        public string cInvDefine10 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvDefine11")]
        [MaxLength(10)]
        public int? cInvDefine11 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvDefine12")]
        [MaxLength(10)]
        public int? cInvDefine12 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvDefine13")]
        [MaxLength(53)]
        public float? cInvDefine13 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvDefine14")]
        [MaxLength(53)]
        public float? cInvDefine14 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvDefine15")]
        [MaxLength(23)]
        public DateTime? cInvDefine15 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvDefine16")]
        [MaxLength(23)]
        public DateTime? cInvDefine16 { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iGroupType")]
        [MaxLength(3)]
        //[Required]
        public int? iGroupType { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cGroupCode")]
        [MaxLength(10)]
        public string cGroupCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cComUnitCode")]
        [MaxLength(10)]
        public string cComUnitCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cAssComUnitCode")]
        [MaxLength(10)]
        public string cAssComUnitCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cSAComUnitCode")]
        [MaxLength(10)]
        public string cSAComUnitCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cPUComUnitCode")]
        [MaxLength(10)]
        public string cPUComUnitCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cSTComUnitCode")]
        [MaxLength(10)]
        public string cSTComUnitCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cCAComUnitCode")]
        [MaxLength(10)]
        public string cCAComUnitCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cFrequency")]
        [MaxLength(10)]
        public string cFrequency { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iFrequency")]
        [MaxLength(5)]
        public int? iFrequency { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iDays")]
        [MaxLength(5)]
        public int? iDays { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dLastDate")]
        [MaxLength(23)]
        public DateTime? dLastDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iWastage")]
        [MaxLength(53)]
        public float? iWastage { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bSolitude")]
        [MaxLength(1)]
        //[Required]
        public bool? bSolitude { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cEnterprise")]
        [MaxLength(100)]
        public string cEnterprise { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cAddress")]
        [MaxLength(100)]
        public string cAddress { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cFile")]
        [MaxLength(40)]
        public string cFile { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cLabel")]
        [MaxLength(30)]
        public string cLabel { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cCheckOut")]
        [MaxLength(30)]
        public string cCheckOut { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cLicence")]
        [MaxLength(30)]
        public string cLicence { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bSpecialties")]
        [MaxLength(1)]
        //[Required]
        public bool? bSpecialties { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDefWareHouse")]
        [MaxLength(10)]
        public string cDefWareHouse { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iHighPrice")]
        [MaxLength(53)]
        public float? iHighPrice { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iExpSaleRate")]
        [MaxLength(53)]
        public float? iExpSaleRate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cPriceGroup")]
        [MaxLength(20)]
        public string cPriceGroup { get; set; }

        
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
        [Column("cMonth")]
        [MaxLength(6)]
        public string cMonth { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iAdvanceDate")]
        [MaxLength(5)]
        public int? iAdvanceDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cCurrencyName")]
        [MaxLength(60)]
        public string cCurrencyName { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cProduceAddress")]
        [MaxLength(200)]
        public string cProduceAddress { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cProduceNation")]
        [MaxLength(60)]
        public string cProduceNation { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cRegisterNo")]
        [MaxLength(60)]
        public string cRegisterNo { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cEnterNo")]
        [MaxLength(60)]
        public string cEnterNo { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cPackingType")]
        [MaxLength(60)]
        public string cPackingType { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cEnglishName")]
        [MaxLength(60)]
        public string cEnglishName { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bPropertyCheck")]
        [MaxLength(1)]
        //[Required]
        public bool? bPropertyCheck { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cPreparationType")]
        [MaxLength(30)]
        public string cPreparationType { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cCommodity")]
        [MaxLength(60)]
        public string cCommodity { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iRecipeBatch")]
        [MaxLength(3)]
        //[Required]
        public int? iRecipeBatch { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cNotPatentName")]
        [MaxLength(30)]
        public string cNotPatentName { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("pubufts")]
        [MaxLength(8)]
        [NotMapped]
        public TimeSpan pubufts { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bPromotSales")]
        [MaxLength(1)]
        //[Required]
        public bool? bPromotSales { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iPlanPolicy")]
        [MaxLength(5)]
        public int? iPlanPolicy { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iROPMethod")]
        [MaxLength(5)]
        public int? iROPMethod { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iBatchRule")]
        [MaxLength(5)]
        public int? iBatchRule { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("fBatchIncrement")]
        [MaxLength(53)]
        public float? fBatchIncrement { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iAssureProvideDays")]
        [MaxLength(10)]
        public int? iAssureProvideDays { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iTestStyle")]
        [MaxLength(5)]
        public int? iTestStyle { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iDTMethod")]
        [MaxLength(5)]
        public int? iDTMethod { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("fDTRate")]
        [MaxLength(53)]
        public float? fDTRate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("fDTNum")]
        [MaxLength(53)]
        public float? fDTNum { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDTUnit")]
        [MaxLength(10)]
        public string cDTUnit { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iDTStyle")]
        [MaxLength(5)]
        public int? iDTStyle { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iQTMethod")]
        [MaxLength(10)]
        public int? iQTMethod { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bProxyForeign")]
        [MaxLength(1)]
        //[Required]
        public bool? bProxyForeign { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bSynchroBom")]
        [MaxLength(10)]
        public string bSynchroBom { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bKCCutMantissa")]
        [MaxLength(1)]
        public bool? bKCCutMantissa { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bRequireGroup")]
        [MaxLength(1)]
        public bool? bRequireGroup { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cReplaceItemcode")]
        [MaxLength(20)]
        public string cReplaceItemcode { get; set; }

    }
}


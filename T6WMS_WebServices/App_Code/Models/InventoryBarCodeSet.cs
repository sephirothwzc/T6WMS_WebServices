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
    * 类 名 称：       InventoryBarCodeSet
    * 机器名称：       WUZHANCHAO
    * 命名空间：       Entity
    * 文 件 名：       InventoryBarCodeSet
    * 创建时间：       2015/10/11 13:32:34
    * 作    者：       
    * 说    明：       
    * 修改时间：
    * 修 改 人：
*************************************************************************************/

namespace Entity
{
    /// <summary>
    /// 存货条码表
    /// </summary>
    [Serializable]
    [Table("InventoryBarCodeSet")]
    public class InventoryBarCodeSet: BaseEntity
    {
        

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvCode")]
        [MaxLength(30)]
        [Required]
        public string cInvCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cBarCode")]
        [MaxLength(200)]
        [Key]
        [Required]
        public string cBarCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cRuleId")]
        [MaxLength(16)]
        [Required]
        public string cRuleId { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cAssignId")]
        [MaxLength(16)]
        [Required]
        public string cAssignId { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvName")]
        [MaxLength(60)]
        public string cInvName { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvCCode")]
        [MaxLength(12)]
        public string cInvCCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvCName")]
        [MaxLength(20)]
        public string cInvCName { get; set; }

        
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
        /// 
        /// </summary>
        [Column("cVenCode")]
        [MaxLength(20)]
        public string cVenCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvStd")]
        [MaxLength(60)]
        public string cInvStd { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cPostion")]
        [MaxLength(20)]
        public string cPostion { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cWhCode")]
        [MaxLength(10)]
        public string cWhCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cBatch")]
        [MaxLength(60)]
        public string cBatch { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dMDate")]
        [MaxLength(23)]
        public DateTime? dMDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dVDate")]
        [MaxLength(23)]
        public DateTime? dVDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dCreateDate")]
        [MaxLength(23)]
        public DateTime? dCreateDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iMassDate")]
        [MaxLength(10)]
        public int? iMassDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cAssUnit")]
        [MaxLength(10)]
        public string cAssUnit { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("fUnitCost")]
        [MaxLength(53)]
        public float? fUnitCost { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("bAbandon")]
        [MaxLength(5)]
        [Required]
        public int bAbandon { get; set; }

    }
}


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
    * 类 名 称：       CheckVouchs
    * 机器名称：       WUZHANCHAO
    * 命名空间：       Entity
    * 文 件 名：       CheckVouchs
    * 创建时间：       2015/10/11 13:59:03
    * 作    者：       
    * 说    明：       
    * 修改时间：
    * 修 改 人：
*************************************************************************************/

namespace Entity
{
    /// <summary>
    /// 盘点子表
    /// </summary>
    [Table("CheckVouchs")]
    [Serializable]
    public class CheckVouchs: BaseEntity
    {
        

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cCVCode")]
        [MaxLength(30)]
        [Required]
        public string cCVCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cInvCode")]
        [MaxLength(20)]
        [Required]
        public string cInvCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("RdsID")]
        [MaxLength(10)]
        public int? RdsID { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iCVNum")]
        [MaxLength(53)]
        public float? iCVNum { get; set; }

        
        /// <summary>
        /// 账面数量=现存量
        /// </summary>
        [Column("iCVQuantity")]
        [MaxLength(53)]
        public float? iCVQuantity { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iCVCNum")]
        [MaxLength(53)]
        public float? iCVCNum { get; set; }

        
        /// <summary>
        /// 盘点数量
        /// </summary>
        [Column("iCVCQuantity")]
        [MaxLength(53)]
        public float? iCVCQuantity { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cCVBatch")]
        [MaxLength(60)]
        public string cCVBatch { get; set; }

        
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
        [Column("cCVReason")]
        [MaxLength(20)]
        public string cCVReason { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dDisDate")]
        [MaxLength(23)]
        public DateTime? dDisDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iJhdj")]
        [MaxLength(53)]
        public float? iJhdj { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iJhJe")]
        [MaxLength(53)]
        public float? iJhJe { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iSjDJ")]
        [MaxLength(53)]
        public float? iSjDJ { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iSjJe")]
        [MaxLength(53)]
        public float? iSjJe { get; set; }

        
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
        /// 
        /// </summary>
        [Column("cItemCode")]
        [MaxLength(20)]
        public string cItemCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cItem_class")]
        [MaxLength(10)]
        public string cItem_class { get; set; }

        
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
        [Column("autoID")]
        [MaxLength(10)]
        [Key]
        [Required]
        public int autoID { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("ID")]
        [MaxLength(10)]
        public int? ID { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("cBarCode")]
        [MaxLength(200)]
        public string cBarCode { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iAdInQuantity")]
        [MaxLength(53)]
        public float? iAdInQuantity { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iAdInNum")]
        [MaxLength(53)]
        public float? iAdInNum { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iAdOutQuantity")]
        [MaxLength(53)]
        public float? iAdOutQuantity { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iAdOutNum")]
        [MaxLength(53)]
        public float? iAdOutNum { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iAllowWaste")]
        [MaxLength(53)]
        public float? iAllowWaste { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("iActualWaste")]
        [MaxLength(53)]
        public float? iActualWaste { get; set; }

        
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
        [Column("cAssUnit")]
        [MaxLength(10)]
        public string cAssUnit { get; set; }

        
        /// <summary>
        /// 
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
        [Column("iMassDate")]
        [MaxLength(10)]
        public int? iMassDate { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("dMadeDate")]
        [MaxLength(23)]
        public DateTime? dMadeDate { get; set; }

    }
}


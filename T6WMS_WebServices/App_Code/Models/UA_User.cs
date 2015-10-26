using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sephiroth_IDao;

/*************************************************************************************
    * CLR 版本：       4.0.30319.33440
    * 类 名 称：       UA_User
    * 机器名称：       SEPHIROTHBF0C
    * 命名空间：       Entity
    * 文 件 名：       UA_User
    * 创建时间：       2015/10/03 19:33:12
    * 作    者：       
    * 说    明：       
    * 修改时间：
    * 修 改 人：
*************************************************************************************/

namespace Entity
{
    /// <summary>
    /// 
    /// </summary>
    [Table("UA_User")]
    [Serializable]
    public class UA_User: BaseEntity
    {
        

        public const string CUSER_ID = "cUser_Id"; 
        
        /// <summary>
        /// 
        /// </summary>
        [Column("cUser_Id")]
        [MaxLength(12)]
        [Key]
        [Required]
        public string cUser_Id { get; set; }

        public const string CUSER_NAME = "cUser_Name"; 
        
        /// <summary>
        /// 
        /// </summary>
        [Column("cUser_Name")]
        [MaxLength(20)]
        public string cUser_Name { get; set; }

        public const string CPASSWORD = "cPassword"; 
        
        /// <summary>
        /// 
        /// </summary>
        [Column("cPassword")]
        [MaxLength(50)]
        public string cPassword { get; set; }

        public const string IADMIN = "iAdmin"; 
        
        /// <summary>
        /// 
        /// </summary>
        [Column("iAdmin")]
        [MaxLength(1)]
        [Required]
        public bool? iAdmin { get; set; }

        public const string CDEPT = "cDept"; 
        
        /// <summary>
        /// 
        /// </summary>
        [Column("cDept")]
        [MaxLength(20)]
        public string cDept { get; set; }

        public const string CBELONGGRP = "cBelongGrp"; 
        
        /// <summary>
        /// 
        /// </summary>
        [Column("cBelongGrp")]
        [MaxLength(255)]
        public string cBelongGrp { get; set; }

        public const string NSTATE = "nState"; 
        
        /// <summary>
        /// 
        /// </summary>
        [Column("nState")]
        [MaxLength(5)]
        public int? nState { get; set; }

        public const string CUSEREMAIL = "cUserEmail"; 
        
        /// <summary>
        /// 
        /// </summary>
        [Column("cUserEmail")]
        [MaxLength(30)]
        public string cUserEmail { get; set; }

        public const string CUSERHAND = "cUserHand"; 
        
        /// <summary>
        /// 
        /// </summary>
        [Column("cUserHand")]
        [MaxLength(20)]
        public string cUserHand { get; set; }

        public const string SAVEMAILCOUNT = "SaveMailCount"; 
        
        /// <summary>
        /// 
        /// </summary>
        [Column("SaveMailCount")]
        [MaxLength(10)]
        public int? SaveMailCount { get; set; }

        public const string SAVESMSCOUNT = "SaveSMSCount"; 
        
        /// <summary>
        /// 
        /// </summary>
        [Column("SaveSMSCount")]
        [MaxLength(10)]
        public int? SaveSMSCount { get; set; }

        public const string DPASSWORDDATE = "dPasswordDate"; 
        
        /// <summary>
        /// 
        /// </summary>
        [Column("dPasswordDate")]
        [MaxLength(23)]
        public DateTime? dPasswordDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column("PWD")]
        [MaxLength(50)]
        public string PWD { get; set; }
        //存货档案、存货条码设置表、仓库档案

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApi.Models
{
    /// <summary>
    /// 员工信息
    /// </summary>
    [Table("FAIRMANAGER.EM_EMPLOYEE")]
    public class EM_EMPLOYEE
    {
        /// <summary>
        /// 员工Id
        /// </summary>
        [Key]
        [StringLength(20)]
        public string EMPLOYEEID { get; set; }

        /// <summary>
        /// 员工编码
        /// </summary>
        [StringLength(20)]
        public string EMPLOYEECODE { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        [StringLength(100)]
        public string REALNAME { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        public string IDTYPE { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [StringLength(50)]
        public string IDNUMBER { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [StringLength(20)]
        public string MOBILEPHONE { get; set; }

        /// <summary>
        /// 是否删除  0未删除   1已删除
        /// </summary>
        public int ISDELETE { get; set; }

        /// <summary>
        /// 是否离职 0未离职,1已离职
        /// </summary>
        public int ISLEVEL { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime? ADDTIME { get; set; }

        /// <summary>
        /// 1入职完成，2入职提交，3入职办理中，4离职办理中，5已离职
        /// </summary>
        public int? STSTUS { get; set; }

        /// <summary>
        /// 服务项
        /// </summary>
        public string BUSINESS { get; set; }

        /// <summary>
        /// 添加人Id
        /// </summary>
        public string ADDUSERID { get; set; }
    }
}
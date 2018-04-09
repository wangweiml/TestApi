using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApi.Models;
using TestApi.Interface;

namespace TestApi.Controllers
{
    [RoutePrefix("api/Employee")]
    [AllowAnonymous]
    public class EmployeeController : ApiController
    {
        private readonly IEmOperationInterface emOperation;

        public EmployeeController(IEmOperationInterface theEmOperation)
        {
            emOperation = theEmOperation;
        }

        /// <summary>
        /// 根据员工身份证号码获取员工信息
        /// </summary>
        /// <param name="idNumber">身份证号码</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{idNumber}")]
        public EM_EMPLOYEE GetEmployeeByIdNumber(string idNumber)
        {
            EM_EMPLOYEE emModel = emOperation.GetEmployeeByIdNumber(idNumber);
            return emModel;
        }
    }
}

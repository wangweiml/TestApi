using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Models;
using TestApi.Interface;

namespace TestApi.Logic
{
    public class EmOperationLogic:IEmOperationInterface
    {
        private readonly IEmOperationDataSource dataSoucre;

        public EmOperationLogic(IEmOperationDataSource soucre)
        {
            dataSoucre = soucre;
        }

        /// <summary>
        /// 根据员工身份证号码获取员工信息
        /// </summary>
        /// <param name="idNumber">身份证号码</param>
        /// <returns></returns>
        public EM_EMPLOYEE GetEmployeeByIdNumber(string idNumber)
        {
            EM_EMPLOYEE model = dataSoucre.GetEmployeeByIdNumber(idNumber);
            return model;

        }
    }
}

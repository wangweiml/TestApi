using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestApi.Models;
using TestApi.Interface;
using System.Data;
using PetaPoco;

namespace TestApi.DataAccessor
{
    public class EmOperationDataSource:IEmOperationDataSource
    {
        private readonly TestApiModel testApiModel;
        private Database db = new Database("TestApiModel");

        public EmOperationDataSource(TestApiModel testApiModel)
        {
            this.testApiModel = testApiModel;
        }

        /// <summary>
        /// 根据员工身份证号码获取员工信息
        /// </summary>
        /// <param name="idNumber">身份证号码</param>
        /// <returns></returns>
        public EM_EMPLOYEE GetEmployeeByIdNumber(string idNumber)
        {
            EM_EMPLOYEE model = testApiModel.EM_EMPLOYEE.Where(p => p.IDNUMBER == idNumber && p.ISDELETE == 0 && p.ISLEVEL == 0).FirstOrDefault();
            return model;

        }
    }
}
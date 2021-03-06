﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Models;

namespace TestApi.Interface
{
    public interface IEmOperationDataSource
    {
        /// <summary>
        /// 根据员工身份证号码获取员工信息
        /// </summary>
        /// <param name="idNumber">身份证号码</param>
        /// <returns></returns>
        EM_EMPLOYEE GetEmployeeByIdNumber(string idNumber);
    }
}

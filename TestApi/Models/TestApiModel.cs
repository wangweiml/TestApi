using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TestApi.Models
{
    /// <summary>
    /// EF 根据数据库中已有表生成
    /// </summary>
    public partial class TestApiModel : DbContext
    {
        public TestApiModel()
            : base("name=TestApiModel")
        {
        }

        public virtual DbSet<EM_EMPLOYEE> EM_EMPLOYEE { get; set; }
    }
}
using Core.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BaseDbContextDesignTime : IDesignTimeDbContextFactory<BaseDbContext>
    {
        public BaseDbContext CreateDbContext(string[] args)
        {
            var dbcontextOptionBuilder = new DbContextOptionsBuilder<BaseDbContext>();
            dbcontextOptionBuilder.UseSqlServer(CommonConstants.ConnectionString);
            return new BaseDbContext(dbcontextOptionBuilder.Options);
        }
    }
}

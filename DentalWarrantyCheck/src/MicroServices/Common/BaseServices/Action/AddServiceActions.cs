using AutoMapper;
using BaseServices.Map;
using Core.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseServices.Action
{
    public static class AddServiceActions
    {
        public static IServiceProvider AddServiceAction(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddStackExchangeRedisCache(option => option.Configuration = CommonConstants.REDIS_SERVER_IP);
            MapperConfiguration mc = new MapperConfiguration((mc) =>
            {
                mc.AddProfile(new MapperProfile());
            });
            var mapper = mc.CreateMapper();
            services.AddSingleton(mapper);
            services.AddSingleton<IConnectionMultiplexer>(ConnectionMultiplexer.Connect(CommonConstants.REDIS_SERVER_IP));
            services.AddSingleton<Func<BaseDbContext>>(() =>
            {
                var options = new DbContextOptionsBuilder<BaseDbContext>();
                options.UseSqlServer(CommonConstants.ConnectionString);
                return new BaseDbContext(options.Options);
            });
            return services.BuildServiceProvider();
        }
        public static void ApplyDatabaseMigrations(this IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var func = scope.ServiceProvider.GetRequiredService<Func<BaseDbContext>>();
                var dbContext = func.Invoke();
                dbContext.Database.Migrate();
            }
        }
    }
}

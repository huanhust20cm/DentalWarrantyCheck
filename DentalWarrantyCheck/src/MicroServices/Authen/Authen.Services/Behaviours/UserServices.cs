using Authen.Services.Interface;
using AutoMapper;
using Core.Constants;
using Core.Entity;
using Core.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Authen.Services.Behaviours
{
    public class UserServices : IUserServices
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IConnectionMultiplexer _cache;
        private readonly IMapper _mapper;

        public UserServices(IHttpContextAccessor httpContextAccessor, IConnectionMultiplexer cache,
            IMapper mapper)
        {
            this.httpContextAccessor = httpContextAccessor;
            _cache = cache;
            _mapper = mapper;
        }
        public async Task<bool> AuthServices(LoginModel login)
        {
            if (login == null || login.Email == null || login.Password == null) throw new Exception("Login is not null");
            var user = new UserEntity
            {
                Id = new Guid("6ea92a12-e8e1-4de6-93fc-aa45b557e199"),
                Name = "Admin",
                Email = "AdminDental",
                Password = "AdminDental"
            };
            if(user.Email == login.Email && user.Password == login.Password)
            {
                var options = new CookieOptions
                {
                    Expires = DateTimeOffset.Now.AddHours(12)
                };
                httpContextAccessor.HttpContext.Response.Cookies.Append(CommonConstants.COOKIE_KEY_AUTH, user.Id.ToString(), options);
                httpContextAccessor.HttpContext.Response.Cookies.Append(CommonConstants.COOKIE_KEY_GUID, user.Name, options);
                var db = _cache.GetDatabase();
                db.StringSet(CommonConstants.COOKIE_KEY_AUTH, user.Id.ToString());
                db.StringSet(CommonConstants.COOKIE_KEY_GUID, user.Name);
                return true;
            }
            return false;
            
        }
        public async Task<string> CreateUniqueKey(string mark)
        {
            byte[] computedUniquekey = BaseCommonTool.GetMBytes(mark);
            return await Task.FromResult(Base64UrlEncoder.Encode(computedUniquekey));
        }
        public string CreateAESKey()
        {
            return BaseCommonTool.GetRandomAESKey();
        }
    }
}

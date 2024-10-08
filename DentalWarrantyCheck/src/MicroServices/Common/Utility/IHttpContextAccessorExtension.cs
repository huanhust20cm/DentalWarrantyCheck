using Core.Constants;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public static class IHttpContextAccessorExtension
    {
        public static string GetLoginId(this IHttpContextAccessor accessor)
        {
            if (accessor.HttpContext.Request.Cookies.TryGetValue(CommonConstants.COOKIE_KEY_EMAIL, out var loginId))
            {
                return loginId;
            }
            return String.Empty;
        }
        public static string GetUserId(this IHttpContextAccessor accessor)
        {
            if (accessor.HttpContext.Request.Cookies.TryGetValue(CommonConstants.COOKIE_KEY_AUTH, out var loginId))
            {
                return loginId;
            }
            return String.Empty;
        }
    }
}

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class CookieSetter
    {
        public static CookieOptions GetCommonCookie(string domain, int minut)
        {
            return new CookieOptions()
            {
                Domain = domain,
                Expires = DateTime.Now.AddMinutes(minut),
                HttpOnly = true,
                Secure = false,
                SameSite = SameSiteMode.None,
            };
        }
    }
}

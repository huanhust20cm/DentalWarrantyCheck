using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authen.Services.Interface
{
    public interface IUserServices
    {
        Task<bool> AuthServices(LoginModel login);
    }
}

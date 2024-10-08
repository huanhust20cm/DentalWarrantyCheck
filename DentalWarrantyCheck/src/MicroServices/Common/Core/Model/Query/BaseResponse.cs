using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model.Query
{
    public class BaseResponse<T>
    {
        public ResponseState State { get; set; }
        public T Data { set; get; }
        public string Messsage { get; set; }
    }
    public enum ResponseState
    {
        Ok = 0,
        ERROR = 1,
    }
}

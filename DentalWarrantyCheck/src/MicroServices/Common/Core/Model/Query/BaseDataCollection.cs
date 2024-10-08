using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model.Query
{
    public class BaseDataCollection<T>
    {
        public List<T>? BaseDatas { get; set; }
        public int TotalRecordCount { get; set; }
        public int PageIndex { get; set; }
        public int PageCount { get; set; }
    }
}

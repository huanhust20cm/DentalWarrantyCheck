using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class BaseApiModel
    {
        public Guid? Id { get; set; }
        public string? CreatedByLookupName { set; get; }
        public string? ModifiedByLookupName { set; get; }
        public Guid? CreatedBy { set; get; }
        public Guid? ModifiedBy { set; get; }
        public DateTimeOffset? CreateDate { set; get; }
        public DateTimeOffset? UpdateDate { set; get; }
        public int? State { set; get; }
    }
}

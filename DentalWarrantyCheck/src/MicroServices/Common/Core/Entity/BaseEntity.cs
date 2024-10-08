using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public partial class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? CreatedBy { set; get; }
        public string? CreatedByLookupName { set; get; }
        public string? ModifiedByLookupName { set; get; }
        public Guid? ModifiedBy { set; get; }
        public DateTimeOffset? CreateDate { set; get; }
        public DateTimeOffset? UpdateDate { set; get; }
        public int? State { set; get; }
        [Column("Delete")]
        public bool Delete { get; set; }
    }
}

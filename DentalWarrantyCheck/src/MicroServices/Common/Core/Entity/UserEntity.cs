using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public partial class UserEntity : BaseEntity
    {
        [Column("Email")]
        public string Email { set; get; }
        [Column("Password")]
        [MaxLength(256)]
        public string Password { set; get; }
        [Column("Name")]
        public string? Name { set; get; }
        [Column("Address")]
        public string? Address { set; get; }
        [Column("Phone")]
        public string? Phone { set; get; }
        [Column("Role")]
        public int? Role { set; get; }
        [Column("RoleLookupName")]
        public string? RoleLookupName { set; get; }
        [Column("Sex")]
        public int? Sex { get; set; }
        [Column("LastLoginDate")]
        public DateTimeOffset? LastLoginDate { set; get; }
    }
}

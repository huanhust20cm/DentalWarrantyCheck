using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class InformationEntity : BaseEntity
    {
        public string? NumberCard {  get; set; }
        public string? Name { get; set; }
        public DateTimeOffset? DateOfBirth { get; set; }
        public string? Phone { get; set; }
        public string? Teeth {  get; set; }
        public DateTimeOffset? StartDate { get; set; }
        // han su dung
        public string? Expiry {  get; set; }
        public string? Labo { get; set; }
        public string? Source { get; set; }
    }
}

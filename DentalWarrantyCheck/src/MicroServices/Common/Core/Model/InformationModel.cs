using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class InformationModel : BaseApiModel
    {
        public string? NumberCard { get; set; }
        public string? Name { get; set; }
        public string? DateOfBirth { get; set; }
        public string? Phone { get; set; }
        public string? Teeth { get; set; }
        public string? StartDate { get; set; }
        // han su dung
        public string? Expiry { get; set; }
        public string? Labo { get; set; }
        public string? Source { get; set; }
    }
}

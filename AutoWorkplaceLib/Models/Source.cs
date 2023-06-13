using AutoWorkplaceLib.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace AutoWorkplaceLib.Models
{
    public class Source : BaseEntity
    {
        public Source() { }
        [MaxLength(25)]
        public string Name { get; set; } = string.Empty;

        public Source(string name)
        {
            Name = name;
        }
    }
}

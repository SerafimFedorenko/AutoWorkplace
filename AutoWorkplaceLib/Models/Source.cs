using AutoWorkplaceLib.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
            IncomingMessages = new List<IncomingMessage>();
            OutgoingMessages = new List<OutgoingMessage>();
        }

        public override string? ToString()
        {
            return Name;
        }
        public virtual ICollection<IncomingMessage> IncomingMessages { get; set; }
        public virtual ICollection<OutgoingMessage> OutgoingMessages { get; set; }
    }
}

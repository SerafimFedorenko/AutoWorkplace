using AutoWorkplaceLib.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoWorkplaceLib.Models
{
    public class IncomingMessage : BaseEntity
    {
        public IncomingMessage()
        {
        }
        [Required]
        public DateTime Date { get;set; }
        [Required]
        [MaxLength(25)]
        public string Sender { get;set; } = string.Empty;
        [Required]
        [MaxLength(25)]
        public string Recipient { get; set; } = string.Empty;
        [MaxLength(25)]
        public string Adressee { get; set; } = string.Empty;
        [ForeignKey("Source")]
        public int SourceId { get; set; }
        public Source? Source { get; set; }

        public IncomingMessage(DateTime date, string sender, string recipient, string adressee, Source? source)
        {
            Date = date;
            Sender = sender;
            Recipient = recipient;
            Source = source;
            Adressee = adressee;
        }
    }
}
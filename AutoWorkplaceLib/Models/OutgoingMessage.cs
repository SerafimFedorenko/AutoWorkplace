using AutoWorkplaceLib.Models.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoWorkplaceLib.Models
{
    [Index(nameof(Number), IsUnique = true)]
    public class OutgoingMessage : BaseEntity
    {
        [Required]
        public string Number { get; set; } = string.Empty;
        //[Required]
        public DateTime Date { get; set; }
        [Required]
        [MaxLength(25)]
        public string Sender { get; set; } = string.Empty;
        [Required]
        [MaxLength(25)]
        public string Recipient { get; set; } = string.Empty;
        [MaxLength(25)]
        public string Adressee { get; set; } = string.Empty;
        [ForeignKey("Source")]
        public int SourceId { get; set; }
        public Source? Source { get; set; }
        public OutgoingMessage(DateTime date, string number, string sender, string recipient, string adressee, int sourceId)
        {
            Number = number;
            Date = date;
            Sender = sender;
            Recipient = recipient;
            Adressee = adressee;
            SourceId = sourceId;
        }
        public OutgoingMessage(int id, DateTime date, string number, string sender, string recipient, string adressee, int sourceId)
        {
            Id = id;
            Number = number;
            Date = date;
            Sender = sender;
            Recipient = recipient;
            Adressee = adressee;
            SourceId = sourceId;
        }
        public OutgoingMessage()
        {
        }
        public override string ToString()
        {
            return Date.ToString() + ", отправил:" + Sender + ", получил:" + Recipient;
        }
    }
}

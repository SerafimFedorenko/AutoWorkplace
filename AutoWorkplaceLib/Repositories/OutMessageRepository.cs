using AutoWorkplaceLib.Data;
using AutoWorkplaceLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Persistence.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWorkplaceLib.Repositories
{
    public class OutMessageRepository : BaseRepository<OutgoingMessage>
    {
        public OutMessageRepository() : base()
        {
        }
        public override IQueryable<OutgoingMessage> ItemsForDetails => base.ItemsForDetails.Include(msg => msg.Source);
        public override IQueryable<OutgoingMessage> AllItems => base.AllItems.Include(msg => msg.Source);
        public override void Delete(int id)
        {
            var entity = _context.OutgoingMessages.Find(id);
            _context.OutgoingMessages.Remove(entity);
            _context.SaveChanges();
        }
        public override int Insert(OutgoingMessage entity)
        {
            _context.OutgoingMessages.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }
        public override void Update(OutgoingMessage entity)
        {
            var newEntity = _context.OutgoingMessages.FirstOrDefault(x => x.Id == entity.Id);
            newEntity.Sender = entity.Sender;
            newEntity.Adressee = entity.Adressee;
            newEntity.Number = entity.Number;
            newEntity.Recipient = entity.Recipient;
            newEntity.SourceId = entity.SourceId;
            _context.OutgoingMessages.Update(newEntity);
            _context.SaveChanges();
        }
    }
}

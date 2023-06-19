using AutoWorkplaceLib.Data;
using AutoWorkplaceLib.Models;
using Microsoft.EntityFrameworkCore;
using Persistence.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWorkplaceLib.Repositories
{
    public class InMessageRepository : BaseRepository<IncomingMessage>
    {
        public InMessageRepository() : base()
        {

        }
        public override IQueryable<IncomingMessage> ItemsForDetails => base.ItemsForDetails.Include(msg => msg.Source);
        public override IQueryable<IncomingMessage> AllItems => base.AllItems.Include(msg => msg.Source);
        public override void Delete(int id)
        {
            _context.Remove(_context.IncomingMessages.Find(id));
            _context.SaveChanges();
        }
        public override int Insert(IncomingMessage entity)
        {
            _context.IncomingMessages.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }
        public override void Update(IncomingMessage entity)
        {
            var newEntity = _context.IncomingMessages.FirstOrDefault(x => x.Id == entity.Id);
            newEntity.Sender = entity.Sender;
            newEntity.Adressee = entity.Adressee;
            newEntity.Recipient = entity.Recipient;
            newEntity.SourceId = entity.SourceId;
            _context.IncomingMessages.Update(newEntity);
            _context.SaveChanges();
        }
    }
}

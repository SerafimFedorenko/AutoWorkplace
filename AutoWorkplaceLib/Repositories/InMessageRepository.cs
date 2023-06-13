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
        public InMessageRepository(AutoWorkplaceContext context) : base(context)
        {

        }
        public override IQueryable<IncomingMessage> ItemsForDetails => base.ItemsForDetails.Include(msg => msg.Sender);
        public override IQueryable<IncomingMessage> AllItems => base.AllItems.Include(msg => msg.Sender);

    }
}

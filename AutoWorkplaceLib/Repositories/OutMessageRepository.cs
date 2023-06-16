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
        public OutMessageRepository(AutoWorkplaceContext context) : base(context)
        {
            
        }
        public override IQueryable<OutgoingMessage> ItemsForDetails => base.ItemsForDetails.Include(msg => msg.Source);
        public override IQueryable<OutgoingMessage> AllItems => base.AllItems.Include(msg => msg.Source);

    }
}

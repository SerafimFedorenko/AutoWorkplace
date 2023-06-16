using AutoWorkplaceLib.Data;
using AutoWorkplaceLib.Models;
using Persistence.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWorkplaceLib.Repositories
{
    public class SourcesRepository : BaseRepository<Source>
    {
        public SourcesRepository(AutoWorkplaceContext context) : base(context)
        {
        }
    }
}

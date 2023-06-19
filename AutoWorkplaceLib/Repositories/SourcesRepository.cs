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
        public SourcesRepository() : base()
        {
        }
        public override void Delete(int id)
        {
            base.Delete(id);
        }
        public override int Insert(Source entity)
        {
            return base.Insert(entity);
        }
        public override void Update(Source entity)
        {
            base.Update(entity);
        }
    }
}

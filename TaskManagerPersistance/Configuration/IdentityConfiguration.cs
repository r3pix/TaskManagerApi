using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain.Entities;

namespace TaskManager.Persistance.Configuration
{
    public class IdentityConfiguration : BaseEntityCongiration<Identity, Guid>
    {
        public IdentityConfiguration() : base("Identity")
        {
        }
    }
}

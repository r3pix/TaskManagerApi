using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Domain.Entities
{
    public class Category : BaseEntity<Guid>
    {
        public string? Name { get; set; }

        public virtual IEnumerable<Task>? Tasks { get; set; } 
    }
}

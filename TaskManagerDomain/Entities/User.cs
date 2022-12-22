using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Domain.Entities
{
    public class User : BaseEntity<Guid>
    {
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }

        public virtual Identity? Identity { get; set; }
        public virtual IEnumerable<Task>? Tasks { get; set; }

    }
}

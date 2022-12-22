using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain.ValueObject;

namespace TaskManager.Domain.Entities
{
    public class Task : BaseEntity<Guid>
    {
        public string? Name { get; set; }
        public string? Content { get; set; }
        public Guid UserId { get; set; }
        public Guid CategoryId { get; set; }
        public Status Status { get; set; }

        public virtual User? User { get; set; }
        public virtual Category? Category { get; set; }

    }
}

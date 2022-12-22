using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain.ValueObject;

namespace TaskManager.Domain.Entities
{
    public class Identity : BaseEntity<Guid>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Gender Gender { get;set; }
        public int Age { get; set; }
        public Guid UserId { get; set; }

        public virtual User? User { get; set; }
    }
}

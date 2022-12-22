using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Domain.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            IsActive = true;
        }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string? CreateEmail { get; set; }
        public string? UpdateEmail { get; set; }
        public bool IsActive { get; set; }
    }

    public abstract class BaseEntity<TKey> : BaseEntity where TKey : struct 
    {
        public TKey Id { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; protected set; }
        //public DateTime CreateDate { get; protected set; }
        //public DateTime? UpdateDate { get; protected set; }
    }
}

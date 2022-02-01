using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcMvc.Domain.Models
{
    public abstract class Model
    {
        public int Id { get; protected set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Student.Model
{
    public class ActiveTest 
    {
        public Guid Id { get; set; }

        public virtual bool IsActive { get; set; } = true;
    }
}

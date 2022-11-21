using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Student
{
    public class Resume
    {
        public int ID { get; set; }

        public int PlayerId { get; set; }

        public Player Player { get; set; }

        public int Height { get; set; }
    }
}

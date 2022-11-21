using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Student
{
    public class Club
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public List<Player> Players { get; set; }

        public League League { get; set; }
    }
}

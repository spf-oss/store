using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Student
{
    public class League
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Content { get; set; }

        public List<Club> Clubs { get; set; } = new();
    }
}

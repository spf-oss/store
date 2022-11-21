using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Student
{
    public class GamePlayer
    {
        public int  ID { get; set; }

        public List<Player> Players { get; set; } = new();

        public List<Game> Games { get; set; } = new();
    }
}

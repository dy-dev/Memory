using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class Player
    {
        public String Name { get; set; }

        //Store all scores for this player
        public List<Score> PlayerScores { get; set; }

    }
}

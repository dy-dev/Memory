using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class Game
    {
        private Player m_Player;
        private Category m_Category;
        private Difficulty m_Difficulty;

        public Game(Category p_Cat, Difficulty p_Diff)
        {
            m_Category = p_Cat;
            m_Difficulty = p_Diff;
        }
    }
}

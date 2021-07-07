using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class Game
    {
        public Player CurrentPlayer { get; set; }
        public Category GameCategory { get; set; }
        private Difficulty GameDifficulty { get; set; }
        
        //Lists of cards used for this game => Information about cards position will be found in the 
        //cards themselves

        public Game()
        {
                
        }

        public Game(Category p_Cat, Difficulty p_Diff)
        {
            GameCategory = p_Cat;
            GameDifficulty = p_Diff;
        }

        public void StartGame()
        {

        }
    }
}

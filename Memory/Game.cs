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
        public List<List<Card>> CardDeck { get; set; }


        public Game()
        {
        }

        public Game(Category p_Cat, Difficulty p_Diff)
        {
            GameCategory = p_Cat;
            GameDifficulty = p_Diff;


            //Mise en place d'un jeu en fonction de la catégory et de la difficulté
            //La difficulté correspond au nombre de ligne / colonne du jeu de memory
            //Ex : En Easy => 4 lignes / 4 Colonnes
            //Il faut créer le nombre de cartes nécessaires (en easy ca fait 16) 
            //Il faut associer les symboles aux cartes (Ex : en easy on a besoin de 8 symbols)
            //Il faut que le deck soit "mélanger" (les cartes doivent positionnées aléatoirement)
            CardDeck = new List<List<Card>>();
            Random rng = new Random(DateTime.Now.Millisecond);
            var cards = Enumerable.Range(0, ((int)GameDifficulty * (int)GameDifficulty)).ToList();
            var shuffledcards = cards.OrderBy(a => rng.Next()).ToList();

            for (int i = 0; i < (int)GameDifficulty; i++)
            {
                List<Card> line = new List<Card>();
                for (int j = 0; j < (int)GameDifficulty; j++)
                {
                    int index = i * (int)GameDifficulty + j;
                    int modulo = ((int)GameDifficulty * (int)GameDifficulty) / 2;
                    line.Add(new Card() { CardID = shuffledcards[index]%modulo, Line = i, Column = j });
                }
                CardDeck.Add(line);
            }

            int lineindex = 0;
            Console.Write("       ");
            for (int i = 0; i < (int)GameDifficulty; i++)
            {
                Console.Write($"{i}   " );
            }
            Console.WriteLine();
            foreach (var line in CardDeck)
            {
                Console.Write($"{lineindex++,3} : ");
                foreach (var card in line)
                {
                    Console.Write($"  ? ");
                }
                Console.WriteLine();
            }

        }

        public void StartGame()
        {

        }
    }
}

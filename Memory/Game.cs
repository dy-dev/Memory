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

            //TODO Création du deck pour une nouvelle partie
            //Mise en place d'un jeu en fonction de la catégory et de la difficulté
            //La difficulté correspond au nombre de ligne / colonne du jeu de memory
            //Ex : En Easy => 4 lignes / 4 Colonnes
            //Il faut créer le nombre de cartes nécessaires (en easy ca fait 16) 
            //Il faut associer les symboles aux cartes (Ex : en easy on a besoin de 8 symbols)
            //Il faut que le deck soit "mélanger" (les cartes doivent positionnées aléatoirement)
        }

        public void StartGame()
        {

        }
    }
}

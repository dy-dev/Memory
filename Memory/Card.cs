using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class Card
    {
        public int CardID { get; set; }
        public int Column { get; set; }
        public int Line { get; set; }
       
        #region Constructors

        /// <summary>
        /// Constructeur avec ID
        /// </summary>
        /// <param name="p_iCardID"></param>
        public Card()
        {
        }

        /// <summary>
        /// Constructeur pour les colnnes et lignes
        /// </summary>
        /// <param name="col"></param>
        /// <param name="line"></param>
        public Card(int col,int line)
        {

        }

        /// <summary>
        /// Prends l'id, le num de col et de ligne
        /// </summary>
        /// <param name="id"></param>
        /// <param name="col"></param>
        /// <param name="line"></param>
        public Card(int id , int col, int line)
        {

        }
        #endregion

    }
}

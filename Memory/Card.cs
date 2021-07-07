using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class Card
    {
        int m_iCardID;
        int m_iColumn;
        int m_iLine;

        #region Constructors

        /// <summary>
        /// Constructeur avec ID
        /// </summary>
        /// <param name="p_iCardID"></param>
        public Card(int p_iCardID)
        {
            m_iCardID = p_iCardID;
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

        //public void returnCard();

        public static Card operator +(Card lhc, Card rhc)
        {
            return new Card(lhc.m_iCardID + rhc.m_iCardID);
        }

        public static Card Add(Card lhc, Card rhc)
        {
            return new Card(lhc.m_iCardID + rhc.m_iCardID);

        }


        virtual public void methode()
        {

        }
    }
}

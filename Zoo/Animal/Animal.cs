using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract class Animal
    {
        public Animal()
        {
            Random rand = new Random();
            m_bIsNice = rand.Next(0, 2) == 0;
        }
        protected bool m_bIsNice;
        public bool isNice() { return m_bIsNice; }
        abstract public void eat();
        abstract public void heal();
        abstract public void accept(VisitorCaretaker visitor);

    }
}

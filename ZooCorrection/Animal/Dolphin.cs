using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooCorrection
{
    class Dolphin : Animal
    {
        public override void accept(VisitorCaretaker visitor)
        {
            visitor.visit(this);
        }

        public override void eat()
        {
            if (m_bIsNice)
                Console.WriteLine("Sardines !!! Great I was starving");
            else
                Console.WriteLine("Sometimes I wish I were a shark just to know the taste of those humans");
        }

        public override void heal()
        {
            if (m_bIsNice)
                Console.WriteLine("Ohh I feel so much better thank you");
            else
                Console.WriteLine("Touch me again, and it'll be your head I'll be using as a ball for the next show");
        }
    }
}

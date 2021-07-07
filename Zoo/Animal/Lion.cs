using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Lion : Animal
    {
        public override void accept(VisitorCaretaker visitor)
        {
            visitor.visit(this);
        }

        public override void eat()
        {
            if (m_bIsNice)
                Console.WriteLine("Diner is served, that's nice!!! No need to run, life is cool");
            else
                Console.WriteLine("Raw meat. Not bad but one day I think I'll try to feed on this punny human just to know the taste. I'm a hunter, I need to hunt");
        }

        public override void heal()
        {
            if (m_bIsNice)
                Console.WriteLine("Maybe I should exercise more, lucky this guys is here to help");
            else
                Console.WriteLine("Thank you doctor, I'll eat you last when I'll escape from here");
        }
    }
}

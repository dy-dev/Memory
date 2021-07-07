using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooCorrection
{
    class Lion : Animal, IHunter
    {
        public Lion()
        {
            m_bIsHuntable = false;
        }
        public override void accept(VisitorCaretaker visitor)
        {
            visitor.visit(this);
        }

        public override void eat()
        {
            if (IsNice)
                Console.WriteLine("Diner is served, that's nice!!! No need to run, life is cool");
            else
                Console.WriteLine("Raw meat. Not bad but one day I think I'll try to feed on this punny human just to know the taste. I'm a hunter, I need to hunt");
        }

        public override void heal()
        {
            if (IsNice)
                Console.WriteLine("Maybe I should exercise more, lucky this guys is here to help");
            else
                Console.WriteLine("Thank you doctor, I'll eat you last when I'll escape from here");
        }

        public void Hunt(Animal prey)
        {
            if(prey.canBeHunt())
                Console.WriteLine("Je cours apres la bestion et si je l'attrape je la bouffe");
            else
                Console.WriteLine("c'est un pote je vais pas le bouffer");
        }
    }
}

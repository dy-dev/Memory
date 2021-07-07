using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Feeder : VisitorCaretaker
    {
        public override void visit(Dolphin p_pDolphin)
        {
            if (p_pDolphin.isNice())
                Console.WriteLine("Let's go feeding the Dolphin this is going to be fun");
            else
                Console.WriteLine("Sometimes I rather feed the shark I feel more secure with them than with this psycho");
            p_pDolphin.eat();
        }

        public override void visit(Lion p_pLion)
        {
            if (p_pLion.isNice())
                Console.WriteLine("He might be big, but he is so playful, he is like a giant kitten");
            else
                Console.WriteLine("I'm scared I have to bring meat to the lion and I don't like the way he looks at me");
            p_pLion.eat();
        }
    }
}

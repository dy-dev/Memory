﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooCorrection
{
    class Veterinary : VisitorCaretaker
    {
        public override void visit(Dolphin p_pDolphin)
        {
            if (p_pDolphin.IsNice)
                Console.WriteLine("Cool I'm gonna visit the dolphin they are so fun");
            else
                Console.WriteLine("I hope he will not try to drown me like last time. Playful accident my ass, he is a psycho");
            p_pDolphin.heal();
        }

        public override void visit(Lion p_pLion)
        {
            if (p_pLion.IsNice)
                Console.WriteLine("Ohhh, big kitty needs has a tumy ache, let me heal that quickly");
            else
                Console.WriteLine("Today I have to take care of the lion, he gives me the creep");
            p_pLion.heal();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooCorrection
{
    class Feeder : VisitorCaretaker
    {
        public delegate String RecipeDelegate(Animal animal);

        public RecipeDelegate MyCookingSkill;
        public event RecipeDelegate AgainCookingSkill;

        public Action<Animal> AnotherCookingSkill;
        public Func<Animal, String> AnotherAnotherCookingSkill;


        public override void visit(Dolphin p_pDolphin)
        {
            if (p_pDolphin.IsNice)
                Console.WriteLine("Let's go feeding the Dolphin this is going to be fun");
            else
                Console.WriteLine("Sometimes I rather feed the shark I feel more secure with them than with this psycho");

            if (MyCookingSkill != null)
                Console.WriteLine(MyCookingSkill(p_pDolphin));
            p_pDolphin.eat();
        }

        public override void visit(Lion p_pLion)
        {
            if (p_pLion.IsNice)
                Console.WriteLine("He might be big, but he is so playful, he is like a giant kitten");
            else
                Console.WriteLine("I'm scared I have to bring meat to the lion and I don't like the way he looks at me");
            p_pLion.eat();
        }

        public void doSomething(RecipeDelegate todo , Animal a)
        {
            //Tout un paquet de chose que le feed va faire
            todo(a);
        }
    }
}

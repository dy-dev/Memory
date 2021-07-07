using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPolymorphism
{
    class Cat : Animal
    {
        public Cat(String aName):base(aName)
        {

        }

        public override void eat()
        {
            Console.WriteLine("J'ai envie de sardine");
        }

        public override void playwithAnotherAnimal(Cat dc)
        {
            Console.WriteLine("Miaou Miaou"); ;
        }

        public override void playwithAnotherAnimal(Dog d)
        {
            Console.WriteLine("Kai Kai Kai");
        }

        public override void playwithAnotherAnimal(Eagle e)
        {
            Console.WriteLine("Je vais me faire bouffer");
        }

        public override void visitAnotherAnimal(Animal d)
        {
            d.playwithAnotherAnimal(this);
        }
    }
}

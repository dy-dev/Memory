using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPolymorphism
{
    class Eagle : Animal
    {
        public Eagle(String aName) : base(aName)
        {

        }

        public override void eat()
        {
            Console.WriteLine("Je vais bouffer un rongeur");
        }

        public override void playwithAnotherAnimal(Cat dc)
        {
            Console.WriteLine("C'est pareil qu'un rongeur");
        }

        public override void playwithAnotherAnimal(Dog d)
        {
            Console.WriteLine("J'ai pas la force de le porter");
        }

        public override void playwithAnotherAnimal(Eagle e)
        {
            Console.WriteLine("On a vraiment trop la classe");
        }

        public override void visitAnotherAnimal(Animal d)
        {
            d.playwithAnotherAnimal(this);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPolymorphism
{
    class Dog : Animal
    {

        public Dog(String aName) : base(aName)
        {

        }

        public override void eat()
        {
            Console.WriteLine("J'ai envie d'un Os");
        }
        public override void visitAnotherAnimal(Animal d)
        {
            d.playwithAnotherAnimal(this);
        }
      

      
        public override void playwithAnotherAnimal(Cat dc)
        {
            Console.WriteLine("Je deteste les chats");
        }

        public override void playwithAnotherAnimal(Dog d)
        {
            Console.WriteLine("Wouf Wouf");
        }

        public override void playwithAnotherAnimal(Eagle e)
        {
            Console.WriteLine("Je suis trop gros pour toi");
        }

      
    }
}

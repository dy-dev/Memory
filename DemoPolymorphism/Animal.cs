using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPolymorphism
{
    abstract class Animal
    {
        protected String name;

        public Animal(String aname)
        {
            name = aname;
        }

        virtual public void eat()
        {
            Console.WriteLine("J'ai envie de manger");
        }


        public void play(String game)
        {
            Console.WriteLine($"Je joue à {game}");
        }

        public void play(Animal animal)
        {
         
        }


        public abstract void visitAnotherAnimal(Animal d);
     


        public abstract void playwithAnotherAnimal(Dog d);
        public abstract void playwithAnotherAnimal(Cat dc);
        public abstract void playwithAnotherAnimal(Eagle e);
    }
}

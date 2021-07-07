using System;

namespace DemoPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] a = new Animal[3];

            a[0] = new Cat("Felix");
            a[1] = new Dog("Medor");
            a[2] = new Eagle("Robert");

            foreach (var animal in a)
            {
                animal.eat();
            }
            a[0].visitAnotherAnimal(a[1]);
            a[0].visitAnotherAnimal(a[2]);
            a[1].visitAnotherAnimal(a[1]);
            a[1].visitAnotherAnimal(a[2]);
            a[2].visitAnotherAnimal(a[1]);

        }
    }
}

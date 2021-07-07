using System;
using System.Collections.Generic;

namespace ZooCorrection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> zoo = new List<Animal>();
            zoo.Add(new Lion());
            zoo[0].Weight = 10;

            zoo.Add(new Dolphin());
            try
            {
                zoo[1].Weight = 0;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Cette valeur n'est pas acceptée");
                zoo[1].Weight =10;

            }
            zoo.Add(new Eagle());

            VisitorCaretaker[] caretekers = new VisitorCaretaker[2];
            caretekers[0] = new Veterinary();
            caretekers[1] = new Feeder();

            //foreach (var animal in zoo)
            //{
            //    foreach (var caretaker in caretekers)
            //    {
            //        animal.accept(caretaker);
            //    }
            //}

            IHunter[] hunters = new IHunter[2];
            hunters[0] = new Lion();
            hunters[1] = new FuckingTouriste();

            foreach (var hunter in hunters)
            {
                foreach (var animal in zoo)
                {
                    hunter.Hunt(animal);
                }
            }
        }
    }
}

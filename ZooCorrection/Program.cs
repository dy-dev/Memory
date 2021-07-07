using System;

namespace ZooCorrection
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] zoo = new Animal[3];
            zoo[0] = new Lion();
            zoo[0].Weight = 10;

            zoo[1] = new Dolphin();
            try
            {
                zoo[1].Weight = 0;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Cette valeur n'est pas acceptée");
                zoo[1].Weight =10;

            }
            zoo[2] = new Eagle();

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

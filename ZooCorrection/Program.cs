using System;

namespace ZooCorrection
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] zoo = new Animal[2];
            zoo[0] = new Lion();
            zoo[1] = new Dolphin();

            VisitorCaretaker[] caretekers = new VisitorCaretaker[2];
            caretekers[0] = new Veterinary();
            caretekers[1] = new Feeder();

            foreach (var animal in zoo)
            {
                foreach (var caretaker in caretekers)
                {
                    animal.accept(caretaker);
                }
            }
        }
    }
}

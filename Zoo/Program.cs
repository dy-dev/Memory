using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] zoo = new Animal[2];
            zoo[0] = new Lion();
            zoo[1] = new Dolphin();

            VisitorCaretaker[] caretakers = new VisitorCaretaker[2];
            caretakers[0] = new Veterinary();
            caretakers[1] = new Feeder();

            foreach (var animal in zoo)
            {
                foreach (var caretaker in caretakers)
                {
                    animal.accept(caretaker);
                }
            }
        }
    }
}

using System;
using System.Timers;

namespace Memory
{
    class Program
    {
        static void Main(string[] args)
        {
            Category cat = (Category) GetEnumSelection(nameof(Category), typeof(Category));
            Difficulty diff = (Difficulty)GetEnumSelection(nameof(Difficulty), typeof(Difficulty));

            Console.WriteLine($"You selected {cat} and {diff}");

            Game myGame = new Game(cat, diff);
            myGame.StartGame();

            Player p = new Player();


            Card c1 = new Card(20);
            Card c2 = new Card(42);
            Card c3 = c1 + c2;
            Card c4 = Card.Add(c1 , c2);


            Timer myTimer = new Timer();
            myTimer.Interval = 2000;
            myTimer.Elapsed += DisplaySomething;
            myTimer.Start();
            while (true) { }
        }

        private static void DisplaySomething(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(sender.ToString());
        }

        private static int GetEnumSelection(String enumName, Type enumType)
        {
            Console.WriteLine($"To select {enumName} type : ");
            foreach (var item in Enum.GetValues(enumType))
            {
                Console.WriteLine($"{(int)item} - {item}");
            }

            return int.Parse(Console.ReadLine());
        }
    }
}

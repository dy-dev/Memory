using System;

namespace Memory
{
    class Program
    {
        static void Main(string[] args)
        {
            Category cat = (Category)GetEnumSelection(nameof(Category), typeof(Category));
            Difficulty diff = (Difficulty)GetEnumSelection(nameof(Difficulty), typeof(Difficulty));

            Console.WriteLine($"You selected {cat} and {diff}");
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

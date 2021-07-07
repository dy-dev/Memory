using System;
using System.Collections.Generic;
using System.Diagnostics;

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
                zoo[1].Weight = 10;

            }
            zoo.Add(new Eagle());

            VisitorCaretaker[] caretekers = new VisitorCaretaker[2];
            caretekers[0] = new Veterinary();
            caretekers[1] = new Feeder();


            //Je récupère sur mon tableau tous les animaux qui sont gentil
            Array.Find<Animal>(zoo.ToArray(), (Animal a)=> a.IsNice );
            //Autre facon de faire plus simple sans passer par les tableaux
            zoo.Find((Animal a) => a.IsNice);

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


            List<Feeder> f = new List<Feeder>();
            f.Add(new Feeder());
            f[0].MyCookingSkill = FaireABouffer;
            f.Add(new Feeder());
            f[1].MyCookingSkill = FaireBienABouffer;
            f.Add(new Feeder());
            f[2].MyCookingSkill = FaireMalABouffer;

            foreach (var feed in f)
            {
                Console.WriteLine( feed.MyCookingSkill(zoo[1]));
            }

            f[0].doSomething(FaireABouffer, zoo[0]);


            Feeder superFeeder = new Feeder();
            superFeeder.MyCookingSkill = FaireABouffer;
            superFeeder.MyCookingSkill += FaireBienABouffer;
            superFeeder.MyCookingSkill += FaireMalABouffer;
            superFeeder.AgainCookingSkill += SuperFeeder_AgainCookingSkill;

            superFeeder.MyCookingSkill += delegate (Animal animal) { return "Toto"; };
            superFeeder.AnotherCookingSkill += Test; 
            superFeeder.AnotherAnotherCookingSkill += FaireABouffer; 
            Console.WriteLine(superFeeder.MyCookingSkill(zoo[1]));


            Veterinary v = new Veterinary() { Name = "Toto"} ;
            v.ActOfChirurgy += FirstAct;
            v.ActOfChirurgy += SecondAct;

            v.Operate(zoo[0]);
        }

        private static void SecondAct(object sender, ChirurgyEventArgs e)
        {
            Console.WriteLine($"{e.Doctor.Name} has saved {e.Patient.GetType().Name}");
        }

        private static void FirstAct(object sender, ChirurgyEventArgs e)
        {
            Console.WriteLine($"{e.Doctor.Name} has lost {e.Patient.GetType().Name}");
        }

        private static string SuperFeeder_AgainCookingSkill(Animal animal)
        {
            throw new NotImplementedException();
        }

        public static void Test(Animal a)
        {

        }

        public static String FaireABouffer(Animal animal)
        {
            Debug.WriteLine("FaireABouffer");
            return $"J'ai fait à manger pour {animal.GetType().ToString()}";
        }
        public static String FaireBienABouffer(Animal animal)
        {
            Debug.WriteLine("FaireBienABouffer");
            return $"J'ai fait un super repas pour {animal.GetType().ToString()}";
        }
        public static String FaireMalABouffer(Animal animal)
        {
            Debug.WriteLine("FaireMalABouffer");
            return $"J'ai fait un super repas avec {animal.GetType().ToString()}";
        }
    }
}

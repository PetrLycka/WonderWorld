using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WonderWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ďábelská kočka nad město Dolie vypustila růžový mrak. Všichni obyvatelé městečka vyšli ven, aby se podívali na tento podivuhodný úkaz. Každý v městečku se tímto mrakem nakazil a proměnil se v padoucha.");

            Console.WriteLine("Vítejte ve hře na textovém rozhraní!");
            Console.WriteLine("Vyberte svou postavu:");
            Console.WriteLine("1. Ptakopysk");
            Console.WriteLine("2. Pežina");
            Console.WriteLine("3. Ondralinka");

            Postava hracovaPostava = ZvolitHracovuPostavu();

            Console.WriteLine($"Vybrali jste si postavu {hracovaPostava.Jmeno}.");

            // Herní smyčka
            while (true)
            {
                Console.WriteLine("Co byste chtěli udělat?");
                Console.WriteLine("1. Interagovat");
                Console.WriteLine("2. Ukončit");

                string volba = Console.ReadLine();

                switch (volba)
                {
                    case "1":
                        hracovaPostava.Interagovat();
                        break;
                    case "2":
                        Console.WriteLine("Děkujeme za hraní!");
                        return;
                    default:
                        Console.WriteLine("Neplatná volba. Zkuste to znovu.");
                        break;
                }
            }
        }

        static Postava ZvolitHracovuPostavu()
        {
            while (true)
            {
                string volba = Console.ReadLine();

                switch (volba)
                {
                    case "1":
                        return new Postava("Ptakopysk");
                    case "2":
                        return new Postava("Pežina");
                    case "3":
                        return new Postava("Ondralinka");
                    default:
                        Console.WriteLine("Neplatná volba. Zkuste to znovu.");
                        break;
                }
            }
        }
    }

    class Postava
    {
        public string Jmeno { get; }

        public Postava(string jmeno)
        {
            Jmeno = jmeno;
        }

        public void Interagovat()
        {
            Console.WriteLine($"Interakce s postavou {Jmeno}...");
            // Přidejte sem vlastní interakce
        }
    }
}
    

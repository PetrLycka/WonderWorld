using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WonderWorld
{
    namespace WonderWorld
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Title = "WonderWorld";

                Console.WriteLine("Vítejte ve hře WonderWorld!");
                Console.WriteLine("UPOZORNĚNÍ! Tato hra obsahuje postavy a názvy čistě fiktivní s žádnou inspirací z reálného světa :)");
                Console.WriteLine();
                Console.WriteLine("Stiskněte libovolnou klávesu pro pokračování...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Vyberte svou postavu:");
                Console.WriteLine("1. Ptakopysk");
                Console.WriteLine("2. Pežina");
                Console.WriteLine("3. Ondralinka");
                Console.WriteLine("Výběr postavy mění mírně obtížnost");

                Postava hracovaPostava = ZvolitHracovuPostavu();
                Console.Clear();

                VypsatProlog(hracovaPostava);
                Console.WriteLine();
                Console.WriteLine("Stiskněte libovolnou klávesu pro pokračování...");
                Console.ReadKey();
                Console.Clear();

                // Herní smyčka
                while (true)
                {
                    Console.WriteLine("Co byste chtěli udělat?");
                    Console.WriteLine("1. Interagovat");
                    Console.WriteLine("2. Ukončit");

                    string volba = Console.ReadLine();
                    Console.Clear();

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

                    Console.WriteLine();
                    Console.WriteLine("Stiskněte libovolnou klávesu pro pokračování...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            static Postava ZvolitHracovuPostavu()
            {
                while (true)
                {
                    string volba = Console.ReadLine();
                    Console.Clear();

                    switch (volba)
                    {
                        case "1":
                            return new Postava("Ptakopysk", "");
                        case "2":
                            return new Postava("Pežina", "");
                        case "3":
                            return new Postava("Ondralinka", "");
                        default:
                            Console.WriteLine("Neplatná volba. Zkuste to znovu.");
                            Console.Clear();
                            Console.WriteLine("Vyberte svou postavu:");
                            Console.WriteLine("1. Ptakopysk");
                            Console.WriteLine("2. Pežina");
                            Console.WriteLine("3. Ondralinka");
                            break;
                    }
                }
            }

            static void VypsatProlog(Postava hracovaPostava)
            {
                switch (hracovaPostava.Jmeno)
                {
                    case "Ptakopysk":
                        Console.WriteLine("Ďábelská kočka nad město Dolie vypustila růžový mrak. Všichni obyvatelé městečka vyšli ven, aby se podívali na tento podivuhodný úkaz. Každý v městečku se nakazil látkou která je mění v agresivní nepřátele.");
                        Console.WriteLine("Jako ptakopysk jste se nenakazil, jelikož látka nepůsobí na zvířata.");
                        Console.WriteLine("Všichni Vaší blízcí se nakazili. Jelikož jsi jediný, kterému se toto nestalo, rozhodnete se zachránit přátele. Připravíte se na cestu.");
                        break;
                    case "Pežina":
                        Console.WriteLine("Ďábelská kočka nad město Dolie vypustila růžový mrak. Všichni obyvatelé městečka vyšli ven, aby se podívali na tento podivuhodný úkaz. Každý v městečku se nakazil látkou která je mění v agresivní nepřátele.");
                        Console.WriteLine("Jako geniální vědec a programátor máte svůj dům připravený na všechno. Ven se vypravujete s maskou");
                        Console.WriteLine("Všichni Vaší blízcí se nakazili.Jelikož jsi jediný, kterému se toto nestalo, rozhodnete se zachránit  přátele.Připravíte se na cestu.");
                        break;
                    case "Ondralinka":
                        Console.WriteLine("Ďábelská kočka nad město Dolie vypustila růžový mrak. Všichni obyvatelé městečka vyšli ven, aby se podívali na tento podivuhodný úkaz. Každý v městečku se nakazil látkou která je mění v agresivní nepřátele.");
                        Console.WriteLine("Látka Ondralinkovi nic nedělá, na mutanty zřejmě nefunguje.");
                        Console.WriteLine("Všichni Vaší blízcí se nakazili. Jelikož jsi jediný, kterému se toto nestalo, rozhodnete se zachránit  přátele. Připravíte se na cestu.");
                        break;
                }
            }
        }

        class Postava
        {
            public string Jmeno { get; }
            public string Prolog { get; }

            public Postava(string jmeno, string prolog)
            {
                Jmeno = jmeno;
                Prolog = prolog;
            }

            public void Interagovat()
            {
                Console.WriteLine($"Interakce s postavou {Jmeno}...");
                // Přidejte sem vlastní interakce
            }
        }
    }
}




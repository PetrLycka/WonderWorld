using System;

class Program
{
    static bool hasGoldCoin = false; // Flag to track if the player has the gold coin

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

        ZacitHru(hracovaPostava);

        Console.WriteLine();
        Console.WriteLine("Stiskněte libovolnou klávesu pro pokračování...");
        Console.ReadKey();
        Console.Clear();

        // Herní smyčka
        while (true)
        {
            Console.WriteLine("Co byste chtěli udělat?");
            Console.WriteLine("1. Ukončit");

            string volba = Console.ReadLine();
            Console.Clear();

            switch (volba)
            {
                case "1":
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
                    return new Postava("Ptakopysk", "Ďábelská kočka nad město Dolie vypustila růžový mrak. Všichni obyvatelé městečka vyšli ven, aby se podívali na tento podivuhodný úkaz. Každý v městečku se nakazil látkou která je mění v agresivní nepřátele.\nJako ptakopysk jste se nenakazil, jelikož látka nepůsobí na zvířata.\nVšichni Vaši blízcí se nakazili. Jelikož jste jediný, kterému se toto nestalo, rozhodnete se zachránit přátele. Připravíte se na cestu.");
                case "2":
                    return new Postava("Pežina", "Ďábelská kočka nad město Dolie vypustila růžový mrak. Všichni obyvatelé městečka vyšli ven, aby se podívali na tento podivuhodný úkaz. Každý v městečku se nakazil látkou která je mění v agresivní nepřátele.\nJako geniální vědec a programátor máte svůj dům připravený na všechno. Ven se vypravujete s maskou.\nVšichni Vaši blízcí se nakazili. Jelikož jste jediný, kterému se toto nestalo, rozhodnete se zachránit přátele. Připravíte se na cestu.");
                case "3":
                    return new Postava("Ondralinka", "Ďábelská kočka nad město Dolie vypustila růžový mrak. Všichni obyvatelé městečka vyšli ven, aby se podívali na tento podivuhodný úkaz. Každý v městečku se nakazil látkou která je mění v agresivní nepřátele.\nLátka Ondralinkovi nic nedělá, na mutanty zřejmě nefunguje.\nVšichni Vaši blízcí se nakazili. Jelikož jste jediný, kterému se toto nestalo, rozhodnete se zachránit přátele. Připravíte se na cestu.");
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

    static void ZacitHru(Postava hracovaPostava)
    {
        Console.WriteLine($"Vybrali jste si postavu {hracovaPostava.Jmeno}.");
        Console.WriteLine("=== Úvodní příběh ===");
        Console.WriteLine(hracovaPostava.Prolog);

        Console.WriteLine();
        Console.WriteLine("Vydáváš se tedy na cestu za známým kouzelníkem Bumbálem, který by Ti mohl poradit kde se Ďábelská kočka nachází.");

        Console.WriteLine();
        Console.WriteLine("Jakou cestou se vydáte?");
        Console.WriteLine("1. Městem plným infikovaných");
        Console.WriteLine("2. Tunely");

        string volba = Console.ReadLine();
        Console.Clear();

        if (volba == "1" && hracovaPostava.Jmeno != "Ptakopysk")
        {
            Console.WriteLine("Bohužel, v městě plném infikovaných nepřežil nikdo kromě Ptakopyska.");
            Console.WriteLine("Zemřel jsi.");
            Console.WriteLine("Stiskněte libovolnou klávesu pro ukončení hry...");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Nacházíš se za bránami Vašeho města. Procházíš úzkou kamennou cestou, která vede k domu kouzelníka.");
        Console.WriteLine("Vejdeš dovnitř. Nikoho nevidíš.");
        Console.WriteLine("Uprostřed místnosti se nachází portál. Můžete jím projít nebo nejprve prohledat dům.");

        Console.WriteLine();
        Console.WriteLine("Co uděláte?");
        Console.WriteLine("1. Projít portálem");
        Console.WriteLine("2. Prohledat dům");

        volba = Console.ReadLine();
        Console.Clear();

        if (volba == "2")
        {
            Console.WriteLine("Při prohledávání domu jste našli zlatou minci. Bude se Vám později hodit.");
            hasGoldCoin = true;
        }
        if (hasGoldCoin)
        {
            Console.WriteLine("Máte u sebe zlatou minci, kterou jste našli v domě.");
            Console.WriteLine("Můžete ji využít při nákupu v obchodě.");
        }

        Console.WriteLine("Rozhodl(a) jste se projít portálem.");


        Console.WriteLine("Ocitneš se na lesní cestičce. Procházíš lesem, zatímco vpravo od sebe uvidíš skříň. Podíváš se dovnitř?");

        Console.WriteLine();
        Console.WriteLine("Co uděláte?");
        Console.WriteLine("1. Ano, podívám se dovnitř");
        Console.WriteLine("2. Ne, nepodívám se");

        volba = Console.ReadLine();
        Console.Clear();

        if (volba == "1")
        {
            Console.WriteLine("Podíváte se do skříně.");
            Console.WriteLine("Uvnitř najdete klobouk s nápisem 'Perry'.");
            Console.WriteLine("Co uděláte?");
            Console.WriteLine("1. Vezmu si klobouk a nasadím ho");
            Console.WriteLine("2. Pouze se podívám na klobouk a label s nápisem 'Perry'");

            volba = Console.ReadLine();
            Console.Clear();

            if (volba == "1" && hracovaPostava.Jmeno == "Ptakopysk")
            {
                Console.WriteLine("Vezmete si klobouk a nasadíte ho. Cítíte, jak se najednou vaše tělo mění.");
                Console.WriteLine("Vaše jméno se nyní změnilo na Perry.");
                hracovaPostava.Jmeno = "Perry";
            }
            else
            {
                Console.WriteLine("Podíváte se na klobouk a label s nápisem 'Perry', ale nic se neděje.");
                Console.WriteLine("Pak pokračujete na své cestě.");
            }
        }
        else
        {
            Console.WriteLine("Nepodíváte se do skříně a pokračujete na své cestě.");
        }
    }
}

class Postava
{
    public string Jmeno { get; set; }
    public string Prolog { get; set; }

    public Postava(string jmeno, string prolog)
    {
        Jmeno = jmeno;
        Prolog = prolog;
    }
}
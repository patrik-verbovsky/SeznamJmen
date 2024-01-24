// Vytvoření listu
List<string> seznamJmen = new List<string>();
bool ukonceni = false;
while (!ukonceni)
{
    // Vytváření menu
    Console.WriteLine("SEZNAM JMEN");
    Console.WriteLine("======================");
    Console.WriteLine("1 - Přidat jméno");
    Console.WriteLine("2 - Odebrat jméno");
    Console.WriteLine("3 - Zobrazit seznam");
    Console.WriteLine("4 - Najít jméno");
    Console.WriteLine("5 - Smaž seznam");
    Console.WriteLine("======================");
    Console.WriteLine("0 - Ukončit program");
    Console.Write("======================\nTvoje volba: ");
    int vyber;

    // Neplatná volba
    while (!int.TryParse(Console.ReadLine(), out vyber) || vyber < 0 || vyber > 5)
    {
        Console.WriteLine("Neplatná volba. Zadej znovu.");
    }
    switch (vyber)
    {
        case 1:
            // Přidání jména
            Console.Clear();
            Console.WriteLine("PŘIDÁNÍ JMÉNA\n======================");
            Console.Write("Jaké jméno chceš přidat?\n\n");
            string jmenoNaPridani = Console.ReadLine();
            seznamJmen.Add(jmenoNaPridani);
            Console.Clear();
            Console.WriteLine("INFO\n======================\nPřidáno jméno " + jmenoNaPridani + " do seznamu.");
            Thread.Sleep(500);
            Console.Clear();
            break;

        case 2:
            // Odebrání jména
            Console.Clear();
            Console.WriteLine("ODEBRÁNÍ JMÉNA\n======================");
            Console.WriteLine("Jaké jméno chceš odebrat?\n");
            string jmenoNaOdebrani = Console.ReadLine();
            if (!seznamJmen.Contains(jmenoNaOdebrani, StringComparer.OrdinalIgnoreCase))
            {
                Console.Clear();
                Console.WriteLine("CHYBA!\n======================\nSeznam jmen neobsahuje takové jméno.");
                Thread.Sleep(2000);
            }
            else
            {
                seznamJmen.RemoveAll(x => x.Equals(jmenoNaOdebrani, StringComparison.OrdinalIgnoreCase));
                Console.Clear();
                Console.WriteLine("INFO\n======================\nOdebráno jméno " + jmenoNaOdebrani + " ze seznamu.");
                Thread.Sleep(500);
                Console.Clear();
            }
            Console.Clear();
            break;

        case 3:
            // Zobrazit všechny jména
            Console.Clear();
            foreach (string jmeno in seznamJmen)
            {
                Console.WriteLine(jmeno);
            }
            Console.WriteLine("\nStiskni jakoukoliv klávesu pro navrácení do menu.");
            Console.ReadKey();
            Console.Clear();
            break;

        case 4:
            // Vyhledání jména
            Console.Clear();
            Console.WriteLine("JMÉNO NA VYHLEDÁNÍ\n======================");
            Console.WriteLine("Jaké jméno chceš vyhledat?");
            string jmenoNaVyhledani = Console.ReadLine();
            List<string> nalezenajmena = seznamJmen.FindAll(y => y.StartsWith(jmenoNaVyhledani, StringComparison.OrdinalIgnoreCase));
            Console.Clear();
            Console.WriteLine("INFO\n======================");
            foreach (string jmeno in nalezenajmena)
            {
                Console.Clear();
                Console.WriteLine("Seznam jmen obsahuje jméno " + jmeno + ".");
                Thread.Sleep(1000);
            }
            Console.Clear();
            break;

        case 5:
            // Vymazání všech jmen
            Console.Clear();
            Console.WriteLine("Opravdu to chceš vymazat (a/n)?");
            string vymazat = Console.ReadLine();
            string a = vymazat.ToUpper();
            Console.Clear();
            if (a == "A")
            {
                Console.WriteLine("OPRAVDU to chceš vymazat (a/n)?");
                string vymazat2 = Console.ReadLine();
                string a2 = vymazat2.ToUpper();
                Console.Clear();
                if (a2 == "A")
                {
                    seznamJmen.Clear();
                    Console.WriteLine("INFO\n======================\nSeznam jmen byl vymazán.");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
            break;

        case 0:
            ukonceni = true;
            break;
    }
}
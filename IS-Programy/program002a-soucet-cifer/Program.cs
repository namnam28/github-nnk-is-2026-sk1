string again = "a";

while (again.ToLower() == "a")
{

    Console.Clear();

    // Hlavička programu
    Console.WriteLine("***********************************");
    Console.WriteLine("************Název Programu*************");
    Console.WriteLine("***********************************");
    Console.WriteLine("***********Ngo Nam Khánh***********");
    Console.WriteLine("***********************************");



    // Načtení hodnoty
    Console.Write("Zadejte číslo (celé číslo): ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezdali jste celé číslo. Zadejte číslo znovuu: ");        
    }



    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("===========================");
    Console.WriteLine($"Zadané číslo: {number}");
    Console.WriteLine("===========================");
    Console.WriteLine();
    Console.WriteLine();

    // zde budemem pokračovat

    // Příprava pomocných proměnných pro výpočet
    int numberBackup = number;
    int sum = 0;    // Neutrální hodnota pro sčítání je 0
    int digit;      // proměnná pro uložení právě zjištěné číslice

    // Ošetření záporných čísel (znaménko nemá vliv na číslice)
    if (number < 0)
    {
        number = -number;
    }

    // Zvláštní případ pro nulu
    if (number == 0)
    {
        sum = 0;
        multi = 1;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Průběh rozkladu čísla na číslice (zprava doleva)");

        // Matematický rozklad čísla pomocí cyklu
        while (number > 0)
        {
            digit = number % 10; // Modulo 10 - získáme poslední číslici
            sum = sum + digit;   // Přičtení říslice k celkovému součtu
            Console.WriteLine($"Získaná číslice: {digit}");
            number = number / 10; // Celočíselné dělení 10 odstraní poslední číslici
            multi = multi * digit;
        }
    }

    // Výpis výsledků
    Console.WriteLine();
    Console.WriteLine("====================");
    Console.WriteLine($"Součet číslic čísla {numberBackup} je {sum}");
    Console.WriteLine($"Součin číslic čísla {numberBackup} je {multi}");

    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter");
    again = Console.ReadLine() ?? "";


}
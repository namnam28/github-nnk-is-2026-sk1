string again = "a";

while (again.ToLower() == "a")
{

    Console.Clear();

    Console.WriteLine("***********************************");
    Console.WriteLine("***Součet a součin cifer čísla****");
    Console.WriteLine("***********************************");
    Console.WriteLine("***********Ngo Nam Khánh***********");
    Console.WriteLine("***********************************");
    Console.WriteLine();


    Console.Write("Zadejte celé číslo: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("===========================");
    Console.WriteLine($"Zadané číslo: {number}");
    Console.WriteLine("===========================");
    Console.WriteLine();

    // Příprava proměnných pro výpočet
    // Math.Abs zajistí správné zpracování i pro záporná čísla
    int temp = Math.Abs(number);
    int suma = 0;
    int multi = (temp == 0) ? 0 : 1; // Pro nulu je součin 0, pro ostatní začínáme od 1

    Console.WriteLine("Jednotlivé cifry:");

    // Zvláštní ošetření pro číslo 0
    if (temp == 0)
    {
        Console.WriteLine("Cifra = 0");
        suma = 0;
        multi = 0;
    }
    else
    {
        // Standardní cyklus dělení modulo (bez nutnosti dopočítávání za cyklem)
        while (temp > 0)
        {
            int digit = temp % 10;
            Console.WriteLine($"Cifra = {digit}");

            suma += digit;
            multi *= digit;

            temp /= 10; // Zkrácení čísla celočíselným dělením
        }
    }

    // Výpis výsledků
    Console.WriteLine();
    Console.WriteLine("===========================");
    Console.WriteLine($"Součet cifer čísla {number} je: {suma}");
    Console.WriteLine($"Součin cifer čísla {number} je: {multi}");
    Console.WriteLine("===========================");
    Console.WriteLine();

    // Dotaz směrem k uživateli na opakování
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}
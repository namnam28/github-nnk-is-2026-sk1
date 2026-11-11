string again = "a";

while (again.ToLower() == "a")
{

    Console.Clear();

    Console.WriteLine("***********************************");
    Console.WriteLine("**************Vykreslování pravoúhlého trojúhelníku*************");
    Console.WriteLine("***********************************");
    Console.WriteLine("***********Ngo Nam Khánh***********");
    Console.WriteLine("***********************************");
    Console.WriteLine();


    // Načtení výšky
    Console.Write("Zadejte šířku obrazce (celé kladné číslo): ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste kladné celé číslo. Zadejte výšku znovu: ");
        Console.ResetColor();
    }

    // Jádro problému
    // Vnější cyklus, který nám bude hlídat počet řádků (shora dolů)
    for(int i = i <= height; i++)
    {
        for (int j = 1; j < i; j++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("===========================");
    Console.WriteLine($"Zadaná šířka: {width}; Zadaná výška: {height}");
    Console.WriteLine("===========================");
    Console.WriteLine();



    // Dotaz směrem k uživateli na opakování
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}


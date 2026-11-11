string again = "a";

while (again.ToLower() == "a")
{

    Console.Clear();

    Console.WriteLine("***********************************");
    Console.WriteLine("**************Vykreslování obdélníku*************");
    Console.WriteLine("***********************************");
    Console.WriteLine("***********Ngo Nam Khánh***********");
    Console.WriteLine("***********************************");
    Console.WriteLine();

    // Načtení šířky
    Console.Write("Zadejte šířku obrazce (celé kladné číslo): ");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width) || width <= 0)
    {
        Console.ForeGroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste kladné celé číslo. Zadejte šířku znovu: ");
        Console.ResetColor();
    }

    // Načtení výšky
    Console.Write("Zadejte šířku obrazce (celé kladné číslo): ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
    {
        Console.ForeGroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste kladné celé číslo. Zadejte výšku znovu: ");
        Console.ResetColor();
    }

    // Jádro problému
    // Vnější cyklus, který nám bude hlídat počet řádků (shora dolů)
    for(int i = 1; i <= height; i++)
    {   
        // Vnitřní cyklus, který se nám postará o ot, aby se v každém řádku vykreslil správně
        for(int j = 1; intj <= width; j++)
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


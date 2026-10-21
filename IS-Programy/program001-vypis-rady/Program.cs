string again = "a";

// Řídící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A"
// Jakkýkoli jiný vstup program ukončí
while (again.ToLower() == "a")
{
    // Vymazání konzole
    Console.Clear();

    // Hlavička programu
    Console.WriteLine("***********************************");
    Console.WriteLine("************Výpis řady*************");
    Console.WriteLine("***********************************");
    Console.WriteLine("***********Ngo Nam Khánh***********");
    Console.WriteLine("***********************************");

    // Vstup počáteční hodnoty - špatně řešený
    Console.Write("Zadejte první číslo řady: ");
    int first = int.Parse(Console.ReadLine());




    // Vstup počáteční hodnoty
    // Console.Write("Zadejte první číslo řady (celé číslo): ");
    // int first;
    // while (!int.TryParse(Console.ReadLine(), out first))
    // {
    //     Console.Write("Nezdali jste celé číslo. Zadejte první číslo řady znovu: ");        
    // }


    // Načtení koncové hodnoty řady
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezdali jste celé číslo. Zadejte poslední číslo řady znovu: ");        
    }

    // Načtení diference s kontrolou kladného nenulového čísla
    int step;
    while (!int.TryParse(Console.ReadLine(), out step) || step <=0 )
    {
        Console.Write("Nezdali jste celé číslo. Zadejte diferenci znovu: ");        
    }

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter");
    again = Console.ReadLine() ?? "";


}
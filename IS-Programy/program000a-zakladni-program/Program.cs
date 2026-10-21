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
    Console.WriteLine("************Název Programu*************");
    Console.WriteLine("***********************************");
    Console.WriteLine("***********Ngo Nam Khánh***********");
    Console.WriteLine("***********************************");



    // Načtení hodnoty
    Console.Write("Zadejte číslo (celé číslo): ");
    int aaa;
    while (!int.TryParse(Console.ReadLine(), out aaa))
    {
        Console.Write("Nezdali jste celé číslo. Zadejte číslo znovuu: ");        
    }


    // Načtení koncové hodnoty řady
    int bbb;
    while (!int.TryParse(Console.ReadLine(), out bbb))
    {
        Console.Write("Nezdali jste celé číslo. Zadejte číslo znovu: ");        
    }



    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("===========================");
    Console.WriteLine($"První číslo: {aaa}; Další číslo: {bbb}; ");
    Console.WriteLine("===========================");
    Console.WriteLine();
    Console.WriteLine();

    // zde budemem pokračovat
    

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter");
    again = Console.ReadLine() ?? "";


}
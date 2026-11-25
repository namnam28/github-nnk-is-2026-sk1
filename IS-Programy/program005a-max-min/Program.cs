string again = "a";

while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************"); 
    Console.WriteLine("*******Generátor - max, min, hodiny********"); 
    Console.WriteLine("*******************************************"); 
    Console.WriteLine("****************Ngo Nam Khánh**************"); 
    Console.WriteLine();
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (přirozené číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte číslo znovu: ");
    }

    Console.Write("Zadejte dolní mez (přirozené číslo): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte dolní mez znovu: ");
    }

    Console.Write("Zadejte horní mez (celé číslo nebo rovno hodnotě dolní meze): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound) || upperBound <= lowerBound)
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte horní mez znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("======================================");
    Console.WriteLine($"Počet čísel: {n}; Dolní mez: {lowerBound}; Horní mez: {upperBound}");
    Console.WriteLine("======================================");
    Console.WriteLine();
    Console.WriteLine();

    // Deklarace a alokace pole v paměti
    int[] myRandNumbs = new int[n];

    // inicializace generátoru
    Random myRandNumb = new Random();
    // Random myRandNumb = new Random(50);

    // Generování náhodných čísel
    Console.WriteLine("Vygenerovaná psedonáhodná čísla: ");
    for (int i = 0; i < myRandNumbs.Length; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound);
        Console.Write($"{myRandNumbs[i]}; ");  
    }

    // Hledání maxima, minima a jejich prvních pozic
    int max = myRandNumbs[0];
    int min = myRandNumbs[0];
    int posMax = 0; // pozice prvního maxima
    int posMin = 0; // pozice prvního minima

    for (int i = 1; i < n; i++)
    {
        // Zjišťujeme zda i-tý prvek není menší než aktuální hodnota maxima
        if (myRandNumbs[i] > max)
        {
            max = myRandNumbs[i];
            posMax = i;
        }

        // Zjišťujeme zda i-tý prvek není menší než aktuální hodnota minima
        if (myRandNumbs[i] < min)
        {
            min = myRandNumbs[i];
            posMin = i;
        }
    }

    Console.WriteLine();
    Console.WriteLine("======================================");
    Console.WriteLine($"Maximum: {max}");
    Console.WriteLine($"Minimum: {min}");
    Console.WriteLine("======================================");


    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}
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


    int temp = number;
    if (temp < 0)
    {
        temp = -temp;
    }

    int suma = 0;
    int multi = 1;

    Console.WriteLine("Jednotlivé cifry:");

    do
    {
        int digit = temp % 10;          
        Console.WriteLine($"Cifra = {digit}");

        suma += digit;                  
        multi *= digit;                 

        temp /= 10;                     // Celočíselné dělení 10 = odseknutí poslední cifry
    } 
    while (temp > 0);

 
    Console.WriteLine();
    Console.WriteLine("===========================");
    Console.WriteLine($"Součet cifer čísla {number} je: {suma}");
    Console.WriteLine($"Součin cifer čísla {number} je: {multi}");
    Console.WriteLine("===========================");
    Console.WriteLine();


    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}
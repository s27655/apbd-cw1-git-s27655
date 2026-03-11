Console.WriteLine("Witaj w aplikacji!");
Console.WriteLine("-------------------");

Console.Write("Podaj swoje imię: ");
string? imie = Console.ReadLine();

while (string.IsNullOrWhiteSpace(imie))
{
    Console.Write("Imię nie może być puste. Podaj swoje imię: ");
    imie = Console.ReadLine();
}

Console.WriteLine();
Console.WriteLine($"Cześć, {imie}!");
Console.WriteLine($"Twoje imię zapisane wielkimi literami: {imie.ToUpper()}");
Console.WriteLine("Dziękuję za skorzystanie z aplikacji!");

Console.WriteLine();
Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
Console.ReadKey();
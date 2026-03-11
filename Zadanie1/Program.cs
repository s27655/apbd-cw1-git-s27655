Console.WriteLine("Witaj w prostej aplikacji .NET!");
Console.WriteLine("--------------------------------");

Console.Write("Podaj swoje imię: ");
string? imie = Console.ReadLine();

while (string.IsNullOrWhiteSpace(imie))
{
    Console.Write("Imię nie może być puste. Podaj swoje imię: ");
    imie = Console.ReadLine();
}

Console.Write("Podaj swój wiek: ");
string? inputWiek = Console.ReadLine();

int wiek;
while (!int.TryParse(inputWiek, out wiek) || wiek < 0)
{
    Console.Write("Podaj poprawny wiek: ");
    inputWiek = Console.ReadLine();
}

Console.WriteLine();
Console.WriteLine($"Cześć, {imie}!");
Console.WriteLine($"Masz {wiek} lat.");

if (wiek < 18)
{
    Console.WriteLine("Jesteś niepełnoletni.");
}
else
{
    Console.WriteLine("Jesteś pełnoletni.");
}

int lataDo100 = 100 - wiek;

if (lataDo100 > 0)
{
    Console.WriteLine($"Do 100 lat brakuje Ci jeszcze {lataDo100} lat.");
}
else if (lataDo100 == 0)
{
    Console.WriteLine("Masz dokładnie 100 lat!");
}
else
{
    Console.WriteLine("Masz ponad 100 lat!");
}
int[] numbers = { 5, 10, 15, 20 };

double average = CalculateAverage(numbers);

Console.WriteLine($"Średnia wynosi: {average}");

static double CalculateAverage(int[] values)
{
    int sum = 0;

    foreach (int value in values)
    {
        sum += value;
    }

    return (double)sum / values.Length;
}
static int CalculateMax(int[] values)
{
    int max = values[0];

    foreach (int value in values)
    {
        if (value > max)
        {
            max = value;
        }
    }

    return max;
}
Console.WriteLine();
Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
Console.ReadKey();
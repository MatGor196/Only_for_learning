using ConsoleApp;

Console.WriteLine("Witaj w programie do oceny pracowników");
Console.WriteLine("======================================");

var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    employee.AddMark(input);
}

var stat = employee.GetStatistics();

Console.WriteLine();
Console.WriteLine($"Średnia: {stat.average}");
Console.WriteLine($"Min: {stat.min}");
Console.WriteLine($"Max: {stat.max}");
Console.WriteLine($"Ocena literowa: {stat.average_letter}");
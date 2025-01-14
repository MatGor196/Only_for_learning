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

    try
    {
        employee.AddMark(input);
    }
    catch(Exception ex)
    {
        Console.WriteLine($"{ex.Message}");
    }
}

var stat = employee.GetStatistics();

Console.WriteLine();
Console.WriteLine($"Średnia: {stat.average:N2}");
Console.WriteLine($"Min: {stat.min}");
Console.WriteLine($"Max: {stat.max}");
Console.WriteLine($"Ocena literowa: {stat.average_letter}");
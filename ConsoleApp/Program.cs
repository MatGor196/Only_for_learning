using ConsoleApp;

Console.WriteLine("Witaj w programie do oceny pracowników");
Console.WriteLine("======================================");

var employee = new EmployeeInMemory("no name","no surname",0,'M');
employee.MarkAdded += EmployeeMarkAdded;
void EmployeeMarkAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

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
    catch (Exception ex)
    {
        Console.WriteLine($"{ex.Message}");
    }
}

var stat = employee.GetStatistics();

Console.WriteLine();
Console.WriteLine($"średnia: {stat.average:n2}");
Console.WriteLine($"min: {stat.min}");
Console.WriteLine($"max: {stat.max}");
Console.WriteLine($"ocena literowa: {stat.average_letter}");
using ConsoleApp;

var employee1 = new Employee("Adam", "Kowalski", 30);
employee1.AddMark(1);
employee1.AddMark(2);
employee1.AddMark(3);
employee1.AddMark(4);
employee1.AddMark(5);

var employee2 = new Employee("Kasia", "Nowak", 20);
employee2.AddMark(1);
employee2.AddMark(4);
employee2.AddMark(3);
employee2.AddMark(7);
employee2.AddMark(8);

var employee3 = new Employee("Krystian", "Żukowski", 25);
employee3.AddMark(3);
employee3.AddMark(5);
employee3.AddMark(7);
employee3.AddMark(5);
employee3.AddMark(8);

var ListOfEmployees = new List<Employee>()
    {employee1, employee2, employee3};

int result = -1;
var employee_with_max_value = new Employee("---", "---", 0);

foreach (var employee in ListOfEmployees)
{
    var current_result = employee.Result();
    if (current_result > result)
    {
        employee_with_max_value = employee;
        result = current_result;
    }
}

Console.WriteLine("Pracownik z najlepszymi ocenami:");
Console.WriteLine(employee_with_max_value.name + " " +
                  employee_with_max_value.surname + ", " +
                  employee_with_max_value.age);

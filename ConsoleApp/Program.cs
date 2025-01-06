
var name = "Adam";
var sex = true; //true - mężczyzna, false - kobieta
var age = 30;

if(sex == false && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if(name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if(sex == true && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
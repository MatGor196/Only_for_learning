namespace ConsoleApp
{
    public abstract class Person
    {
        private string name;
        private string surname;
        private int age;
        private char sex;

        public Person(string name, string surname, int age, char sex)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.sex = sex;
        }
    }
}

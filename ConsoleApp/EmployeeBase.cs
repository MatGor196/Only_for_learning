namespace ConsoleApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public char sex { get; set; }

        public EmployeeBase(string name, string surname, int age, char sex) 
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.sex = sex;
        }

        public abstract void AddMark(float mark_to_add);

        public abstract void AddMark(int mark_to_add);

        public abstract void AddMark(char mark_to_add);

        public abstract void AddMark(string mark_to_add);

        public abstract Statistics GetStatistics();

        public abstract float Result();
    }
}

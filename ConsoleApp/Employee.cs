namespace ConsoleApp
{
    public class Employee
    {
        public string name { get; private set; }
        public string surname { get; private set; }
        public int age { get; private set; }

        private List<int> marks;
        public Employee(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;

            this.marks = new List<int>();
        }

        public void AddMark(int mark_to_add)
        {
            if (mark_to_add >= 1 && mark_to_add <= 10)
            {
                this.marks.Add(mark_to_add);
            }
        }

        public int Result()
        {
            if (this.marks.Count == 0)
                return 0;

            int sum = 0;

            foreach (var mark in this.marks)
            {
                sum += mark;
            }

            return sum;
        }
    }
}

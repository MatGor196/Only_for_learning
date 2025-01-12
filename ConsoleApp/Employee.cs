namespace ConsoleApp
{
    public class Employee
    {
        public string name { get; private set; }
        public string surname { get; private set; }
        public int age { get; private set; }

        private List<float> marks;
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            this.age = 0;

            this.marks = new List<float>();
        }

        public Employee(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;

            this.marks = new List<float>();
        }

        public void AddMark(float mark_to_add)
        {
            if (mark_to_add >= 1 && mark_to_add <= 10)
            {
                this.marks.Add(mark_to_add);
            }
            else
            {
                Console.WriteLine("Zły zakres");
            }
        }

        public void AddMark(string mark_to_add)
        {
            if (float.TryParse(mark_to_add, out float result))
            {
                this.AddMark(result);
            }
            else
            {
                Console.WriteLine("String nie jest konwertowalny na float");
            }
        }

        public void AddMark(int mark_to_add)
        {
            var result = (float)mark_to_add;
            this.AddMark(result);
        }

        public float Result()
        {
            if (this.marks.Count == 0)
                return 0;

            float sum = 0;

            foreach (var mark in this.marks)
            {
                sum += mark;
            }

            return sum;
        }

        public Statistics GetStatistics()
        {
            Statistics stats = new Statistics();

            stats.min = float.MaxValue;
            stats.max = float.MinValue;
            stats.average = 0;

            foreach (var mark in this.marks)
            {
                stats.average += mark;

                stats.min = Math.Min(stats.min, mark);
                stats.max = Math.Max(stats.max, mark);
            }

            stats.average /= this.marks.Count;

            return stats;
        }

        public Statistics GetStatisticsWithWhile()
        {
            Statistics stats = new Statistics();

            stats.min = float.MaxValue;
            stats.max = float.MinValue;
            stats.average = 0;

            var index = 0;
            while (index < this.marks.Count)
            {
                stats.average += this.marks[index];

                stats.min = Math.Min(stats.min, this.marks[index]);
                stats.max = Math.Max(stats.max, this.marks[index]);
                index++;
            }

            stats.average /= this.marks.Count;

            return stats;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            Statistics stats = new Statistics();

            stats.min = float.MaxValue;
            stats.max = float.MinValue;
            stats.average = 0;

            var index = 0;
            do
            {
                stats.average += this.marks[index];

                stats.min = Math.Min(stats.min, this.marks[index]);
                stats.max = Math.Max(stats.max, this.marks[index]);
                index++;
            }
            while (index < this.marks.Count);

            stats.average /= this.marks.Count;

            return stats;
        }

        public Statistics GetStatisticsWithFor()
        {
            Statistics stats = new Statistics();

            stats.min = float.MaxValue;
            stats.max = float.MinValue;
            stats.average = 0;

            for(var index = 0; index < this.marks.Count; index++)
            {
                stats.average += this.marks[index];

                stats.min = Math.Min(stats.min, this.marks[index]);
                stats.max = Math.Max(stats.max, this.marks[index]);
            }

            stats.average /= this.marks.Count;

            return stats;
        }
    }
}

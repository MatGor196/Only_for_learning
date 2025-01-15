namespace ConsoleApp
{
    public class Employee : Person
    {
        private List<float> marks;
        public Employee()
            : base("-", "-", 0, 'M')
        {
            this.marks = new List<float>();
        }
        public Employee(string name, string surname, int age, char sex)
            : base (name, surname, age, sex)
        {
            this.marks = new List<float>();
        }

        public void AddMark(float mark_to_add)
        {
            if (mark_to_add >= 0 && mark_to_add <= 10)
            {
                this.marks.Add(mark_to_add);
            }
            else
            {
                throw new Exception("Zły zakres");
            }
        }

        public void AddMark(string mark_to_add)
        {
            if (float.TryParse(mark_to_add, out float result))
            {
                this.AddMark((float)result);
            }
            else if (char.TryParse(mark_to_add, out char result_in_char))
            {
                this.AddMark((char)result_in_char);
            }
            else
            {
                throw new Exception("String nie jest konwertowalny na float");
            }
        }

        public void AddMark(int mark_to_add)
        {
            var result = (float)mark_to_add;
            this.AddMark(result);
        }

        public void AddMark(char mark_to_add)
        {
            switch(mark_to_add)
            {
                case 'A':
                case 'a':
                    this.marks.Add(10);
                    break;
                case 'B':
                case 'b':
                    this.marks.Add(8);
                    break;
                case 'C':
                case 'c':
                    this.marks.Add(6);
                    break;
                case 'D':
                case 'd':
                    this.marks.Add(4);
                    break;
                case 'E':
                case 'e':
                    this.marks.Add(2);
                    break;
                case 'F':
                case 'f':
                    this.marks.Add(0);
                    break;
                default:
                    throw new Exception("Wpisano złą ocenę");
            }
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

            switch(stats.average)
            {
                case var average when average >= 8:
                stats.average_letter = 'A';
                    break;
                case var average when average >= 6:
                    stats.average_letter = 'B';
                    break;
                case var average when average >= 4:
                    stats.average_letter = 'C';
                    break;
                case var average when average >= 2:
                    stats.average_letter = 'D';
                    break;
                case var average when average >= 0:
                    stats.average_letter = 'E';
                    break;
            }

            return stats;
        }
    }
}

namespace ConsoleApp
{
    internal class Supervisor : IEmployee
    {
        private List<float> marks;
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public char sex { get; set; }

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

        public void AddMark(int mark_to_add)
        {
            var result = (float)mark_to_add;
            this.AddMark(result);
        }

        public void AddMark(char mark_to_add)
        {
            switch (mark_to_add)
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

        public void AddMark(string mark_to_add)
        {
            switch(mark_to_add)
            {
                case "6":
                    this.marks.Add(10);
                    break;
                case "-6":
                case "6-":
                    this.marks.Add(9);
                    break;
                case "+5":
                case "5+":
                    this.marks.Add(9);
                    break;
                case "5":
                    this.marks.Add(8);
                    break;
                case "-5":
                case "5-":
                    this.marks.Add(7);
                    break;
                case "+4":
                case "4+":
                    this.marks.Add(7);
                    break;
                case "4":
                    this.marks.Add(6);
                    break;
                case "-4":
                case "4-":
                    this.marks.Add(5);
                    break;
                case "+3":
                case "3+":
                    this.marks.Add(5);
                    break;
                case "3":
                    this.marks.Add(4);
                    break;
                case "-3":
                case "3-":
                    this.marks.Add(3);
                    break;
                case "+2":
                case "2+":
                    this.marks.Add(3);
                    break;
                case "2":
                    this.marks.Add(2);
                    break;
                case "-2":
                case "2-":
                    this.marks.Add(1);
                    break;
                case "+1":
                case "1+":
                    this.marks.Add(1);
                    break;
                case "1":
                    this.marks.Add(0);
                    break;
            }
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

            switch (stats.average)
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
    }
}

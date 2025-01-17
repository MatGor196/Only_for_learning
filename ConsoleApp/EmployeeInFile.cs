
namespace ConsoleApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string marks_file = "marks.txt";
        public EmployeeInFile(string name, string surname, int age, char sex)
            : base(name, surname, age, sex)
        {
        }

        private void WriteMark(float mark_to_add)
        {
            using (var writer = File.AppendText(marks_file))
            {
                writer.WriteLine(mark_to_add);
            }
        }

        private List<float> ReadMarksFromFile()
        {
            var marks = new List<float>();

            if (File.Exists(marks_file))
            {
                using (var reader = File.OpenText(marks_file))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        marks.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }

            return marks;
        }

        public override void AddMark(float mark_to_add)
        {
            if (mark_to_add >= 0 && mark_to_add <= 10)
            {
                WriteMark(mark_to_add);
            }
            else
            {
                throw new Exception("Zły zakres");
            }
        }

        public override void AddMark(int mark_to_add)
        {
            var result = (float)mark_to_add;
            this.AddMark(result);
        }

        public override void AddMark(char mark_to_add)
        {
            switch (mark_to_add)
            {
                case 'A':
                case 'a':
                    WriteMark(10);
                    break;
                case 'B':
                case 'b':
                    WriteMark(8);
                    break;
                case 'C':
                case 'c':
                    WriteMark(6);
                    break;
                case 'D':
                case 'd':
                    WriteMark(4);
                    break;
                case 'E':
                case 'e':
                    WriteMark(2);
                    break;
                case 'F':
                case 'f':
                    WriteMark(0);
                    break;
                default:
                    throw new Exception("Wpisano złą ocenę");
            }
        }

        public override void AddMark(string mark_to_add)
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

        public override Statistics GetStatistics()
        {
            var stats = new Statistics();

            var marks = ReadMarksFromFile();

            if (marks.Count != 0)
            {
                stats.min = float.MaxValue;
                stats.max = float.MinValue;
                stats.average = 0;

                foreach (var mark in marks)
                {
                    stats.average += mark;

                    stats.min = Math.Min(stats.min, mark);
                    stats.max = Math.Max(stats.max, mark);
                }

                stats.average /= marks.Count;

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
            }

            return stats;
        }

        public override float Result()
        {
            var marks = ReadMarksFromFile();

            if (marks.Count == 0)
                return 0;

            float sum = 0;

            foreach (var mark in marks)
            {
                sum += mark;
            }

            return sum;
        }
    }
}

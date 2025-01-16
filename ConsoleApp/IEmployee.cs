namespace ConsoleApp
{
    public interface IEmployee
    {
        string name { get; set; }
        string surname { get; set; }
        int age { get; set; }
        char sex { get; set; }

        void AddMark(float mark_to_add);
        void AddMark(int mark_to_add);
        void AddMark(char mark_to_add);
        void AddMark(string mark_to_add);
        float Result();
        Statistics GetStatistics();
    }
}

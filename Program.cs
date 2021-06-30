using static System.Console;

namespace Student_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Manage bd = new Manage();
            // Initialize five pieces of data
            bd.Initial();
            ReadKey();
        }
    }
}

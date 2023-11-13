namespace moodleOppgave01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei, hva heter du?:");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hallaien {userName}!");
            Console.ReadKey();
        }
    }
}
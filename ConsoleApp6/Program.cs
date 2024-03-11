namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Backpack p = new Backpack(5, 7953);
            Console.WriteLine(p.ToString());

            Console.WriteLine(p.Solve(10).ToString());
        }
    }
}
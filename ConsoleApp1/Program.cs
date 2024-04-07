namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 2;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            
            int temp = a;
            a = b;
            b = temp;
           
            Console.WriteLine("PERMUTATION");
            Console.WriteLine("b = " + b);
            Console.WriteLine("a = " + a);

            Console.ReadKey();
        }
    }
}

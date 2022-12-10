namespace ConsoleApp1
{
    using Lib;
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            bool result = a == 2;
            if (result)
            {

            }
            Console.WriteLine("Hello, World!" + Lib.MyClass.Data);
        }
    }
}
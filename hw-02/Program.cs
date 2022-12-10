namespace hw_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            var number = long.Parse(Console.ReadLine());
            //sbyte
            if (number > sbyte.MinValue & number < sbyte.MaxValue)
            {
                var t = (T)E;
            }
            else
                Console.WriteLine("Для приведения числа к типу число не может быть больше и меньше");

            */
            // *** SIZEOF
            int size = sizeof(sbyte);
            Console.WriteLine("Size = " + size);

            // *** TYPEOF
            var type = typeof(bool);
            Console.WriteLine("Type = " + type);

            // *** SBYTE
            sbyte mySbyte = 120;
            Console.WriteLine("MySByte = " + mySbyte + "; Size = " + sizeof(sbyte));
            Console.WriteLine(int.MinValue);
            Console.WriteLine(mySbyte.GetType());


        }
    }
}
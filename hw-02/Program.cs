namespace hw_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            long number = long.Parse(Console.ReadLine());
                        
            //sbyte
            string SB = "sbyte";
            if (number >= sbyte.MinValue & number <= sbyte.MaxValue)
            {
                var t = (sbyte)number;
                Console.WriteLine("Число {0} явно преобразуется в тип {1}", t, SB);
            }
            else
            {   
            Console.WriteLine("Для приведения числа {0} к типу {1} число не может быть больше {2} и меньше {3}", number, SB, sbyte.MaxValue, sbyte.MinValue);
            }

            //byte
            string B = "byte";
            if (number >= byte.MinValue & number <= byte.MaxValue)
            {
                var t = (byte)number;
                Console.WriteLine("Число {0} явно преобразуется в тип {1}", t, B);
            }
            else
            {   
            Console.WriteLine("Для приведения числа {0} к типу {1} число не может быть больше {2} и меньше {3}", number, B, byte.MaxValue, byte.MinValue);
            }

            //short
            string SH = "short";
            if (number >= short.MinValue & number <= short.MaxValue)
            {
                var t = (short)number;
                Console.WriteLine("Число {0} явно преобразуется в тип {1}", t, SH);
            }
            else
            {   
            Console.WriteLine("Для приведения числа {0} к типу {1} число не может быть больше {2} и меньше {3}", number, SH, short.MaxValue, short.MinValue);
            }

            //ushort
            string USH = "ushort";
            if (number >= ushort.MinValue & number <= ushort.MaxValue)
            {
                var t = (ushort)number;
                Console.WriteLine("Число {0} явно преобразуется в тип {1}", t, USH);
            }
            else
            {   
            Console.WriteLine("Для приведения числа {0} к типу {1} число не может быть больше {2} и меньше {3}", number, USH, ushort.MaxValue, ushort.MinValue);
            }
            
            //int
            string I = "int";
            if (number >= int.MinValue & number <= int.MaxValue)
            {
                var t = (int)number;
                Console.WriteLine("Число {0} явно преобразуется в тип {1}", t, I);
            }
            else
            {   
            Console.WriteLine("Для приведения числа {0} к типу {1} число не может быть больше {2} и меньше {3}", number, I, int.MaxValue, int.MinValue);
            }

            //uint
            string UI = "uint";
            if (number >= uint.MinValue & number <= uint.MaxValue)
            {
                var t = (uint)number;
                Console.WriteLine("Число {0} явно преобразуется в тип {1}", t, UI);
            }
            else
            {   
            Console.WriteLine("Для приведения числа {0} к типу {1} число не может быть больше {2} и меньше {3}", number, UI, uint.MaxValue, uint.MinValue);
            }

            //ulong
            string UL = "ulong";
            var ulongmax = Math.Pow(2, 64)-1;
            if (number >= 0 & number <= ulongmax)
            {
                var t = (ulong)number;
                Console.WriteLine("Число {0} явно преобразуется в тип {1}", t, UL);
            }
            else
            {   
            Console.WriteLine("Для приведения числа {0} к типу {1} число не может быть больше {2} и меньше {3}", number, UL, ulong.MaxValue, ulong.MinValue);
            }
            Console.WriteLine("\nДля выхода нажмите любую клавишу:");
            Console.ReadKey();
            
           


        }
    }
}
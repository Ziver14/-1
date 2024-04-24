namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a;
            int b;
            
            /*a = Convert.ToInt32(Console.ReadLine());
            if (a % 3 == 0)
            {
                Console.Write("Fizz");
            }
            if (a % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(a);
            }*/

            /*Console.WriteLine("Введите число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите процент");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((a*b)/100);*/

            /*Console.WriteLine("Введите четыре цифры");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a * 1000 + b * 100 + c * 10 + d);*/

            Console.WriteLine("Введите диапазон");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                int c = a;
                a = b;
                b = c;

            }

            for (int i =a; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
            
    }
}

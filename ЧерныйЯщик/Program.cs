using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЧерныйЯщик
{
    class Program
    {
        public static int[] vecA(int n)
        {
            int check = 1;
            int[] mass = new int[n];
            while (check == 1)
            {
                try
                {
                    Console.WriteLine("mass-");
                    for (int i = 0; i < n; i++)
                    {
                        mass[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    break;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return mass;
        }

        public static void poisk(int[] m, int n, int a, int b)
        {
            int s=0, s1=0;
            for (int i = 0; i < n; i++)
            {
                if (m[i] < a)
                {
                    s = s + 1;
                    Console.Write("Индексы элементов меньших А " + i +", ");
                }
                Console.Write(" ");
            }
            Console.WriteLine("\nКоличество элементов меньших А " + s);
            for (int i = 0; i < n; i++)
            {
                if (m[i] > b)
                {
                    s1 = s1 + 1;
                    Console.Write("Индексы элементов больших В" + i + ", ");
                }
                Console.Write("");
            }
            Console.WriteLine("\nКоличество элементов больших В " + s1);
        }
        static void Main(string[] args)
        {
            int check = 1,ch=1,z;
            while (ch == 1)
            {
                Console.WriteLine("Количество элементов -");
                try
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n < 0)
                    {
                        Console.WriteLine("Резмерность должна быть положительной!!!");
                    }
                    else
                    {
                        int[] v = vecA(n);
                        while (check == 1)
                        {
                            Console.WriteLine("Введите A-");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите B-");
                            int b = Convert.ToInt32(Console.ReadLine());
                            if (a < b)
                            {
                                poisk(v, n, a, b);
                                check = 0;
                            }
                            else
                            {
                                Console.WriteLine("Повторите попытку");
                            }
                        }
                        Console.WriteLine("Продолжить работу ?");
                        z = Convert.ToInt32(Console.ReadLine());
                        if (z == 0)
                        {
                            break;
                        }
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("Спасибо за внимание!");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateLibary;

namespace Calculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DllFile calculator = new DllFile();
            int ex = 10;
            while (ex != 0)
            {
                Console.WriteLine("Выберите операцию:\n1. Сложение a + b\n2. Вычитание a - b\n3. Умножение a * b\n4. Деление a / b\n5. Логарифм log(b) a\n6. Синус sin(a)\n0. Выход");
                ex = Convert.ToInt32(Console.ReadLine());
                if (ex < 6 && ex != 0)
                {
                    Console.WriteLine("Введите значие a");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите значие b");
                    int b = Convert.ToInt32(Console.ReadLine());
                    switch (ex)
                    {
                        case 1:
                            Console.WriteLine("Сложение: \n" + calculator.Sum(a, b));
                            break;
                        case 2:
                            Console.WriteLine("Вычитание: \n" + calculator.Sub(a, b));
                            break;
                        case 3:
                            Console.WriteLine("Умножение: \n" + calculator.Mult(a, b));
                            break;
                        case 4:
                            try
                            {
                                Console.WriteLine("Деление: \n" + calculator.Div(a, b));
                                break;
                            }
                            catch (DivideByZeroException)
                            {
                                Console.WriteLine("Деление на ноль!!!\n");
                                break;
                            }
                        case 5:
                            Console.WriteLine("Log: \n" + calculator.Log(a, b));
                            break;
                    }

                }
                else if (ex == 6)
                {
                    Console.WriteLine("Введите значие a");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Sin: \n" + calculator.Sin(a));
                }
                else if (ex == 0)
                {
                    Console.WriteLine("Завершаю работу :)\nBYE BYE!");
                    return;
                }
                else
                {
                    Console.WriteLine("Невернный ввод!");
                }
            }
        }
    }
}

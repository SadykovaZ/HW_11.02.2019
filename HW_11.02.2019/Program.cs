using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11._02._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания: ");
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("2.	Ввести с клавиатуры номер трамвайного билета (6-значное число) и проверить является ли данный билет счастливым (если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым). ");
                int[] arr = new int[6];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if ((arr[0] + arr[1] + arr[2]) == (arr[3] + arr[4] + arr[5]))
                    {
                        Console.WriteLine("Счастливый билет");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Несчастливый билет");
                        break;
                    }
                }
            }
            else if (number == 2)
            {
                Console.WriteLine("5.	Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево. Например, если было введено число 345, то программа должна вывести число 543");

                int[] arr = new int[3];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                arr = (from a in arr orderby a descending select a).ToArray();
                foreach (int value in arr)
                {
                    Console.WriteLine(value);
                }

            }
            else if (number == 3)
            {
                Console.WriteLine("Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность");
                int V1 = 0;
                int M1 = 0;
                int V2 = 0;
                int M2 = 0;
                Console.WriteLine("Введите обьем первого тела: ");
                V1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите массу первого тела: ");
                M1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите обьем второго тела: ");
                V2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите массу второго тела: ");
                M2 = int.Parse(Console.ReadLine());

                double res1 = (double)M1 / V1;
                double res2 = (double)M2 / V2;
                Console.WriteLine("Результаты: ");
                Console.WriteLine("Плотность первого тела: {0}", res1);
                Console.WriteLine("Плотность второго тела: {0}", res2);

                if (res1 > res2)
                {

                    Console.WriteLine("Первое тело имеет большую плотность");
                }
                else
                {
                    Console.WriteLine("Второе тело имеет большую плотность");

                }




            }
            else if (number == 4)
            {
                Console.WriteLine("Известны сопротивления двух несоединенных друг с другом участков электрической цепи и напряжение на каждом из них. По какому участку протекает меньший ток?");
                int R1 = 0;
                int U1 = 0;
                int R2 = 0;
                int U2 = 0;
                Console.WriteLine("Введите сопротивление первого участка: ");
                R1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите напряжение второго участка: ");
                U1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите сопротивление первого участка: ");
                R2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите напряжение второго участка: ");
                U2 = int.Parse(Console.ReadLine());

                double res1 = (double)U1 / R1;
                double res2 = (double)U2 / R2;
                Console.WriteLine("Результаты: ");
                Console.WriteLine("Ток первого участка: {0}", res1);
                Console.WriteLine("Ток второго участка: {0}", res2);

                if (res1 < res2)
                {

                    Console.WriteLine("Первый участок имеет меньший ток ");
                }
                else
                {
                    Console.WriteLine("Второй участок имеет меньший ток ");

                }

            }
            else if (number == 5)
            {
                Console.WriteLine("Дана сторона квадрата. Найти его периметр");
                int a = 0;

                a = int.Parse(Console.ReadLine());
                int res = a * 4;

                Console.WriteLine("Result: {0}", res);
            }
            else if (number == 6)
            {
                Console.WriteLine("Считая, что Земля — идеальная сфера с радиусом R 6350 км, определить расстояние до линии горизонта от точки с заданной высотой над Землей.");
                int R = 6350;
                int h = 0;
                double d = 0;
                Console.WriteLine("Введите высоту: ");
                h = int.Parse(Console.ReadLine());

                d = Math.Sqrt(h * ((2 * R) + h));

                Console.WriteLine("Расстояние до линии горизонта: {0} ", d);

            }
            else if (number == 7)
            {
                Console.WriteLine("23.	Известны объем и масса тела. Определить плотность материала этого тела");
                int V = 0;
                int M = 0;

                Console.WriteLine("Введите обьем тела: ");
                V = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите массу тела: ");
                M = int.Parse(Console.ReadLine());

                double res = (double)M / V;
                Console.WriteLine("Плотность материала: {0}", res);
            }

            else if (number == 8)
            {
                Console.WriteLine("31.	Известны два расстояния: одно в километрах, другое — в футах ( 1 фут 0,305 м ). Какое из расстояний меньше?");
                double km = 0;
                double ft = 0;
                Console.WriteLine("Введите первое расстояние в км: ");
                km = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе расстояние футах: ");
                ft = int.Parse(Console.ReadLine());

                double kmInft = km * 3280.84;

                if (ft < kmInft)
                {
                    Console.WriteLine("Второе расстояние меньше");
                }
                else
                {
                    Console.WriteLine("Первое расстояние меньше");

                }

            }

            else if (number==9)
            {
                Console.WriteLine("39.	Напечатать ряд чисел 20 в виде: 20 20 20 20 20 20 20 20 20 20");

                int[] arr = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    arr[i] = 20;
                    Console.Write(arr[i]);
                    Console.Write(" ");
                }


            }

            else if (number==10)
            {
                Console.WriteLine("42.Напечатать таблицу умножения на 9: 9 х 1 = 9 9 х 2 = 18... 9 х 9 = 81");

                int a = 9;
                int[] arr=new int[10];

                for (int i = 1; i <= 9; i++)
                {
                    Console.WriteLine("9 * {0} = {1}", i, a*i);
                }                
            }


        }
    }
}

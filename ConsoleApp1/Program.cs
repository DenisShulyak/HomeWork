using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1)");
            Random rand = new Random();
            int a, b, c;
            a = rand.Next(0, 100);
            b = rand.Next(0, 100);
            c = rand.Next(0, 100);

            Console.WriteLine(a + " " + b + " " + c);
            Console.WriteLine("2)");
            Console.WriteLine(5);
            Console.WriteLine(10);
            Console.WriteLine(21);

            Console.WriteLine("3)");
            Console.WriteLine("Введите расстояние в сантиметрах: ");
            int numberSM = int.Parse(Console.ReadLine());
            int OneMetrInSm = 100;
            int numberM = numberSM / OneMetrInSm;
            Console.WriteLine("Расстояние в метрах: " + numberM);

            Console.WriteLine("4)");
            int quantityDays = 234;
            int quantityDaysInWeek = 7;
            int quantityFullWeek = quantityDays / quantityDaysInWeek;
            Console.WriteLine("Количество полных недель за данный период: " + quantityFullWeek);
            Console.WriteLine("5)");
            Console.WriteLine("Введите двухзначное число: ");
            int number = int.Parse(Console.ReadLine());
            int ForFindTensOrUnits = 10;

            int tens = number / ForFindTensOrUnits;
            int units = number % ForFindTensOrUnits;
            int sum = tens + units;
            int composition = tens * units;
            Console.WriteLine("Число десятков: " + tens);
            Console.WriteLine("Число едениц: " + units);
            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine("Произведение: " + composition);

            Console.WriteLine("6)");
            bool A = true;
            bool B = false;
            bool C = false;
            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);
            Console.WriteLine("C = " + C);

            bool D;
            D = A | B;
            Console.WriteLine("A или B = " + D);
            D = A & B;
            Console.WriteLine("A и B = " + D);
            D = B | C;
            Console.WriteLine("B или С = " + D);
            Console.WriteLine("7)");
            Console.WriteLine("Введите радиус круга: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону квадрата: ");
            double side = double.Parse(Console.ReadLine());
            double S1, S2;
            S1 = Math.PI * Math.Pow(radius, 2);
            S2 = Math.Pow(side, 2);
            if (S1 > S2)
            {
                Console.WriteLine("Площадь квадрата меньше чем площадь круга");
            }
            else if (S1 < S2)
            {
                Console.WriteLine("Площадь квадрата больше чем площадь круга");
            }
            else
            {
                Console.WriteLine("Площади равны");
            }
            Console.WriteLine("8)");
            Console.WriteLine("Введите массу первого тела(кг): ");
            double m1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите массу второго тела(кг): ");
            double m2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите объем первого тела(м^3): ");
            double V1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите объем второго тела(м^3): ");
            double V2 = double.Parse(Console.ReadLine());
            double p1 = m1 / V1;
            double p2 = m2 / V2;
            if (p1 > p2)
            {
                Console.WriteLine("Плотность первого тела больше плотности второго");
            }
            else if (p1 < p2)
            {
                Console.WriteLine("Плотность первого тела меньше плотности второго");
            }
            else
            {
                Console.WriteLine("Плотности равны");
            }
            Console.WriteLine("9)");
            Console.WriteLine("Введите сопротивление первой цепи: ");
            double R1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сопротивление второй цепи: ");
            double R2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите напряжение первой цепи: ");
            double U1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите напряжение второй цепи: ");
            double U2 = double.Parse(Console.ReadLine());
            double I1 = U1 / R1;
            double I2 = U2 / R2;
            if (I1 > I2)
            {
                Console.WriteLine("Во второй цепи протикает меньший ток");
            }
            else if (I1 < I2)
            {
                Console.WriteLine("В первой цепи протикает меньший ток");
            }
            else
            {
                Console.WriteLine("Силы тока в обоих цепях равны");
            }
            Console.WriteLine("10)");
            Console.WriteLine("a)");
            Console.WriteLine("Числа от 20 до 35: ");
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("b)");
            Console.WriteLine("Введите число b(b > 10): ");
            int numberB = int.Parse(Console.ReadLine());
            if(numberB <= 10)
            {
                Console.WriteLine("b <= 10 !!!");
            }
            else
            {
                Console.WriteLine("Квадраты чисел в диапозоне от 10 до b: ");

                for (int i = 10; i <= numberB;i++)
                {
                    Console.WriteLine(Math.Pow(i, 2));
                }
            }
            Console.WriteLine("c)");
            Console.WriteLine("Введите число a(a < 50): ");
            int numberA = int.Parse(Console.ReadLine());
            if (numberA >= 50)
            {
                Console.WriteLine("a >= 50 !!!");
            }
            else
            {
                Console.WriteLine("Кубы чисел в диапозоне от а до 50: ");
                for (int i = numberA; i <= 50; i++)
                {
                    Console.WriteLine(Math.Pow(i, 3));
                }
            }
            Console.WriteLine("c)");
            Console.WriteLine("Введите число a: ");
            int numberA2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число B: ");
            int numberB2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Числа от а до b: ");
            for (int i = numberA2; i <= numberB2; i++)
                {
                    Console.WriteLine(i);
                }
            
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
# HomeWork-PracticWork
# HomeWork-PracticWork

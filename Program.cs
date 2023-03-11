using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_11_ex._9
{
    internal class Program
    {
        static double GetDouble(String str)
        {

            while (true)
            {
                Console.Write(str);
                if (Double.TryParse(Console.ReadLine(), out double num))
                {
                    return num;
                }
            }
        }
        static void allend()
        {
            Console.Write("Нажмити любую кнопку чтобы продолжить ...");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            //Инициализация 2 точек
            Point A = new Point();
            Point B = new Point();

            //Заполнение Точек
            Console.WriteLine("Введите начальные координаты точки A:");
            A.x = GetDouble("X:");
            A.y = GetDouble("Y:");
            Console.Clear();
            Console.WriteLine("Введите начальные координаты точки B:");
            B.x = GetDouble("X:");
            B.y = GetDouble("Y:");

            //Расчёт растояния между точками
            Console.WriteLine($"Координаты точки A: {A.toString()} Координаты точки B: {B.toString()}");
            Console.WriteLine($"Растояние между точками \"{A.x};{A.y}\" и \"{B.x};{B.y}\" = {string.Format("{0:f2}", A.length(B))}");
            allend();
        start:
            Console.Clear();
            int chois = -1;
            while (((chois < 0) || (chois > 3)))
            {
                Console.WriteLine("Какое задание вы хотите выполнить:\n1) Унарные операции (++ || --)\n2) Приведения типа\n3) Бинарные операции\n0) Заверить работу;");
                chois = (int)GetDouble("Я вибераю: ");
            }
            switch (chois)
            {
                case 0:
                    return;
                case 1:
                    Console.WriteLine($"Координаты точки A до изменений (A++): {A.toString()}");
                    A++;
                    Console.WriteLine($"Координаты точки A после изменений (A++): {A.toString()}");
                    allend();
                    Console.Clear();
                    Console.WriteLine($"Координаты точки A до изменений (A--): {A.toString()}");
                    A--;
                    Console.WriteLine($"Координаты точки A после изменений (A--): {A.toString()}");
                    allend();
                    break; 
                case 2:
                    Console.WriteLine($"Координаты точки A: {A.toString()}");
                    Console.WriteLine($"Преобразование точки A int(явная) – результатом является целая часть координаты х: {(int)A}");
                    Console.WriteLine($"Преобразование точки A double (неявная) – результатом является координата y: {(double)A}");
                    allend();
                    break;
                case 3:
                    Console.WriteLine($"Координаты точки A: {A.toString()} Координаты точки B: {B.toString()}");
                    Console.WriteLine($"А + B = Растояние = {string.Format("{0:f2}", A + B)}\nA + 4 = A.X + 4 = {(A + 4).toString()}\n4 + A = 4 + A.X = {(4 + A).toString()}");
                    Console.WriteLine($"A - 4 = A.X - 4 = {(A - 4).toString()}\n4 - A = 4 - A.X = {(4 - A).toString()}");
                    allend();
                    break;

            }
            goto start;
        }
    }
}

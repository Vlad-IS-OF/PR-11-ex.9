using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            while (((chois < 0) || (chois > 4)))
            {
                Console.WriteLine("Какое задание вы хотите выполнить:\n1) Унарные операции (++ || --)\n2) Приведения типа\n3) Бинарные операции\n4) Перейти к заданию 2\n0) Заверить работу;");
                chois = (int)GetDouble("Я вибераю: ");
            }
            switch (chois)
            {
                case 0:
                    PointArray arr = new PointArray(2);
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
                case 4:
                    goto task2_1;

            }
            goto start;

            task2_1:
            Console.Clear();
            chois = -1;
            while (((chois < 0) || (chois > 3)))
            {
                Console.WriteLine("Какое задание вы хотите выполнить:" +
                    "\n1) Создать массив эл. без параметров" +
                    "\n2) Создать массив эл. Случайным количеством" +
                    "\n3) Создать массив эл. в ручном режиме" +
                    "\n0) Заверить работу;");
                chois = (int)GetDouble("Я вибераю: ");
            }
            PointArray Arr = null;
            switch (chois)
            {
                case 0:
                    return;
                case 1:
                    Arr = new PointArray();
                    break;
                case 2:
                    chois = (int)GetDouble("Введите количество элементов (Введите 0 чтобы выбрать заного): ");
                    if (chois == 0) goto task2_1;

                    Arr = new PointArray(chois);
                    break;
                case 3:
                    chois = (int)GetDouble("Введите количество элементов (Введите 0 чтобы выбрать заного): ");
                    if (chois == 0) goto task2_1;

                    Point[] pArr = new Point[chois];
                    for(int i = 0; i < pArr.Length;i++)
                    {
                        Console.Clear();
                        pArr[i] = new Point();
                        Console.WriteLine($"Введите начальные координаты точки {i}:");
                        pArr[i].x = GetDouble("X:");
                        pArr[i].y = GetDouble("Y:");
                    }
                    Arr = new PointArray(pArr);
                    break;
            }

            Console.Clear();
            Arr.Show();
            chois = -1;
            while (((chois < 0) || (chois > 2)))
            {
                Console.WriteLine("Продолжить работу с созданным массивом или повторить создание?" +
                    "\n1) Продолжить" +
                    "\n2) Заново" +
                    "\n0) Заверить работу;");
                chois = (int)GetDouble("Я вибераю: ");
            }
            switch (chois)
            {
                case 0:
                    return;
                case 1:
                    break;
                case 2:
                    goto task2_1;
            }
        task2_2:
            Console.Clear();
            chois = -1;
            while (((chois < 0) || (chois > 5)))
            {
                Console.WriteLine("Какое задание вы хотите выполнить:" +
                    "\n1) Получить информацию о эл. по индексу" +
                    "\n2) Просмотр всего массива" +
                    "\n3) Найти самую удалённую точку от центра" +
                    "\n4) Повторить создание массива из эл." +
                    "\n5)Перейти к первому заданию" +
                    "\n0) Заверить работу;");
                chois = (int)GetDouble("Я вибераю: ");
            }
            switch (chois)
            {
                case 0:
                    return;
                case 1:
                    chois = (int)GetDouble("Введите индекс элемента: ");
                    Arr.Finde(chois);
                    allend();
                    goto task2_2;
                case 2:
                    Console.Clear();
                    Arr.Show();
                    allend();
                    goto task2_2;
                case 3:
                    Arr.ShowLenth();
                    Console.WriteLine($"Самая удалённая точка расположена на координатах: {Arr.Remote().toString()}");
                    allend();
                    goto task2_2;
                case 4:
                    goto task2_1;
                case 5:
                    goto start;

            }
        }
    }
}


/*
 * В классе реализовать 
 * конструктор без параметров,
 * конструктор с параметрами, заполняющий элементы случайными значениями, 
 * конструктор с параметрами, позволяющий заполнить массив элементами, заданными пользователем с клавиатуры,
 * индексатор (для доступа к элементам массива),
 * метод для просмотра элементов массива.
 * Самую удаленную от центра координат точку.
*/
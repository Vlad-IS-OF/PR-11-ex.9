using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PR_11_ex._9
{
    public class Point
    {
        /*Унарные операции:
        ++  увеличить координаты x на 1,
        -- уменьшение координаты х на 1.

        Операции приведения типа:
        int (явная) – результатом является целая часть координаты х;
        double (неявная) – результатом является координата y.

        Бинарные операции:
        +  Point p – вычисляется расстояние до точки p. Результатом должно быть вещественное число. 
        + целое число (лево- и право- сторонние операции). Увеличивается координата х, результатом является объект типа Point*/
        //Параметры
        public double x;
        public double y;
        
        //Конструктор
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        public Point(Point p)
        {
            this.x = p.x;  
            this.y = p.y;
        }
        
        //Деструктор (Лучше не использовать)
        /*~Point()
        {
            Console.WriteLine($"Point [{this.x};{this.y}] has deleted");
        }*/

        //Функции
        public double length(Point tochka2)
        {
            return Math.Sqrt(Math.Pow((tochka2.x - this.x), 2) + Math.Pow((tochka2.y - this.y), 2));
        }
        public double length(double x, double y)
        {
            return Math.Sqrt(Math.Pow((x-this.x),2) + Math.Pow((y-this.y),2));
        }
        public void Show()
        {
            Console.WriteLine($"X:{this.x}; Y:{this.y};");
        }
        public string toString()
        {
            return $"X:{this.x}; Y:{this.y};";
        }
        //Перегрузка
        /*
         *      Унарные операции:
         * ++  увеличить координаты x на 1,+
         * -- уменьшение координаты х на 1
         */
        public static Point operator ++(Point p) { 
            p.x++;
            return p;
        }
        public static Point operator --(Point p) { 
            p.x--;
            return p;
        }
        /*
         * Операции приведения типа:
         * int (явная) – результатом является целая часть координаты х;
         * double (неявная) – результатом является координата y.
         */
        public static implicit operator double(Point p) {return p.y;}
        public static explicit operator int(Point p) {return (int)p.x;}

        /*
         * Бинарные операции:
         * +  Point p – вычисляется расстояние до точки p. Результатом должно быть вещественное число
         * + целое число (лево- и право- сторонние операции). Увеличивается координата х, результатом является объект типа Point
         */
        public static double operator +(Point p1, Point p2) { 
            return p1.length(p2);
        }
        public static Point operator +(Point p,double x)
        {
            p.x += x;
            return p;
        }
        public static Point operator +(double x, Point p)
        {
            p.x += x;
            return p;
        }
        public static Point operator -(Point p, double x)
        {
            p.x -= x;
            return p;
        }
        public static Point operator -(double x, Point p)
        {
            p.x -= x;
            return p;
        }


    }
}

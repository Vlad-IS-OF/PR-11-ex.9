using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_11_ex._9
{
    public class PointArray
    {
        Point[] arr = null;
        int size;
        static Random rnd = new Random();

        public int Length
        {
            get { return arr.Length; }
        }
        public PointArray(int size)
        {
            arr = new Point[size];
            for (int i = 0; i < size; i++)
            {
                Point A = new Point(Math.Round(rnd.NextDouble() * 10, 2), Math.Round(rnd.NextDouble() * 10, 2));
                arr[i] = A;
            }
        }
        public PointArray()
        {
            arr = new Point[rnd.Next(5,15)];
            for (int i = 0; i < size; i++)
            {
                Point A = new Point(Math.Round(rnd.NextDouble() * 10, 2), Math.Round(rnd.NextDouble() * 10,2));
                arr[i] = A;
            }
        }
        public PointArray(params Point[] list)
        {
            arr = new Point[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                arr[i] = list[i];
            }
        }

        public void Show()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write((i+1) + ": ");
                arr[i].Show();
            }
        }
        public void ShowLenth()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write((i + 1) + $" [{Math.Round(arr[i].length(0,0),2)}]: ");
                arr[i].Show();
            }
        }

        public void Finde(int i) 
        {
            Console.WriteLine($"Элемент под индексом [{i}]: {arr[i].toString()}");
        }

        public Point Remote()
        {
            Point Zero= new Point();
            Point remote = new Point(arr[0].x, arr[0].y);
            for (int i = 1; i < arr.Length; i++)
            {
                if (Zero + arr[i] > Zero + remote) remote = arr[i];
            }
            return remote;
        }
    }
}

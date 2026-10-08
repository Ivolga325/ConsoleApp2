using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    internal class Program
    {
        public static void Main()
        {
            Rectangle rec = new Rectangle();
            rec.Height = 2;
            rec.Width = 3;
            rec.Show();
            float p = rec.Perimetr();
            Console.WriteLine($"Ответ: периметр = {p}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }

    internal class Rectangle
    {
        public float Height;
        public float Width;
        public void Show()
        {
            Console.WriteLine($"Прямоугольник: высота = {Height}, ширина = {Width}");
        }
        public float Perimetr()
        {
            float p =2 * Height + 2 * Width;
            return p;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Program
    {
        /*Разработать статистический класс для работы с окружностью. Класс должен содержать 3 метода:
         * 1) определяющий длину окружности по заданному радиусу;
         * 2) определяющий площадь круга по заданному радиусу;
         * 3) проверяющий принадлежность точки с координатами x,y кругу с радиусом r и координатами центра x0,y0.*/
        static void Main(string[] args)
        {            
            try
            {                                
                Console.Write("Введите радиус окружности R = ");
                double r = Convert.ToDouble(Console.ReadLine());
                if (r > 0)
                {
                    Console.Write("Введите координату центра круга х0 = ");
                    double x0 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите координату центра круга y0 = ");
                    double y0 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите координату точки х = ");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите координату точки y = ");
                    double y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Длина окружности = {0}", Circle.CalcLength(r));
                    Console.WriteLine("Площадь окружности = {0}", Circle.CalcSquare(r));
                    Circle.Affiliation(r, x0, y0, x, y);
                }
                else
                {
                    Console.WriteLine("Радиус не может быть меньше либо равен 0");
                }                               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Для завершения нажмите любую клавишу");
                Console.ReadKey();
            }
        }
    }
    public static class Circle
    {
        public static double CalcLength(double r)   // вычисление длины окружности
        {
            double length = Math.Round((2 * Math.PI * r), 2);
            return length;
        }
        public static double CalcSquare(double r)   // вычисление площади круга
        {
            double square = Math.Round((Math.PI * Math.Pow(r, 2)), 2);
            return square;
        }
        public static bool Affiliation(double r, double x0, double y0, double x, double y)      // проверка принадлежности точки кругу
        {
            bool check;
            if (Math.Pow((x - x0), 2) + (Math.Pow((y - y0), 2)) <= Math.Pow(r, 2))
            {
                Console.WriteLine("Точка находится внутри круга");
                check = true;
                return check;
            }
            else
            {
                Console.WriteLine("Точка находится за пределами круга");
                check = false;
                return check;
            }
        }
    }
}

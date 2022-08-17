using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15_home_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression();
            Console.WriteLine("Введите стартовое значение");
            int current = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг");
            int s = Convert.ToInt32(Console.ReadLine());
            arithProgression.setStart(current);
            arithProgression.setStep(s);
            Console.WriteLine("Арифметическая прогрессия: ");
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            arithProgression.reset();
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());

            GeomProgression geomProgression = new GeomProgression();
            geomProgression.setStart(current);
            geomProgression.setStep(s);
            Console.WriteLine("Геометрическая прогрессия: ");
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            geomProgression.reset();
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.ReadKey();
        }
    }
}

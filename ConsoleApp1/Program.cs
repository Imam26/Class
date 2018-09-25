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
            Auto[] auto = 
            {
                new Auto("Ауди", "А6", "седан", 240, 3.0f, new DateTime(2018, 12, 12)),
                new Auto("Фольксваген", "Пассат", "седан", 240, 2.2f, new DateTime(2018, 12, 12)),
                new Auto("Форд", "Фиеста", "хэчбэк", 200, 1.8f, new DateTime(2015, 12, 12)),
                new Auto("Aуди", "А8", "седан", 240, 3.0f, new DateTime(2015, 12, 12)),
                new Auto("Киа", "Оптима", "седан", 240, 2.0f, new DateTime(2015, 12, 12)),
            };

            auto[2].Show();

            auto[2].Clone(auto[3]);
            Console.WriteLine("-------------------");
            auto[3].Show();

            string model, mark;
            model = mark = "";
            int maxSpeed = 0;

            auto[4].ReadFromAuto(ref mark, ref model, ref maxSpeed);
            Console.WriteLine("-------------------");
            Console.WriteLine("mark = {0}", mark);
            Console.WriteLine("model = {0}", model);
            Console.WriteLine("maxSpeed = {0}", maxSpeed);

            Console.WriteLine("-------------------");
            auto[4].WriteToAuto(auto[1]);
            auto[4].Show();
        }      
    }
}

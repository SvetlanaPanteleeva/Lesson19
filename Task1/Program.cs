using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Сomputer> computer = new List<Сomputer>()
            {
                new Сomputer() {Code=1, Name="DELL Precision T3640 MT", Type="Intel Core", Frequency=2900, Volume=16, Capacity=1000, Memory=512, Price=90000, Number=30},
                new Сomputer() {Code=2, Name="HP ProDesk 400 G7 MT", Type="Intel Core", Frequency=3600, Volume=8, Capacity=512, Memory=512, Price=76000, Number=10},
                new Сomputer() {Code=3, Name="Lenovo IdeaCentre 3 07ADA05", Type="AMD Ryzen", Frequency=2600, Volume=8, Capacity=1000, Memory=512, Price=25000, Number=20},
                new Сomputer() {Code=4, Name="DELL Vostro 3681 SFF", Type="Intel Core", Frequency=2900, Volume=16, Capacity=1000, Memory=512, Price=120000, Number=40},
                new Сomputer() {Code=5, Name="ASUS ExpertCenter D5", Type="Intel Pentium Gold", Frequency=4000, Volume=8, Capacity=1000, Memory=512, Price=52000, Number=80},
                new Сomputer() {Code=5, Name="HP M01 Mini-Tower", Type="Intel Pentium Gold", Frequency=4100, Volume=8, Capacity=1000, Memory=512, Price=29000, Number=50},
            };
            Console.WriteLine("Введите тип процессора");
            string type = Console.ReadLine();
            List<Сomputer> сomputer1 = computer.Where(x => x.Type == type).ToList();
            Print(сomputer1);

            Console.WriteLine("Введите объем ОЗУ");
            int volume = Convert.ToInt32(Console.ReadLine());
            List<Сomputer> сomputer2 = computer.Where(x => x.Volume >= volume).ToList();
            Print(сomputer2);

            Console.WriteLine("Сортировка по увеличению стоимости");
            List<Сomputer> сomputer3 = computer.OrderBy(x => x.Price).ToList();
            Print(сomputer3);

            Console.WriteLine("Группировка по типу процессора");
            IEnumerable<IGrouping<string, Сomputer>> computer4 = computer.GroupBy(x => x.Type);
            foreach (IGrouping<string, Сomputer> gr in computer4)
            {
                Console.WriteLine(gr.Key);
                foreach (Сomputer c in gr)
                {
                    Console.WriteLine($"{c.Code} {c.Name} {c.Type} {c.Frequency} {c.Volume} {c.Capacity} {c.Memory} {c.Price} {c.Number}");                   
                }
            }
            Console.WriteLine();

            Console.WriteLine("Самый дорогой компьютер");
            Сomputer сomputer5 = computer.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{сomputer5.Code} {сomputer5.Name} {сomputer5.Type} {сomputer5.Frequency} {сomputer5.Volume} {сomputer5.Capacity} {сomputer5.Memory} {сomputer5.Price} {сomputer5.Number}");
            Console.WriteLine();

            Console.WriteLine("Самый бюджетный компьютер");
            Сomputer сomputer6 = computer.OrderBy(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{сomputer6.Code} {сomputer6.Name} {сomputer6.Type} {сomputer6.Frequency} {сomputer6.Volume} {сomputer6.Capacity} {сomputer6.Memory} {сomputer6.Price} {сomputer6.Number}");
            Console.WriteLine();

            Console.WriteLine("Есть ли хотя бы один компьютер в количестве не менее 30 штук?");
            Console.WriteLine(computer.Any(x => x.Number>=30));

            Console.ReadKey();
        }
        static void Print(List<Сomputer>сomputer)
        {
            foreach(Сomputer c in сomputer)
            {
                Console.WriteLine($"{c.Code} {c.Name} {c.Type} {c.Frequency} {c.Volume} {c.Capacity} {c.Memory} {c.Price} {c.Number}");
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>() // набор Моделей  компьютера
            {
                new Computer(){CodeComputer=1, NameComputer="Lenovo", TypeProcessor="Core i5", FrequencyProcessor=2.9, VolumeOperational=16, VolumeHardDrive=512, VolumeVideoCard=6, CostComputer=84999, QuantityExemplar=10},
                new Computer(){CodeComputer=2, NameComputer="Acer", TypeProcessor="Core i5", FrequencyProcessor=2.6, VolumeOperational=8, VolumeHardDrive=256, VolumeVideoCard=6, CostComputer=58499, QuantityExemplar=51},
                new Computer(){CodeComputer=3, NameComputer="Acer", TypeProcessor="Core i7", FrequencyProcessor=2.5, VolumeOperational=16, VolumeHardDrive=512, VolumeVideoCard=4, CostComputer=109799, QuantityExemplar=3},
                new Computer(){CodeComputer=4, NameComputer="ASUS", TypeProcessor="Core i5", FrequencyProcessor=2.6, VolumeOperational=16, VolumeHardDrive=512, VolumeVideoCard=4, CostComputer=72999, QuantityExemplar=8},
                new Computer(){CodeComputer=5, NameComputer="DEXP", TypeProcessor="Core i5", FrequencyProcessor=2.9, VolumeOperational=8, VolumeHardDrive=512, VolumeVideoCard=4, CostComputer=84999, QuantityExemplar=11},
                new Computer(){CodeComputer=6, NameComputer="ZET", TypeProcessor="Core i7", FrequencyProcessor=2.9, VolumeOperational=16, VolumeHardDrive=512, VolumeVideoCard=12, CostComputer=124999, QuantityExemplar=35},
                new Computer(){CodeComputer=7, NameComputer="HYPERPC", TypeProcessor="Core i5", FrequencyProcessor=3.9, VolumeOperational=32, VolumeHardDrive=500, VolumeVideoCard=8, CostComputer=224999, QuantityExemplar=1},
                new Computer(){CodeComputer=8, NameComputer="HP", TypeProcessor="Core i5", FrequencyProcessor=2.9, VolumeOperational=8, VolumeHardDrive=256, VolumeVideoCard=6, CostComputer=54999, QuantityExemplar=4},
            };
            ///Определить все компьютеры с указанным процессором. Название процессора запросить у пользователя
            //Console.WriteLine("Введите название процессора:");
            //string typeProcessor = Console.ReadLine();
            //List<Computer> computers1 = computers.Where(x => x.TypeProcessor == typeProcessor).ToList(); // из списка выбрать то что совпадёт с тем что введём, х это переменная, её нигде не объявляем с типом employ
            //Print(computers1);// выводим результат

            /// Определить все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя
            //Console.WriteLine("Введите объем оперативной памяти:");
            //int volumeOperational = Convert.ToInt32(Console.ReadLine());
            //List<Computer> computers2 = computers.Where(x => x.VolumeOperational >= volumeOperational).ToList(); 
            //Print(computers2);

            ///вывести весь список, отсортированный по увеличению стоимости
            //List<Computer> computers3 = computers.OrderBy(x => x.CostComputer).ToList();
            //Print(computers3);

            ///вывести весь список, сгруппированный по типу процессора
            //IEnumerable<IGrouping<string, Computer>> computers4=computers.GroupBy(x => x.TypeProcessor);
            //foreach (IGrouping<string, Computer> gr in computers4) // перебираем
            //{
            //    Console.WriteLine(gr.Key); // выводим списокб, Key - общий параметр
            //    foreach (Computer e in gr)
            //    {
            //        Console.WriteLine($"\nКод компьютера: {e.CodeComputer} \nМарка компьютера: {e.NameComputer} \nТип процессора: {e.TypeProcessor} \nЧастота процессора: {e.FrequencyProcessor} \nОбъем оперативной памяти: {e.VolumeOperational} \nОбъем жесткого диска: {e.VolumeHardDrive} \nОбъем памяти видеокарты: {e.VolumeVideoCard} \nСтоимость компьютера: {e.CostComputer} \nКоличество экземпляров: {e.QuantityExemplar}");
            //    }
            //}

            ///найти самый дорогой  компьютер
            //Computer computers5 = computers.OrderByDescending(x => x.CostComputer).FirstOrDefault(); // сортируем по убыванию и берем самую верхнюю запись
            //Console.WriteLine($"\nКод компьютера: {computers5.CodeComputer} \nМарка компьютера: {computers5.NameComputer} \nТип процессора: {computers5.TypeProcessor} \nЧастота процессора: {computers5.FrequencyProcessor} \nОбъем оперативной памяти: {computers5.VolumeOperational} \nОбъем жесткого диска: {computers5.VolumeHardDrive} \nОбъем памяти видеокарты: {computers5.VolumeVideoCard} \nСтоимость компьютера: {computers5.CostComputer} \nКоличество экземпляров: {computers5.QuantityExemplar}");

            ///найти самый бюджетный компьютер
            //Computer computers5 = computers.OrderBy(x => x.CostComputer).FirstOrDefault(); // сортируем по возрастанию и берем самую верхнюю запись
            //Console.WriteLine($"\nКод компьютера: {computers5.CodeComputer} \nМарка компьютера: {computers5.NameComputer} \nТип процессора: {computers5.TypeProcessor} \nЧастота процессора: {computers5.FrequencyProcessor} \nОбъем оперативной памяти: {computers5.VolumeOperational} \nОбъем жесткого диска: {computers5.VolumeHardDrive} \nОбъем памяти видеокарты: {computers5.VolumeVideoCard} \nСтоимость компьютера: {computers5.CostComputer} \nКоличество экземпляров: {computers5.QuantityExemplar}");

            ///есть ли хотя бы один компьютер в количестве не менее 30 штук
            if (computers.Any(x=>x.QuantityExemplar>30))
            {
                Console.WriteLine("Есть компьютеры в количестве не менее 30 штук.");
            }
            else
            {
                Console.WriteLine("Нет компьютеров в количестве не менее 30 штук.");
            }



            Console.ReadKey();
        }

        // метод кт будет получать список компьютеров и выводить их на экран
        static void Print (List<Computer> computers)
        {
            foreach(Computer e in computers)
            {
                Console.WriteLine($"\nКод компьютера: {e.CodeComputer} \nМарка компьютера: {e.NameComputer} \nТип процессора: {e.TypeProcessor} \nЧастота процессора: {e.FrequencyProcessor} \nОбъем оперативной памяти: {e.VolumeOperational} \nОбъем жесткого диска: {e.VolumeHardDrive} \nОбъем памяти видеокарты: {e.VolumeVideoCard} \nСтоимость компьютера: {e.CostComputer} \nКоличество экземпляров: {e.QuantityExemplar}");
            }
            Console.WriteLine();
        }
    }
}

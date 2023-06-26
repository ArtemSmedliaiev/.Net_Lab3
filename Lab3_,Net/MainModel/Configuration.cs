using Lab3__Net.MainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3__Net.MainModel
{
    public class Configuration
    {
        public List<Motherboard> motherboards { get; set; } = new List<Motherboard>();
        public List<Processor> processors { get; set; } = new List<Processor>();
        public List<HardDrive> hardDrives { get; set; } = new List<HardDrive>();
        public List<RAM> RAMs { get; set; } = new List<RAM>();

        public void PrintConfiguration()
        {
            Console.Clear();
            Console.WriteLine(">>>Конфігурація товарів за вашими параметрами<<<");
            Console.WriteLine("Материнські плати:");
            int i = 1;
            foreach (var board in motherboards)
            {
                Console.Write(i + " ");
                Console.WriteLine(board.GetInfo());
                i++;
            }
            Console.WriteLine("Процессори:");
            i = 1;
            foreach (var processor in processors)
            {
                Console.Write(i + " ");
                Console.WriteLine(processor.GetInfo());
                i++;
            }
            Console.WriteLine("Жорсткі диски:");
            i = 1;
            foreach (var hardDrive in hardDrives)
            {
                Console.Write(i + " ");
                Console.WriteLine(hardDrive.GetInfo());
                i++;
            }
            Console.WriteLine("Оперативна пам'ять:");
            i = 1;
            foreach (var RAM in RAMs)
            {
                Console.Write(i + " ");
                Console.WriteLine(RAM.GetInfo());
                i++;
            }
        }
    }
}

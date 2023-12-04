using System.Diagnostics;

namespace Dispetcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\t\tДиспетчер задач");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("  Задача:");
                Console.SetCursorPosition(40, 2);
                Console.WriteLine("Опр. пам:");
                Console.SetCursorPosition(55, 2);
                Console.WriteLine("Физ. пам:");
                Process[] processes = Process.GetProcesses();
                int i = 0;
                int j = 3;
                foreach (Process process in processes) 
                {
                    Console.WriteLine("  " + process.ProcessName);
                    Console.SetCursorPosition(40, j);
                    float s = process.PeakPagedMemorySize64;
                    float pagedManory = s/1048576;
                    Console.WriteLine(string.Format("{0:N2}", pagedManory) +" "+ "МБ" );
                    Console.SetCursorPosition(55, j);
                    float f = process.PeakWorkingSet64;
                    float nopaged = s/1048576;
                    Console.WriteLine(string.Format("{0:N2}", nopaged) +" "+ "МБ");
                    i++;
                    j++;
                }
                int pos = strelka.show(3,i+2);
                Console.Clear();
                inside.nutri(processes[pos-3]); 
            }
        }
    }
}
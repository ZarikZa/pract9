using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dispetcher
{
    internal class inside
    {
        public static void nutri(Process proces)
        {
            while (true)
            {
                klavishi pos;
                Console.WriteLine(proces);
                Console.WriteLine("--------------------------------------------------------------");
                bool oshibka = true;
                try
                {
                    Console.WriteLine("  Класс приоритета:\t" + proces.PriorityClass);
                    Console.WriteLine("  Использование диска:\t" + proces.WorkingSet64/1048576 + " МБ");
                    Console.WriteLine("  Приоритет:\t" + proces.BasePriority);
                    Console.WriteLine("  Время использования процесса:\t" + proces.UserProcessorTime);
                    Console.WriteLine("  Всё время использования:\t" + proces.TotalProcessorTime);
                    Console.WriteLine("  Использование оперативной памяти:\t" + proces.PagedMemorySize64/1048576 + " МБ");
                }
                catch (Exception)
                {
                    Console.WriteLine("  Процесс недоступен для отображения");
                    Console.WriteLine("  Информация недоступна");
                    oshibka=false;
                }
                finally
                {
                    Console.WriteLine("---------------------------------------------------------------");
                    string status = "";
                    if (proces.Responding == true)
                    {
                        status = "Запущен";
                    }
                    else
                    {
                        status = "Не запущен";
                    }
                    Console.WriteLine($"Cтатус - {status}");
                    Console.WriteLine("D - Завершить процесс");
                    Console.WriteLine("Delete - Завершить все процессы с этим именем");
                }
                if (oshibka == true)
                {
                    pos = (klavishi)strelka.show(2, 7);
                }
                else
                {
                    pos =  (klavishi)strelka.show(2, 3);
                }
                switch (pos)
                {
                    case klavishi.nazad:
                        return;
                    case klavishi.zaversh:
                        if (oshibka == true)
                        {
                            proces.Kill();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("-----------------------------------------------------------------------");
                            Console.WriteLine("Нельзя закрыть этот процесс");
                            Console.WriteLine("-----------------------------------------------------------------------");
                            Thread.Sleep(3000);
                        }
                        return;
                    case klavishi.zavershenieall:
                        var name = proces.ProcessName;
                        Process[] listpro = Process.GetProcessesByName(name);
                        if (oshibka == true)
                        {
                            foreach (Process p in listpro)
                            {
                                p.Kill();
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("-----------------------------------------------------------------------");
                            Console.WriteLine("Нельзя закрыть этот процесс");
                            Console.WriteLine("-----------------------------------------------------------------------");
                            Thread.Sleep(3000);
                        }
                        return;
                }
            }
        }
    }
}
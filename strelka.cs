﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispetcher
{
    internal class strelka
    {
        public static int show(int minstrelka, int maxstrelka)
        {
            int pos = minstrelka;
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");
                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (pos == minstrelka)
                    {
                        pos = maxstrelka;
                    }
                    pos--;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    if (pos == maxstrelka)
                    {
                        pos = minstrelka;
                    }
                    pos++;
                }
                if (key.Key == ConsoleKey.Backspace)
                {
                    Console.Clear();
                    return (int)klavishi.nazad;
                }
                else if(key.Key == ConsoleKey.D)
                {
                    return (int)klavishi.zaversh;
                }
                else if(key.Key == ConsoleKey.Delete)
                {
                    return (int)klavishi.zavershenieall;
                }
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
            } while (key.Key != ConsoleKey.Enter);
            return pos;
        }
    }
}
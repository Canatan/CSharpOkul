﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10sayi7ve5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 tane sayi gir");
            int[] sayilar = new int[10];
            for (int i = 0; i < 10; i++)
            {
                sayilar[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < 10; i++)
            {
                if (sayilar[i] % 35 == 0)
                {
                    Console.WriteLine("5 ve 7 ile tam bölünen sayılar"+sayilar[i]);
                }else
                {
                    Console.WriteLine("Doru gir");
                }Console.ReadLine();
            }

        }
    }
}

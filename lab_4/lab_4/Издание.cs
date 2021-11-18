using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4
{
    class Izdanie
    {
        public string Vidacha { get; }

        public string Vipysk { get; }
    
        public void PrintFullName()
        {
            Console.WriteLine($"Дата: {Vipysk}\t Место: {Vidacha} ");
        }
    }
}

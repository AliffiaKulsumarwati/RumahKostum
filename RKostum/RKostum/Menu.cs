using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace NewProgramFundamental
{

    public class Menu : Customer
    {
        public int a { get; set; }
        public int b { get; set; }
        public string z { get; set; }
        public string Kostum { get; set; }
        public int price { get; set; }

        public void tampil()
        {
            Console.WriteLine($"Nama Kostum\t: {Kostum}\nHarga Kostum\t: {price}");
        }

    }
}
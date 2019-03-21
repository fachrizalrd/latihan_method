using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklarasi variabel
            int hasil;

            // membuat objek dari Class Calculator
            Calculator calculator = new Calculator();

            // call method Penjumlahan
            hasil = calculator.Penjumlahan(10, 2);
            CetakHasil("Hasil Penjumlahan : " + hasil);

            // call overloading method Penjumlahan
            hasil = calculator.Penjumlahan(10, 2, 1);
            CetakHasil("Hasil Penjumlahan Overload : " + hasil);

            // call method Pengurangan
            hasil = calculator.Pengurangan(8, 3);
            CetakHasil("Hasil Pengurangan : " + hasil);

            // call static method
            hasil = Calculator.Perkalian(5, 3);
            CetakHasil("Hasil Perkalian : " + hasil);

            Console.ReadKey();
        }

        static void CetakHasil(string hasil)
        {
            Console.WriteLine(hasil);
        }
    }
    
}

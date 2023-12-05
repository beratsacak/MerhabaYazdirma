using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerhabaYazdirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("adını gir");
            string ad =Convert.ToString(Console.ReadLine());
            Selam selam = new Selam();
            selam.selamla(ad);
 
        }
    }
    public class Selam
    {
        public void selamla(string ad= "emre")
        {
            Console.WriteLine("Merhaba " + ad);
        }

    }
}

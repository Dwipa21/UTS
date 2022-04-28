using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uts
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dosen dosen = new Dosen();

            //pemanggilan method
            Console.WriteLine("================================================");
            Console.WriteLine("Method Ke-1");
            Console.WriteLine("================================================");
            dosen.dosen();
            Console.WriteLine("================================================");
            Console.WriteLine("Method Ke-2");
            Console.WriteLine("================================================");
            Console.Write("Masukkan Nama    : ");
            string nama;
            nama = Console.ReadLine();
            Console.Write("Masukkan NIK     : ");
            int nik;
            nik = int.Parse(Console.ReadLine());
            dosen.attDosen(nama, nik);
            Console.WriteLine("================================================");
            Console.WriteLine("Method Ke-3");
            Console.WriteLine("================================================");
            Console.Write("Masukkan Mata Kuliah Tambahan : ");
            string course;
            course = Console.ReadLine();
            Console.WriteLine("----------------------");
            dosen.dosen();
            dosen.addCourse(course);
            Console.WriteLine("================================================");

            Console.ReadKey();
        }
    }
}

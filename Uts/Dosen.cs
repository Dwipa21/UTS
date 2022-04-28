using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uts
{
    public class Dosen
    {
        public void dosen()
        {
            Console.WriteLine("Dosen Pengampu   : Kamarudin, M.kom");
            Console.WriteLine("ID               : 29876xxxxx");
            Console.WriteLine("Mata kuliah      : Pemograman");
            Console.WriteLine("Gender           : Laki-Laki");
        }
        public void attDosen(string nama, int nik)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Nama Dosen   : " + nama);
            Console.WriteLine("NIK Dosen    : " + nik);
        }
        public void addCourse(string course)
        {
            Console.WriteLine("Mataka Kuliah Tambahan   : " + course);
        }
    }
}

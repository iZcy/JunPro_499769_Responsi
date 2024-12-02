using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunPro_499769_Responsi
{
    // Implementasi Abstraksi
    public class Interfaces
    {
        public interface IKaryawan
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int id_dept { get; set; }
            public int id_jabatan { get; set; }
        }

        public interface IDepartement
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public interface IJabatan
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Salary { get; set; }
        }
    }
}

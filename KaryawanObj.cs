using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunPro_499769_Responsi
{
    public class KaryawanObj : Interfaces.IKaryawan
    {
        private int _id;
        private string _name;
        private int _id_dept;
        private int _id_jabatan;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int id_dept
        {
            get { return _id_dept; }
            set { _id_dept = value; }
        }

        public int id_jabatan
        {
            get { return _id_jabatan; }
            set { _id_jabatan = value; }
        }

        // Polymorphism implementation
        public KaryawanObj()
        {
            Random random = new Random();
            _id = random.Next(1, 100000);
            _name = "Karyawan " + _id;
            _id_dept = DepartementObj.departements[random.Next(0, DepartementObj.departements.Count)].Id;
            _id_jabatan = JabatanObj.jabatans[random.Next(0, JabatanObj.jabatans.Count)].Id;
        }

        public KaryawanObj(int id, string name, int id_dept, int id_jabatan)
        {
            _id = id;
            _name = name;
            _id_dept = id_dept;
            _id_jabatan = id_jabatan;
        }

        // Value Storage
        public static List<KaryawanObj> karyawans = new List<KaryawanObj>();

        // Queries
        public static class KaryawanQueries
        {
            public static string GetKaryawan()
            {
                string query = "SELECT * FROM karyawan";
                return query;
            }

            public static string InsertKaryawan(KaryawanObj karyawan)
            {
                string query = "INSERT INTO karyawan (id, name, id_dept, id_jabatan) VALUES (" + karyawan.Id + ", '" + karyawan.Name + "', " + karyawan.id_dept + ", " + karyawan.id_jabatan + ")";
                return query;
            }

            public static string UpdateKaryawan(KaryawanObj karyawan)
            {
                string query = "UPDATE karyawan SET name = '" + karyawan.Name + "', id_dept = " + karyawan.id_dept + ", id_jabatan = " + karyawan.id_jabatan + " WHERE id = " + karyawan.Id;
                return query;
            }

            public static string DeleteKaryawan(KaryawanObj karyawan)
            {
                string query = "DELETE FROM karyawan WHERE id = " + karyawan.Id;
                return query;
            }
        }
    }
}

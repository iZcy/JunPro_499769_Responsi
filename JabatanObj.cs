using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunPro_499769_Responsi
{
    public class JabatanObj : Interfaces.IJabatan
    {
        private int _id;
        private string _name;
        private string _salary;

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

        public string Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        // Polymorphism implementation
        public JabatanObj()
        {
            Random random = new Random();
            _id = random.Next(1, 100000);
            _name = "Jabatan " + _id;
            _salary = random.Next(1, 100000).ToString();
        }

        public JabatanObj(int id, string name, string salary)
        {
            _id = id;
            _name = name;
            _salary = salary;
        }

        // Value Storage
        public static List<JabatanObj> jabatans = new List<JabatanObj>();

        // Queries
        public static class JabatanQueries
        {
            public static string GetJabatan()
            {
                string query = "SELECT * FROM jabatan";
                return query;
            }
        }
    }
}

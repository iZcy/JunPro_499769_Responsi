using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunPro_499769_Responsi
{
    public class DepartementObj: Interfaces.IDepartement
    {
        private int _id;
        private string _name;

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

        // Polymorphism implementation
        public DepartementObj() {
            Random random = new Random();
            _id = random.Next(1, 100000);
            _name = "Departement " + _id;
        }

        public DepartementObj(int id, string name)
        {
            _id = id;
            _name = name;
        }

        // Value Storage
        public static List<DepartementObj> departements = new List<DepartementObj>();

        // Queries
        public static class DepartementQueries
        {
            public static string GetDepartement()
        {
            string query = "SELECT * FROM departemen";
            return query;
        }
    }
}
}

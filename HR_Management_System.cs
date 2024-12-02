// Import library for postgresql
using Npgsql;
using static JunPro_499769_Responsi.Interfaces;

namespace JunPro_499769_Responsi
{
    public partial class HR_Management_System : Form
    {
        public HR_Management_System()
        {
            InitializeComponent();
            ConnectDatabase();
        }

        // Connect local postgresql database
        private void ConnectDatabase()
        {
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=Z@cky4JunPro;Database=postgres;";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            MessageBox.Show("Connected to database");

            // Jabatan
            NpgsqlCommand cmd = new NpgsqlCommand(JabatanObj.JabatanQueries.GetJabatan(), conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // Insert data into JabatanObj database
                JabatanObj.jabatans.Add(new JabatanObj(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString()));
            }
            // Add the list to dropdown
            inputJabatanList.Items.AddRange(JabatanObj.jabatans.Select(x => x.Name).ToArray());

            conn.Close();

            conn.Open();

            // Departement
            cmd = new NpgsqlCommand(DepartementObj.DepartementQueries.GetDepartement(), conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // Insert data into DepartementObj database
                DepartementObj.departements.Add(new DepartementObj(int.Parse(reader[0].ToString()), reader[1].ToString()));
            }
            // Add the list to dropdown
            inputDepartementList.Items.AddRange(DepartementObj.departements.Select(x => x.Name).ToArray());

            conn.Close();

            // Karyawan
            conn.Open();
            cmd = new NpgsqlCommand(KaryawanObj.KaryawanQueries.GetKaryawan(), conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // Insert data into KaryawanObj database
                KaryawanObj.karyawans.Add(new KaryawanObj(int.Parse(reader[0].ToString()), reader[1].ToString(), int.Parse(reader[2].ToString()), int.Parse(reader[3].ToString())));
            }

            conn.Close();
        }

        private void HR_Management_System_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
            // make an sql query to insert
            // insert into employee values (idEmployee.Text, nameEmployee.Text, idDepartmentList.Text, salaryEmployee.Text)

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void idDepartmentList_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void insertData_Click(object sender, EventArgs e)
        {

        }
    }
}

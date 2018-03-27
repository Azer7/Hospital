using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clinic
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Server = AZER-PC; Database = hospital; Trusted_Connection = True;");
        public Form1()
        {
            InitializeComponent();
            FillData();
        }

        private void FillData()
        {

            con.Close();
            con.Open();

            dgvDocs.Rows.Clear();
            dgvPat.Rows.Clear();
            dgvPro.Rows.Clear();
            dgvNewEvent.Rows.Clear();
            dgvShowAll.Rows.Clear();

            cbEventDoc.Items.Clear();
            cbEventPat.Items.Clear();
            cbEventPro.Items.Clear();

            string query1 = "SELECT * FROM Doctors";
            string query2 = "SELECT * FROM Patients";
            string query3 = "SELECT * FROM Procedur";
            string query4 = "SELECT date, Doctors.name, Patients.name, Procedur.Name from NewEvent NE " +
                                "JOIN Doctors ON NE.doctor = Doctors.id " +
                                "JOIN Patients ON NE.patient = Patients.id " +
                                "Join Procedur ON NE.psro = Procedur.id";

            string query5 = "SELECT date, Doctors.name,Doctors.Department,Doctors.position, Patients.name,Patients.age,Patients.telephone, Procedur.Name, Procedur.description,Procedur.price from NewEvent NE " +
                                "JOIN Doctors ON NE.doctor = Doctors.id " +
                                "JOIN Patients ON NE.patient = Patients.id " +
                                "Join Procedur ON NE.psro = Procedur.id";


            SqlCommand command1 = new SqlCommand(query1, con);
            SqlCommand command2 = new SqlCommand(query2, con);
            SqlCommand command3 = new SqlCommand(query3, con);
            SqlCommand command4 = new SqlCommand(query4, con);
            SqlCommand command5 = new SqlCommand(query5, con);

            //command.ExecuteNonQuery();insert, Update, Delete

            SqlDataReader reader1 = command1.ExecuteReader();//select
            while (reader1.Read())

            {
                dgvDocs.Rows.Add(reader1.GetString(1), reader1.GetString(2), reader1.GetString(3));
                cbEventDoc.Items.Add(reader1.GetString(1));
            }
            con.Close();

            con.Open();
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())

            {
                dgvPat.Rows.Add(reader2.GetString(1), reader2.GetInt32(2), reader2.GetString(3));
                cbEventPat.Items.Add(reader2.GetString(1));
            }
            con.Close();

            con.Open();
            SqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())

            {
                dgvPro.Rows.Add(reader3.GetString(1), reader3.GetDecimal(2), reader3.GetString(3));
                cbEventPro.Items.Add(reader3.GetString(1));
            }
            con.Close();

            con.Open();
            SqlDataReader reader4 = command4.ExecuteReader();
            while (reader4.Read())

            {
                //MessageBox.Show(Convert.ToString(reader4.GetDateTime(0)));
                dgvNewEvent.Rows.Add(reader4.GetDateTime(0), reader4.GetString(1), reader4.GetString(2), reader4.GetString(3));
            }
            con.Close();



            con.Open();
            SqlDataReader reader5 = command5.ExecuteReader();

            while (reader5.Read())
            {
                dgvShowAll.Rows.Add(reader5.GetDateTime(0), reader5.GetString(1), reader5.GetString(2), reader5.GetString(3), reader5.GetString(4), reader5.GetInt32(5), reader5.GetString(6), reader5.GetString(7), reader5.GetString(8), reader5.GetDecimal(9));
            }

            con.Close();

        }


        private void btnAddDoc_Click(object sender, EventArgs e)
        {
            picLogo.Visible = false;
            btnAddEvent.Visible = false;
            btnAddPat.Visible = false;
            btnAddPro.Visible = false;
            btnSearch.Visible = false;
            btnAddDoc.Visible = false;
            btnShowAll.Visible = false;

            tbFullName.Visible = true;
            tbPosition.Visible = true;
            cbDep.Visible = true;
            lblFullName.Visible = true;
            lblPosition.Visible = true;
            lblDep.Visible = true;
            dgvDocs.Visible = true;
            btnAdd.Visible = true;
            btnBack.Visible = true;
            btnBack.Location = new Point(197, 280);
            btnBack.Size = new Size(75, 23);

            //FillAllData();
        }
        private void btnAddPro_Click(object sender, EventArgs e)
        {
            picLogo.Visible = false;
            btnAddEvent.Visible = false;
            btnAddPat.Visible = false;
            btnAddPro.Visible = false;
            btnSearch.Visible = false;
            btnAddDoc.Visible = false;
            btnShowAll.Visible = false;

            btnBack.Visible = true;
            btnAdd3.Visible = true;
            btnBack.Location = new Point(197, 359);
            btnBack.Size = new Size(75, 23);
            lblName.Visible = true;
            lblPrice.Visible = true;
            lblDesc.Visible = true;
            tbDecs.Visible = true;
            tbPro.Visible = true;
            nudPrice.Visible = true;
            dgvPro.Visible = true;


        }
        private void btnAddPat_Click(object sender, EventArgs e)
        {
            picLogo.Visible = false;
            btnAddEvent.Visible = false;
            btnAddPat.Visible = false;
            btnAddPro.Visible = false;
            btnSearch.Visible = false;
            btnAddDoc.Visible = false;
            btnShowAll.Visible = false;

            lblFullName.Visible = true;
            lblAge.Visible = true;
            lblPhone.Visible = true;
            btnAdd2.Visible = true;
            btnBack.Visible = true;
            dgvPat.Visible = true;
            tbFullName.Visible = true;
            tbAge.Visible = true;
            tbPhone.Visible = true;
            btnBack.Location = new Point(197, 280);
            btnBack.Size = new Size(75, 23);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            picLogo.Visible = true;
            btnAddEvent.Visible = true;
            btnAddPat.Visible = true;
            btnAddPro.Visible = true;
            btnSearch.Visible = true;
            btnAddDoc.Visible = true;
            btnShowAll.Visible = true;

            tbFullName.Visible = false;
            tbPosition.Visible = false;
            tbAge.Visible = false;
            tbPhone.Visible = false;
            cbDep.Visible = false;
            lblFullName.Visible = false;
            lblPosition.Visible = false;
            lblDep.Visible = false;
            lblAge.Visible = false;
            lblPhone.Visible = false;
            dgvDocs.Visible = false;
            dgvPat.Visible = false;
            btnAdd.Visible = false;
            btnAdd2.Visible = false;
            btnBack.Visible = false;
            btnAdd3.Visible = false;
            lblName.Visible = false;
            lblPrice.Visible = false;
            tbPro.Visible = false;
            nudPrice.Visible = false;
            dgvPro.Visible = false;
            lblDesc.Visible = false;
            tbDecs.Visible = false;
            cbEventDoc.Visible = false;
            cbEventPat.Visible = false;
            cbEventPro.Visible = false;
            lblSDoc.Visible = false;
            lblSPat.Visible = false;
            lblSPro.Visible = false;
            btnAdd4.Visible = false;
            btnSearch.Visible = false;
            btnBack.Visible = false;
            dtpEvent.Visible = false;
            lblEventDate.Visible = false;
            dgvNewEvent.Visible = false;
            dgvShowAll.Visible = false;
            test1.Visible = false;
            test2.Visible = false;
            test3.Visible = false;

        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            picLogo.Visible = false;
            btnAddEvent.Visible = false;
            btnAddPat.Visible = false;
            btnAddPro.Visible = false;
            btnSearch.Visible = false;
            btnAddDoc.Visible = false;
            btnShowAll.Visible = false;

            cbEventDoc.Visible = true;
            cbEventPat.Visible = true;
            cbEventPro.Visible = true;
            lblSDoc.Visible = true;
            lblSPat.Visible = true;
            lblSPro.Visible = true;
            btnBack.Visible = true;
            btnAdd4.Visible = true;
            btnBack.Location = new Point(197, 330);
            btnBack.Size = new Size(75, 23);
            dtpEvent.Visible = true;
            lblEventDate.Visible = true;
            dgvNewEvent.Visible = true;
            //test1.Visible = true;
            //test2.Visible = true;
            //test3.Visible = true;


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {


        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            picLogo.Visible = false;
            btnAddEvent.Visible = false;
            btnAddPat.Visible = false;
            btnAddPro.Visible = false;
            btnSearch.Visible = false;
            btnAddDoc.Visible = false;
            btnShowAll.Visible = false;

            btnSearch.Visible = true;
            btnBack.Visible = true;
            btnBack.Location = new Point(475, 429);
            btnBack.Size = new Size(403, 49);
            dgvShowAll.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbFullName.Text;
            string department = cbDep.Text;
            string position = tbPosition.Text;
            con.Open();
            string query = "INSERT INTO Doctors([name],[department],[position]) Values ('" + name + "', '" + department + "', '" + position + "')";
            SqlCommand command = new SqlCommand(query, con);
            int result = command.ExecuteNonQuery();


            FillData();
            con.Close();
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            string name = tbFullName.Text;
            int age = Convert.ToInt32(tbAge.Text);
            string phone = tbPhone.Text;
            con.Open();
            string query = "INSERT INTO Patients([name],[age],[telephone]) Values ('" + name + "', '" + age + "', '" + phone + "')";
            SqlCommand command = new SqlCommand(query, con);
            int result = command.ExecuteNonQuery();

            FillData();
            con.Close();
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            string name = tbPro.Text;
            decimal price = nudPrice.Value;
            string description = tbDecs.Text;
            con.Open();
            string query = "INSERT INTO Procedur([Name],[price],[description]) Values ('" + name + "', '" + price + "', '" + description + "')";
            SqlCommand command = new SqlCommand(query, con);
            int result = command.ExecuteNonQuery();

            FillData();
            con.Close();


        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            string eventname = cbEventDoc.Text;
            string eventprice = cbEventPat.Text;
            string eventdescription = cbEventPro.Text;
            con.Open();

            string eventname2 = "SELECT D.id from Doctors D where D.name LIKE '%" + eventname + "%'";
            string eventprice2 = "SELECT P.id from Patients P where P.name LIKE '%" + eventprice + "%'";
            string eventdescription2 = "SELECT Pr.id from Procedur Pr where Pr.Name LIKE '%" + eventdescription + "%'";


            SqlCommand command1 = new SqlCommand(eventname2, con);
            SqlCommand command2 = new SqlCommand(eventprice2, con);
            SqlCommand command3 = new SqlCommand(eventdescription2, con);


            SqlDataReader reader1 = command1.ExecuteReader();//select
            while (reader1.Read())
            {
                test1.Value = reader1.GetInt32(0);
            }
            con.Close();

            con.Open();
            SqlDataReader reader2 = command2.ExecuteReader();//select
            while (reader2.Read())
            {
                test2.Value = reader2.GetInt32(0);
            }
            con.Close();

            con.Open();
            SqlDataReader reader3 = command3.ExecuteReader();//select
            while (reader3.Read())
            {
                test3.Value = reader3.GetInt32(0);
            }
            con.Close();
            con.Open();

            DateTime date = dtpEvent.Value;
            string query = "INSERT INTO NewEvent([date],[doctor],[patient],[psro]) Values ('" + date + "','" + test1.Value + "', '" + test2.Value + "', '" + test3.Value + "')";
            SqlCommand command4 = new SqlCommand(query, con);
            int resulttt = command4.ExecuteNonQuery();

            con.Close();

            FillData();
        }
    }
}

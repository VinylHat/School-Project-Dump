using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Database_Program_Challenge
{
    public partial class Form1 : Form
    {
        public string constring = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = .\Northwind.mdb";
        OleDbConnection con;
        public Form1()
        {
            InitializeComponent();
            con = new OleDbConnection(constring);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectRow = dataGridView1.SelectedCells[0].RowIndex;
            OleDbConnection conn = new OleDbConnection(constring);
            conn.Open();

            string sql = "Delete From Shippers Where ShipperID = @param1";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.Add("@param1", OleDbType.Integer).Value =
                Convert.ToInt32(dataGridView1.Rows[selectRow].Cells[0].Value.ToString());
            // Thats just weird and unnecessary, what was wrong with Int?
            // I assume there is a reason, doesnt not mean I have to like it
            cmd.ExecuteNonQuery();

            conn.Close();
            //btnDisplay_Click();
            //I guess that makes sense, needs an argument
            //This makes my later comments ironc
            DisplayStudent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string sql = "Select * from Shippers";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            con.Open();

            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(constring);
            conn.Open();
            string sql = "Insert into Shippers (CompanyName, Phone) " +
                "Values(@param1, @param2)";

            OleDbCommand cmd = new OleDbCommand(sql, conn);

            cmd.Parameters.Add("@param1", OleDbType.VarChar, 50).Value = txtName.Text;
            cmd.Parameters.Add("@param2", OleDbType.VarChar, 50).Value = txtPhone.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
            DisplayStudent();
        }
        // Proof of my copy paste
        // about 6 minutes later I relize this was stupid because I already have a display method
        // I am leaving it in because at least I tried... I guess
        public void DisplayStudent()
        {
            string sql = "SELECT * from Shippers; ";
            OleDbConnection conn = new OleDbConnection(constring);

            OleDbDataAdapter sa = new OleDbDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            sa.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}

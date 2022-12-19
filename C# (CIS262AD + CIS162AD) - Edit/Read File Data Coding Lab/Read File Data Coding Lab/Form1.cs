using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Read_File_Data_Coding_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string[] names = { "Jimmy Neutron", "Carol Wheezer", "Danny DeVito", "Eris Morn", "Elsie Bray" };
            string filename = "StudentsNames2";

            try
            {
                File.WriteAllLines(filename, names);
                MessageBox.Show("Student Names have been written to a File");
            }
            catch (IOException err)
            {
                MessageBox.Show("An Error occured: " + err.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string[] names = new string[5];
            string filename = "StudentsNames2";

            try
            {
                names = File.ReadAllLines(filename);
                foreach (string person in names)
                {
                    listBox1.Items.Add(person);
                }
            }
            catch (IOException err)
            {
                MessageBox.Show("An Error occured: " + err.Message);
            }
        }
    }
}

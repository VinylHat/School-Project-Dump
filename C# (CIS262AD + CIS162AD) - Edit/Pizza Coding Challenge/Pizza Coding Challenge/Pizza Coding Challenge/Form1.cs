using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Coding_Challenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstSize.SelectedItems.Clear();
            chkGreen.Checked = false;
            chkMush.Checked = false;
            chkOlive.Checked = false;
            chkOnion.Checked = false;
            chkPep.Checked = false;
            chkSaus.Checked = false;
            rdoCherry.Checked = false;
            rdoCoffee.Checked = false;
            rdoCoke.Checked = false;
            rdoCrush.Checked = false;
            rdoSprite.Checked = false;
            rdoTea.Checked = false;
            rdoVanilla.Checked = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string toppings = "";
            string drink = "and no drink";
            double cost = 0.0;
            if (chkGreen.Checked == true)
            {
                cost += 0.5;
                toppings += "Green Peppers, ";
            }
            if (chkMush.Checked == true)
            {
                cost += 0.5;
                toppings += "Mushrooms, ";
            }
            if (chkOlive.Checked == true)
            {
                cost += 0.5;
                toppings += "Black Olives, ";
            }
            if (chkOnion.Checked == true)
            {
                cost += 0.5;
                toppings += "Onions, ";
            }
            if (chkPep.Checked == true)
            {
                cost += 1;
                toppings += "Pepperoni, ";
            }
            if (chkSaus.Checked == true)
            {
                cost += 1;
                toppings += "Sausage, ";
            }
            if (rdoCherry.Checked == true || rdoCoke.Checked == true || rdoCrush.Checked == true || rdoSprite.Checked == true || rdoVanilla.Checked == true)
            {
                cost += 2;
                drink = "and a Soda";
                // Just wanted to cut out a few if statments, sorry if this is a bit "cheap"
            }
            if (rdoTea.Checked == true)
            {
                cost += 2;
                drink = "and a Sweet Tea";
            }
            if (rdoCoffee.Checked == true)
            {
                cost += 2;
                drink = "and a coffee";
            }
            switch (lstSize.Text)
            {
                case "Small":
                    cost += 8;
                    break;
                case "Large":
                    cost += 12;
                    break;
                case "X-Large":
                    cost += 14;
                    break;
                default:
                    cost += 10;
                    break;
                    // This assumes the default is a medium
            }
            MessageBox.Show("You have ordered a: " + lstSize.Text + " Pizza with " + toppings + drink + "\nTotal comes out to: " + cost.ToString("C2"));
        }
    }
}

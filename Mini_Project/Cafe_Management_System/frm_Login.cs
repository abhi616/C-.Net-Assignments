using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {          

            if (tb_Username.Text != "" && tb_Password.Text != "")
            {            

                if (tb_Username.Text == "Admin" && tb_Password.Text == "a123")
                {
                    MessageBox.Show("You Are Logged In Successfully.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm_Dashboard Dash = new frm_Dashboard();
                    this.Hide();
                    Dash.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Username Or Password", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Question);                 
                }

            }
            else
            {
                MessageBox.Show("Please Enter Username And Password.", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);             
            }
        }

        private void linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Dashboard D = new frm_Dashboard("Guest");
            this.Hide();
            D.Show();
        }
    }
}

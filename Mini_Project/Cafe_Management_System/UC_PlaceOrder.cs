using DGVPrinterHelper;
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
    public partial class UC_PlaceOrder : UserControl
    {
        Function fn = new Function();
        String query;
        public UC_PlaceOrder()
        {
            InitializeComponent();
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_Items.Items.Clear();
            String category = cmb_Category.Text;
            query = "select name from Items where category = '" + category + "'";
            DataSet ds = fn.getData(query);

            for(int i = 0; i < ds.Tables[0].Rows.Count ; i++)
            {
                lb_Items.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            tb_Search.ForeColor = Color.Black;
            lb_Items.Items.Clear();
            String category = cmb_Category.Text;
            query = "select name from Items where category = '" + category + "' and name like '"+tb_Search.Text+"%'";
            showItemList(query);
        }

        private void showItemList(String query)
        {
            lb_Items.Items.Clear();
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                lb_Items.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void lb_Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_UpDown.ResetText();
            tb_Total.Clear();

            String txt = lb_Items.GetItemText(lb_Items.SelectedItem);
            tb_ItemName.Text = txt;
            query = "select price from Items where name = '" + txt + "'";
            DataSet ds = fn.getData(query);

            tb_Price.Text = ds.Tables[0].Rows[0][0].ToString();
        
        }

        private void tb_UpDown_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(tb_UpDown.Value.ToString());
            Int64 price = Int64.Parse(tb_Price.Text);
            tb_Total.Text = (quan * price).ToString();
        }

        protected int n, total = 0;

        int amt;
        private void dgv_Order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amt = int.Parse(dgv_Order.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch
            {

            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_Order.Rows.RemoveAt(this.dgv_Order.SelectedRows[0].Index);
            }
            catch { }
        }

        private void tb_Search_Click(object sender, EventArgs e)
        {
            tb_Search.Clear();
        }

        private void tb_Search_MouseLeave(object sender, EventArgs e)
        {
            if (tb_Search.Text == "")
            {
                tb_Search.Text = "Search";
                tb_Search.ForeColor = Color.DarkGray;              
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            DGVPrinter P = new DGVPrinter();
            P.Title = "Customer Bill";
            P.SubTitle = string.Format("Date : {0}", DateTime.Now.Date);
            P.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            P.PageNumbers = true;
            P.PageNumberInHeader = false;
            P.PorportionalColumns = true;
            P.HeaderCellAlignment = StringAlignment.Near;
            P.Footer = "Total Payable Amount : " + lbl_RS.Text;
            P.FooterSpacing = 15;
            P.PrintDataGridView(dgv_Order);

            total = 0;
            dgv_Order.Rows.Clear();
            lbl_RS.Text = "Rs. " + total;
        }

        private void btn_Add_Item_Click(object sender, EventArgs e)
        {
            if(tb_Total.Text != "0" && tb_Total.Text!="")
            {
                n = dgv_Order.Rows.Add();
                dgv_Order.Rows[n].Cells[0].Value = tb_ItemName.Text;
                dgv_Order.Rows[n].Cells[1].Value = tb_Price.Text;
                dgv_Order.Rows[n].Cells[2].Value = tb_UpDown.Value;
                dgv_Order.Rows[n].Cells[3].Value = tb_Total.Text;

                total += int.Parse(tb_Total.Text);
                lbl_RS.Text = "Rs. " + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity Need To Be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

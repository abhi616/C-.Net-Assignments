
namespace Cafe_Management_System
{
    partial class frm_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linklbl = new System.Windows.Forms.LinkLabel();
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            this.btn_RemoveItem = new System.Windows.Forms.Button();
            this.btn_UpdateItem = new System.Windows.Forms.Button();
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.btn_PlaceOrder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_DeleteItem1 = new Cafe_Management_System.UC_DeleteItem();
            this.uC_UpdateItem1 = new Cafe_Management_System.UC_UpdateItem();
            this.uC_PlaceOrder1 = new Cafe_Management_System.UC_PlaceOrder();
            this.uC_AddItem = new Cafe_Management_System.UC_AddItem();
            this.uC_Welcome1 = new Cafe_Management_System.UC_Welcome();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.linklbl);
            this.panel1.Controls.Add(this.pb_Exit);
            this.panel1.Controls.Add(this.btn_RemoveItem);
            this.panel1.Controls.Add(this.btn_UpdateItem);
            this.panel1.Controls.Add(this.btn_AddItem);
            this.panel1.Controls.Add(this.btn_PlaceOrder);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 840);
            this.panel1.TabIndex = 0;
            // 
            // linklbl
            // 
            this.linklbl.AutoSize = true;
            this.linklbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl.LinkColor = System.Drawing.Color.White;
            this.linklbl.Location = new System.Drawing.Point(86, 773);
            this.linklbl.Name = "linklbl";
            this.linklbl.Size = new System.Drawing.Size(114, 36);
            this.linklbl.TabIndex = 7;
            this.linklbl.TabStop = true;
            this.linklbl.Text = "Log Out";
            this.linklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            // 
            // pb_Exit
            // 
            this.pb_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pb_Exit.Image")));
            this.pb_Exit.Location = new System.Drawing.Point(0, 0);
            this.pb_Exit.Name = "pb_Exit";
            this.pb_Exit.Size = new System.Drawing.Size(95, 80);
            this.pb_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Exit.TabIndex = 2;
            this.pb_Exit.TabStop = false;
            this.pb_Exit.Click += new System.EventHandler(this.pb_Exit_Click);
            // 
            // btn_RemoveItem
            // 
            this.btn_RemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btn_RemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveItem.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveItem.ForeColor = System.Drawing.Color.White;
            this.btn_RemoveItem.Location = new System.Drawing.Point(3, 454);
            this.btn_RemoveItem.Name = "btn_RemoveItem";
            this.btn_RemoveItem.Size = new System.Drawing.Size(319, 66);
            this.btn_RemoveItem.TabIndex = 1;
            this.btn_RemoveItem.Text = "Remove Items";
            this.btn_RemoveItem.UseVisualStyleBackColor = false;
            this.btn_RemoveItem.Click += new System.EventHandler(this.btn_RemoveItem_Click);
            // 
            // btn_UpdateItem
            // 
            this.btn_UpdateItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btn_UpdateItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateItem.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateItem.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateItem.Location = new System.Drawing.Point(3, 342);
            this.btn_UpdateItem.Name = "btn_UpdateItem";
            this.btn_UpdateItem.Size = new System.Drawing.Size(319, 66);
            this.btn_UpdateItem.TabIndex = 1;
            this.btn_UpdateItem.Text = "Update Items";
            this.btn_UpdateItem.UseVisualStyleBackColor = false;
            this.btn_UpdateItem.Click += new System.EventHandler(this.btn_UpdateItem_Click);
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btn_AddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddItem.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddItem.ForeColor = System.Drawing.Color.White;
            this.btn_AddItem.Location = new System.Drawing.Point(3, 231);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(319, 66);
            this.btn_AddItem.TabIndex = 1;
            this.btn_AddItem.Text = "Add Items";
            this.btn_AddItem.UseVisualStyleBackColor = false;
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // btn_PlaceOrder
            // 
            this.btn_PlaceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btn_PlaceOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PlaceOrder.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btn_PlaceOrder.Location = new System.Drawing.Point(3, 130);
            this.btn_PlaceOrder.Name = "btn_PlaceOrder";
            this.btn_PlaceOrder.Size = new System.Drawing.Size(319, 66);
            this.btn_PlaceOrder.TabIndex = 0;
            this.btn_PlaceOrder.Text = "Place Order";
            this.btn_PlaceOrder.UseVisualStyleBackColor = false;
            this.btn_PlaceOrder.Click += new System.EventHandler(this.btn_PlaceOrder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.uC_DeleteItem1);
            this.panel2.Controls.Add(this.uC_UpdateItem1);
            this.panel2.Controls.Add(this.uC_PlaceOrder1);
            this.panel2.Controls.Add(this.uC_AddItem);
            this.panel2.Controls.Add(this.uC_Welcome1);
            this.panel2.Location = new System.Drawing.Point(320, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 840);
            this.panel2.TabIndex = 1;
            // 
            // uC_DeleteItem1
            // 
            this.uC_DeleteItem1.Location = new System.Drawing.Point(0, 0);
            this.uC_DeleteItem1.Name = "uC_DeleteItem1";
            this.uC_DeleteItem1.Size = new System.Drawing.Size(1107, 840);
            this.uC_DeleteItem1.TabIndex = 4;
            // 
            // uC_UpdateItem1
            // 
            this.uC_UpdateItem1.Location = new System.Drawing.Point(0, 0);
            this.uC_UpdateItem1.Name = "uC_UpdateItem1";
            this.uC_UpdateItem1.Size = new System.Drawing.Size(1107, 840);
            this.uC_UpdateItem1.TabIndex = 3;
            // 
            // uC_PlaceOrder1
            // 
            this.uC_PlaceOrder1.Location = new System.Drawing.Point(0, 0);
            this.uC_PlaceOrder1.Name = "uC_PlaceOrder1";
            this.uC_PlaceOrder1.Size = new System.Drawing.Size(1107, 840);
            this.uC_PlaceOrder1.TabIndex = 2;
            // 
            // uC_AddItem
            // 
            this.uC_AddItem.Location = new System.Drawing.Point(3, -3);
            this.uC_AddItem.Name = "uC_AddItem";
            this.uC_AddItem.Size = new System.Drawing.Size(1107, 840);
            this.uC_AddItem.TabIndex = 1;
            // 
            // uC_Welcome1
            // 
            this.uC_Welcome1.BackColor = System.Drawing.Color.White;
            this.uC_Welcome1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uC_Welcome1.Location = new System.Drawing.Point(0, 0);
            this.uC_Welcome1.Name = "uC_Welcome1";
            this.uC_Welcome1.Size = new System.Drawing.Size(1107, 840);
            this.uC_Welcome1.TabIndex = 0;
            // 
            // frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1439, 864);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Dashboard";
            this.Load += new System.EventHandler(this.frm_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_RemoveItem;
        private System.Windows.Forms.Button btn_UpdateItem;
        private System.Windows.Forms.Button btn_AddItem;
        private System.Windows.Forms.Button btn_PlaceOrder;
        private UC_Welcome uC_Welcome1;
        private UC_AddItem uC_AddItem;
        private UC_PlaceOrder uC_PlaceOrder1;
        private UC_UpdateItem uC_UpdateItem1;
        private UC_DeleteItem uC_DeleteItem1;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.LinkLabel linklbl;
    }
}
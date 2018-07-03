namespace WinForm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.addrtxt = new System.Windows.Forms.TextBox();
            this.saltxt = new System.Windows.Forms.TextBox();
            this.insertbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.viewbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(688, 225);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(100, 22);
            this.searchtxt.TabIndex = 4;
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(541, 225);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 5;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Salary";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(248, 12);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(100, 22);
            this.idtxt.TabIndex = 7;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(248, 62);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(100, 22);
            this.nametxt.TabIndex = 8;
            // 
            // agetxt
            // 
            this.agetxt.Location = new System.Drawing.Point(248, 114);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(100, 22);
            this.agetxt.TabIndex = 9;
            // 
            // addrtxt
            // 
            this.addrtxt.Location = new System.Drawing.Point(248, 168);
            this.addrtxt.Name = "addrtxt";
            this.addrtxt.Size = new System.Drawing.Size(100, 22);
            this.addrtxt.TabIndex = 10;
            // 
            // saltxt
            // 
            this.saltxt.Location = new System.Drawing.Point(248, 229);
            this.saltxt.Name = "saltxt";
            this.saltxt.Size = new System.Drawing.Size(100, 22);
            this.saltxt.TabIndex = 11;
            // 
            // insertbtn
            // 
            this.insertbtn.Location = new System.Drawing.Point(541, 11);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(75, 23);
            this.insertbtn.TabIndex = 12;
            this.insertbtn.Text = "Insert";
            this.insertbtn.UseVisualStyleBackColor = true;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(541, 58);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 23);
            this.updatebtn.TabIndex = 13;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(541, 110);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 14;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // viewbtn
            // 
            this.viewbtn.Location = new System.Drawing.Point(541, 167);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(75, 23);
            this.viewbtn.TabIndex = 15;
            this.viewbtn.Text = "View All";
            this.viewbtn.UseVisualStyleBackColor = true;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 166);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.viewbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.saltxt);
            this.Controls.Add(this.addrtxt);
            this.Controls.Add(this.agetxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.TextBox addrtxt;
        private System.Windows.Forms.TextBox saltxt;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


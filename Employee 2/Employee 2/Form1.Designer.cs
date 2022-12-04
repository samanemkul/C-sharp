namespace Employee_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserAddr = new System.Windows.Forms.TextBox();
            this.txtUserSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
<<<<<<< HEAD
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
=======
            this.sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
>>>>>>> 29ee434e111fb84a2895b0370786968af530f9e7
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sn,
<<<<<<< HEAD
            this.ID,
            this.name,
            this.address,
            this.salary});
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(448, 216);
=======
            this.name,
            this.address,
            this.salary});
            this.dataGridView1.Location = new System.Drawing.Point(250, 143);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(651, 403);
>>>>>>> 29ee434e111fb84a2895b0370786968af530f9e7
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
<<<<<<< HEAD
            this.button1.Location = new System.Drawing.Point(12, 332);
=======
            this.button1.Location = new System.Drawing.Point(250, 555);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
>>>>>>> 29ee434e111fb84a2895b0370786968af530f9e7
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
<<<<<<< HEAD
            this.button2.Location = new System.Drawing.Point(93, 332);
=======
            this.button2.Location = new System.Drawing.Point(366, 555);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
>>>>>>> 29ee434e111fb84a2895b0370786968af530f9e7
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Display";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
<<<<<<< HEAD
            this.button3.Location = new System.Drawing.Point(174, 332);
=======
            this.button3.Location = new System.Drawing.Point(481, 555);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
>>>>>>> 29ee434e111fb84a2895b0370786968af530f9e7
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
<<<<<<< HEAD
            this.button4.Location = new System.Drawing.Point(255, 333);
=======
            this.button4.Location = new System.Drawing.Point(619, 557);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
>>>>>>> 29ee434e111fb84a2895b0370786968af530f9e7
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 38);
            this.button4.TabIndex = 4;
            this.button4.Text = "delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtUserName
            // 
<<<<<<< HEAD
            this.txtUserName.Location = new System.Drawing.Point(12, 70);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(145, 23);
=======
            this.txtUserName.Location = new System.Drawing.Point(250, 97);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(141, 31);
>>>>>>> 29ee434e111fb84a2895b0370786968af530f9e7
            this.txtUserName.TabIndex = 5;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // txtUserAddr
            // 
<<<<<<< HEAD
            this.txtUserAddr.Location = new System.Drawing.Point(163, 70);
            this.txtUserAddr.Name = "txtUserAddr";
            this.txtUserAddr.Size = new System.Drawing.Size(157, 23);
=======
            this.txtUserAddr.Location = new System.Drawing.Point(401, 95);
            this.txtUserAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserAddr.Name = "txtUserAddr";
            this.txtUserAddr.Size = new System.Drawing.Size(141, 31);
>>>>>>> 29ee434e111fb84a2895b0370786968af530f9e7
            this.txtUserAddr.TabIndex = 5;
            this.txtUserAddr.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtUserSalary
            // 
<<<<<<< HEAD
            this.txtUserSalary.Location = new System.Drawing.Point(326, 70);
            this.txtUserSalary.Name = "txtUserSalary";
            this.txtUserSalary.Size = new System.Drawing.Size(134, 23);
=======
            this.txtUserSalary.Location = new System.Drawing.Point(583, 97);
            this.txtUserSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserSalary.Name = "txtUserSalary";
            this.txtUserSalary.Size = new System.Drawing.Size(141, 31);
>>>>>>> 29ee434e111fb84a2895b0370786968af530f9e7
            this.txtUserSalary.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(12, 53);
=======
            this.label1.Location = new System.Drawing.Point(250, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
>>>>>>> 29ee434e111fb84a2895b0370786968af530f9e7
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
<<<<<<< HEAD
            this.label2.Location = new System.Drawing.Point(163, 52);
=======
            this.label2.Location = new System.Drawing.Point(419, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
>>>>>>> 29ee434e111fb84a2895b0370786968af530f9e7
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
<<<<<<< HEAD
            this.label3.Location = new System.Drawing.Point(326, 52);
=======
            this.label3.Location = new System.Drawing.Point(597, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
>>>>>>> 29ee434e111fb84a2895b0370786968af530f9e7
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Salary";
            // 
            // txtUserID
            // 
<<<<<<< HEAD
            this.txtUserID.Location = new System.Drawing.Point(12, 27);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(28, 23);
            this.txtUserID.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(336, 332);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID";
            // 
            // sn
            // 
            this.sn.HeaderText = "SN";
            this.sn.Name = "sn";
            this.sn.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
=======
            this.txtUserID.Location = new System.Drawing.Point(734, 555);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(141, 31);
            this.txtUserID.TabIndex = 9;
            // 
            // sn
            // 
            this.sn.HeaderText = "SN";
            this.sn.MinimumWidth = 8;
            this.sn.Name = "sn";
            this.sn.Width = 150;
>>>>>>> 29ee434e111fb84a2895b0370786968af530f9e7
            // 
            // name
            // 
            this.name.HeaderText = "Name";
<<<<<<< HEAD
            this.name.Name = "name";
            this.name.ReadOnly = true;
=======
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 150;
>>>>>>> 29ee434e111fb84a2895b0370786968af530f9e7
            // 
            // address
            // 
            this.address.HeaderText = "Address";
<<<<<<< HEAD
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // salary
            // 
            this.salary.HeaderText = "Salary";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
=======
            this.address.MinimumWidth = 8;
            this.address.Name = "address";
            this.address.Width = 150;
            // 
            // salary
            // 
            this.salary.HeaderText = "salary";
            this.salary.MinimumWidth = 8;
            this.salary.Name = "salary";
            this.salary.Width = 150;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(245, 601);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 34);
            this.button5.TabIndex = 10;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
>>>>>>> 29ee434e111fb84a2895b0370786968af530f9e7
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(800, 450);
=======
            this.ClientSize = new System.Drawing.Size(1143, 750);
>>>>>>> 29ee434e111fb84a2895b0370786968af530f9e7
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserSalary);
            this.Controls.Add(this.txtUserAddr);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox txtUserName;
        private TextBox txtUserAddr;
        private TextBox txtUserSalary;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUserID;
<<<<<<< HEAD
        private Button button5;
        private Label label4;
        private DataGridViewTextBoxColumn sn;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn salary;
=======
        private DataGridViewTextBoxColumn sn;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn salary;
        private Button button5;
>>>>>>> 29ee434e111fb84a2895b0370786968af530f9e7
    }
}
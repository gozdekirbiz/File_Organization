
namespace FileOrg
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKeys = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblBEISCHP = new System.Windows.Forms.Label();
            this.lblBinaryP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPack = new System.Windows.Forms.Label();
            this.lblFound = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblBEISCHindex = new System.Windows.Forms.Label();
            this.lblBinaryTreeindex = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "# of keys";
            // 
            // txtKeys
            // 
            this.txtKeys.Location = new System.Drawing.Point(205, 69);
            this.txtKeys.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKeys.Name = "txtKeys";
            this.txtKeys.Size = new System.Drawing.Size(207, 47);
            this.txtKeys.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(418, 69);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(224, 48);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create keys";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 67);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Put keys in the table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Thistle;
            this.listBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 41;
            this.listBox1.Location = new System.Drawing.Point(47, 184);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 783);
            this.listBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(999, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choosen prime number is:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1412, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 41);
            this.label3.TabIndex = 8;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1276, 987);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(275, 47);
            this.txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1566, 987);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 47);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(1228, 129);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(0, 41);
            this.lblSearch.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1563, 1071);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 41);
            this.label5.TabIndex = 14;
            this.label5.Text = "BEISCH";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1703, 1071);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 41);
            this.label6.TabIndex = 15;
            this.label6.Text = "Binary Tree";
            this.label6.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(275, 184);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.Size = new System.Drawing.Size(1048, 783);
            this.dataGridView1.TabIndex = 18;
            // 
            // lblBEISCHP
            // 
            this.lblBEISCHP.AutoSize = true;
            this.lblBEISCHP.BackColor = System.Drawing.Color.AliceBlue;
            this.lblBEISCHP.Location = new System.Drawing.Point(1579, 1166);
            this.lblBEISCHP.Name = "lblBEISCHP";
            this.lblBEISCHP.Size = new System.Drawing.Size(82, 41);
            this.lblBEISCHP.TabIndex = 19;
            this.lblBEISCHP.Text = "        ";
            this.lblBEISCHP.Visible = false;
            // 
            // lblBinaryP
            // 
            this.lblBinaryP.AutoSize = true;
            this.lblBinaryP.BackColor = System.Drawing.Color.AliceBlue;
            this.lblBinaryP.Location = new System.Drawing.Point(1746, 1166);
            this.lblBinaryP.Name = "lblBinaryP";
            this.lblBinaryP.Size = new System.Drawing.Size(82, 41);
            this.lblBinaryP.TabIndex = 20;
            this.lblBinaryP.Text = "        ";
            this.lblBinaryP.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(593, 987);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 41);
            this.label7.TabIndex = 21;
            this.label7.Text = "Average # of probes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(593, 1044);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 41);
            this.label8.TabIndex = 22;
            this.label8.Text = "BEISCH:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(593, 1105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 41);
            this.label9.TabIndex = 23;
            this.label9.Text = "Binary Tree:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.AliceBlue;
            this.label10.Location = new System.Drawing.Point(790, 1044);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 41);
            this.label10.TabIndex = 24;
            this.label10.Text = "          ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.AliceBlue;
            this.label11.Location = new System.Drawing.Point(790, 1105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 41);
            this.label11.TabIndex = 25;
            this.label11.Text = "          ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1094, 987);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 41);
            this.label4.TabIndex = 9;
            this.label4.Text = "Search for:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 987);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(213, 41);
            this.label12.TabIndex = 27;
            this.label12.Text = "Packing factor";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1648, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 41);
            this.label14.TabIndex = 29;
            this.label14.Text = "Binary Tree:";
            // 
            // lblPack
            // 
            this.lblPack.AutoSize = true;
            this.lblPack.BackColor = System.Drawing.Color.AliceBlue;
            this.lblPack.Location = new System.Drawing.Point(266, 987);
            this.lblPack.Name = "lblPack";
            this.lblPack.Size = new System.Drawing.Size(98, 41);
            this.lblPack.TabIndex = 30;
            this.lblPack.Text = "          ";
            // 
            // lblFound
            // 
            this.lblFound.AutoSize = true;
            this.lblFound.BackColor = System.Drawing.Color.AliceBlue;
            this.lblFound.Location = new System.Drawing.Point(1750, 993);
            this.lblFound.Name = "lblFound";
            this.lblFound.Size = new System.Drawing.Size(242, 41);
            this.lblFound.TabIndex = 32;
            this.lblFound.Text = "                            ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1258, 1166);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(280, 41);
            this.label18.TabIndex = 33;
            this.label18.Text = "# of probes to find:";
            this.label18.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1307, 1111);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(230, 41);
            this.label19.TabIndex = 34;
            this.label19.Text = "Found at index:";
            this.label19.Visible = false;
            // 
            // lblBEISCHindex
            // 
            this.lblBEISCHindex.AutoSize = true;
            this.lblBEISCHindex.BackColor = System.Drawing.Color.AliceBlue;
            this.lblBEISCHindex.Location = new System.Drawing.Point(1579, 1112);
            this.lblBEISCHindex.Name = "lblBEISCHindex";
            this.lblBEISCHindex.Size = new System.Drawing.Size(82, 41);
            this.lblBEISCHindex.TabIndex = 35;
            this.lblBEISCHindex.Text = "        ";
            this.lblBEISCHindex.Visible = false;
            // 
            // lblBinaryTreeindex
            // 
            this.lblBinaryTreeindex.AutoSize = true;
            this.lblBinaryTreeindex.BackColor = System.Drawing.Color.AliceBlue;
            this.lblBinaryTreeindex.Location = new System.Drawing.Point(1746, 1111);
            this.lblBinaryTreeindex.Name = "lblBinaryTreeindex";
            this.lblBinaryTreeindex.Size = new System.Drawing.Size(82, 41);
            this.lblBinaryTreeindex.TabIndex = 36;
            this.lblBinaryTreeindex.Text = "        ";
            this.lblBinaryTreeindex.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1365, 186);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 102;
            this.dataGridView2.Size = new System.Drawing.Size(732, 781);
            this.dataGridView2.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(697, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 41);
            this.label13.TabIndex = 28;
            this.label13.Text = "BEISCH:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(47, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 41);
            this.label15.TabIndex = 38;
            this.label15.Text = "KEYS:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(2151, 1247);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblBinaryTreeindex);
            this.Controls.Add(this.lblBEISCHindex);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblFound);
            this.Controls.Add(this.lblPack);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblBinaryP);
            this.Controls.Add(this.lblBEISCHP);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtKeys);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.SlateBlue;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeys;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblBEISCHP;
        private System.Windows.Forms.Label lblBinaryP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblFound;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblBEISCHindex;
        private System.Windows.Forms.Label lblBinaryTreeindex;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblPack;
    }
}


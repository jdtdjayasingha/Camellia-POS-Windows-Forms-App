﻿namespace CamelliaPOS
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            label10 = new Label();
            textBox3 = new TextBox();
            label9 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel7 = new Panel();
            label6 = new Label();
            panel6 = new Panel();
            label5 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            exitCategoriesButton = new Button();
            label8 = new Label();
            label7 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(771, 108);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 37;
            label10.Text = "Phone";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(771, 139);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 23);
            textBox3.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(569, 108);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 35;
            label9.Text = "Gender";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(569, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 23);
            textBox2.TabIndex = 36;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(353, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 768);
            panel1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(74, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Blue;
            panel7.Controls.Add(label6);
            panel7.Location = new Point(1, 408);
            panel7.Name = "panel7";
            panel7.Size = new Size(279, 56);
            panel7.TabIndex = 5;
            panel7.Click += pnlBilling_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(99, 21);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 0;
            label6.Text = "Billing";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Blue;
            panel6.Controls.Add(label5);
            panel6.Location = new Point(1, 341);
            panel6.Name = "panel6";
            panel6.Size = new Size(279, 56);
            panel6.TabIndex = 4;
            panel6.Click += pnlCustomers_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(99, 21);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 0;
            label5.Text = "Customers";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Blue;
            panel5.Controls.Add(label4);
            panel5.Location = new Point(0, 276);
            panel5.Name = "panel5";
            panel5.Size = new Size(279, 56);
            panel5.TabIndex = 3;
            panel5.Click += pnlCatogories_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 21);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 0;
            label4.Text = "Categories";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Blue;
            panel4.Controls.Add(label3);
            panel4.Location = new Point(0, 212);
            panel4.Name = "panel4";
            panel4.Size = new Size(279, 56);
            panel4.TabIndex = 2;
            panel4.Click += pnlItem_click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 21);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 0;
            label3.Text = "Items";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Blue;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 145);
            panel3.Name = "panel3";
            panel3.Size = new Size(279, 56);
            panel3.TabIndex = 1;
            panel3.Click += pnlDashboard_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 21);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 0;
            label2.Text = "Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 710);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 58);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 23);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Logout";
            // 
            // exitCategoriesButton
            // 
            exitCategoriesButton.Location = new Point(1317, 12);
            exitCategoriesButton.Name = "exitCategoriesButton";
            exitCategoriesButton.Size = new Size(37, 33);
            exitCategoriesButton.TabIndex = 34;
            exitCategoriesButton.Text = "X";
            exitCategoriesButton.UseVisualStyleBackColor = true;
            exitCategoriesButton.Click += btnExit_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(353, 108);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 32;
            label8.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(353, 32);
            label7.Name = "label7";
            label7.Size = new Size(138, 15);
            label7.TabIndex = 31;
            label7.Text = "Customers Management";
            // 
            // button3
            // 
            button3.Location = new Point(907, 228);
            button3.Name = "button3";
            button3.Size = new Size(75, 40);
            button3.TabIndex = 30;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(781, 228);
            button2.Name = "button2";
            button2.Size = new Size(75, 40);
            button2.TabIndex = 29;
            button2.Text = "Add Item";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(656, 228);
            button1.Name = "button1";
            button1.Size = new Size(75, 40);
            button1.TabIndex = 28;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(325, 304);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(867, 281);
            dataGridView1.TabIndex = 27;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1366, 768);
            Controls.Add(label10);
            Controls.Add(textBox3);
            Controls.Add(label9);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(exitCategoriesButton);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customers";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private TextBox textBox3;
        private Label label9;
        private TextBox textBox2;
        private TextBox textBox1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel7;
        private Label label6;
        private Panel panel6;
        private Label label5;
        private Panel panel5;
        private Label label4;
        private Panel panel4;
        private Label label3;
        private Panel panel3;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Button exitCategoriesButton;
        private Label label8;
        private Label label7;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
    }
}
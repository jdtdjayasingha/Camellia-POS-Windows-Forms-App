namespace CamelliaPOS
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            comboBox1 = new ComboBox();
            label12 = new Label();
            label10 = new Label();
            textBox3 = new TextBox();
            label9 = new Label();
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
            textBox5 = new TextBox();
            exitCategoriesButton = new Button();
            label8 = new Label();
            label7 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(563, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(159, 23);
            comboBox1.TabIndex = 43;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(310, 196);
            label12.Name = "label12";
            label12.Size = new Size(53, 15);
            label12.TabIndex = 41;
            label12.Text = "Quantity";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(563, 195);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 37;
            label10.Text = "Price";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(563, 226);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 23);
            textBox3.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(563, 108);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 36;
            label9.Text = "Categories";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(310, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 34;
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
            panel1.Size = new Size(279, 609);
            panel1.TabIndex = 27;
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
            panel5.Click += pnlCategories_Click;
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
            panel4.Click += pnlItems_Click;
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
            panel2.Location = new Point(0, 551);
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
            // textBox5
            // 
            textBox5.Location = new Point(310, 227);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(171, 23);
            textBox5.TabIndex = 42;
            // 
            // exitCategoriesButton
            // 
            exitCategoriesButton.Location = new Point(1134, 14);
            exitCategoriesButton.Name = "exitCategoriesButton";
            exitCategoriesButton.Size = new Size(37, 33);
            exitCategoriesButton.TabIndex = 35;
            exitCategoriesButton.Text = "X";
            exitCategoriesButton.UseVisualStyleBackColor = true;
            exitCategoriesButton.Click += btnExit_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(310, 108);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 33;
            label8.Text = "Items";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(347, 32);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 32;
            label7.Text = "Bill Management";
            // 
            // button3
            // 
            button3.Location = new Point(926, 524);
            button3.Name = "button3";
            button3.Size = new Size(75, 40);
            button3.TabIndex = 31;
            button3.Text = "Print Bill";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(392, 316);
            button2.Name = "button2";
            button2.Size = new Size(75, 40);
            button2.TabIndex = 30;
            button2.Text = "Add To Bill";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(502, 316);
            button1.Name = "button1";
            button1.Size = new Size(75, 40);
            button1.TabIndex = 29;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(807, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 88);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "Payment Mode";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(262, 35);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(62, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Mobile";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(155, 35);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Card";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(18, 35);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cash";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1198, 609);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(textBox3);
            Controls.Add(label9);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(textBox5);
            Controls.Add(exitCategoriesButton);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bill";
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label12;
        private Label label10;
        private TextBox textBox3;
        private Label label9;
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
        private TextBox textBox5;
        private Button exitCategoriesButton;
        private Label label8;
        private Label label7;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}
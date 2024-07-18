namespace CamelliaPOS
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            loginSidePanel = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Guna.UI2.WinForms.Guna2Button();
            exitLoginButton = new Guna.UI2.WinForms.Guna2Button();
            loginSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginSidePanel
            // 
            loginSidePanel.BackColor = SystemColors.MenuHighlight;
            loginSidePanel.Controls.Add(label4);
            loginSidePanel.Controls.Add(pictureBox1);
            loginSidePanel.Dock = DockStyle.Left;
            loginSidePanel.Location = new Point(0, 0);
            loginSidePanel.Name = "loginSidePanel";
            loginSidePanel.Size = new Size(300, 450);
            loginSidePanel.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Jokerman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 192, 255);
            label4.Location = new Point(40, 275);
            label4.Name = "label4";
            label4.Size = new Size(225, 51);
            label4.TabIndex = 1;
            label4.Text = "CAMELLIA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 20;
            guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(471, 41);
            label1.Name = "label1";
            label1.Size = new Size(155, 65);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(376, 133);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(375, 217);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // userNameTextBox
            // 
            userNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            userNameTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameTextBox.Location = new Point(382, 171);
            userNameTextBox.Margin = new Padding(5);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(338, 33);
            userNameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(382, 256);
            passwordTextBox.Margin = new Padding(5);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(338, 33);
            passwordTextBox.TabIndex = 5;
            // 
            // loginButton
            // 
            loginButton.BorderRadius = 15;
            loginButton.CustomizableEdges = customizableEdges3;
            loginButton.DisabledState.BorderColor = Color.DarkGray;
            loginButton.DisabledState.CustomBorderColor = Color.DarkGray;
            loginButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            loginButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            loginButton.FillColor = SystemColors.MenuHighlight;
            loginButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(577, 322);
            loginButton.Name = "loginButton";
            loginButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            loginButton.Size = new Size(143, 45);
            loginButton.TabIndex = 6;
            loginButton.Text = "Login";
            loginButton.Click += loginButton_Click;
            // 
            // exitLoginButton
            // 
            exitLoginButton.Anchor = AnchorStyles.None;
            exitLoginButton.BorderRadius = 5;
            exitLoginButton.CustomizableEdges = customizableEdges1;
            exitLoginButton.DisabledState.BorderColor = Color.DarkGray;
            exitLoginButton.DisabledState.CustomBorderColor = Color.DarkGray;
            exitLoginButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            exitLoginButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            exitLoginButton.FillColor = Color.Red;
            exitLoginButton.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitLoginButton.ForeColor = Color.White;
            exitLoginButton.Location = new Point(748, 12);
            exitLoginButton.Name = "exitLoginButton";
            exitLoginButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            exitLoginButton.Size = new Size(40, 30);
            exitLoginButton.TabIndex = 7;
            exitLoginButton.Text = "X";
            exitLoginButton.Click += exitLoginButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(exitLoginButton);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginSidePanel);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            loginSidePanel.ResumeLayout(false);
            loginSidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel loginSidePanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private PictureBox pictureBox1;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button loginButton;
        private Guna.UI2.WinForms.Guna2Button exitLoginButton;
    }
}
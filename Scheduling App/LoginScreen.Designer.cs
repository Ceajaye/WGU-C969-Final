
namespace Scheduling_App
{
    partial class LoginScreen
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
            this.LoginScreenLabel = new System.Windows.Forms.Label();
            this.UnameTextBox = new System.Windows.Forms.TextBox();
            this.PwdTextBox = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.UnameLabel = new System.Windows.Forms.Label();
            this.PwdLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginScreenLabel
            // 
            this.LoginScreenLabel.AutoSize = true;
            this.LoginScreenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginScreenLabel.Location = new System.Drawing.Point(272, 95);
            this.LoginScreenLabel.Name = "LoginScreenLabel";
            this.LoginScreenLabel.Size = new System.Drawing.Size(309, 31);
            this.LoginScreenLabel.TabIndex = 0;
            this.LoginScreenLabel.Text = "Everlast: Login Screen";
            this.LoginScreenLabel.Click += new System.EventHandler(this.LoginScreenLabel_Click);
            // 
            // UnameTextBox
            // 
            this.UnameTextBox.Location = new System.Drawing.Point(242, 188);
            this.UnameTextBox.Name = "UnameTextBox";
            this.UnameTextBox.Size = new System.Drawing.Size(381, 20);
            this.UnameTextBox.TabIndex = 1;
            this.UnameTextBox.TextChanged += new System.EventHandler(this.UnameTextBox_TextChanged);
            // 
            // PwdTextBox
            // 
            this.PwdTextBox.Location = new System.Drawing.Point(242, 266);
            this.PwdTextBox.Name = "PwdTextBox";
            this.PwdTextBox.Size = new System.Drawing.Size(381, 20);
            this.PwdTextBox.TabIndex = 1;
            this.PwdTextBox.TextChanged += new System.EventHandler(this.PwdTextBox_TextChanged);
            // 
            // LoginBtn
            // 
            this.LoginBtn.AllowDrop = true;
            this.LoginBtn.Location = new System.Drawing.Point(242, 319);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(548, 319);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // UnameLabel
            // 
            this.UnameLabel.AutoSize = true;
            this.UnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnameLabel.Location = new System.Drawing.Point(239, 168);
            this.UnameLabel.Name = "UnameLabel";
            this.UnameLabel.Size = new System.Drawing.Size(86, 17);
            this.UnameLabel.TabIndex = 4;
            this.UnameLabel.Text = "Username:";
            // 
            // PwdLabel
            // 
            this.PwdLabel.AutoSize = true;
            this.PwdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PwdLabel.Location = new System.Drawing.Point(239, 246);
            this.PwdLabel.Name = "PwdLabel";
            this.PwdLabel.Size = new System.Drawing.Size(82, 17);
            this.PwdLabel.TabIndex = 5;
            this.PwdLabel.Text = "Password:";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(389, 301);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(85, 13);
            this.ErrorLabel.TabIndex = 6;
            this.ErrorLabel.Text = "Login Error Alert!";
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 444);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.PwdLabel);
            this.Controls.Add(this.UnameLabel);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PwdTextBox);
            this.Controls.Add(this.UnameTextBox);
            this.Controls.Add(this.LoginScreenLabel);
            this.Name = "LoginScreen";
            this.Text = "LoginScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginScreenLabel;
        private System.Windows.Forms.TextBox UnameTextBox;
        private System.Windows.Forms.TextBox PwdTextBox;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label UnameLabel;
        private System.Windows.Forms.Label PwdLabel;
        private System.Windows.Forms.Label ErrorLabel;
    }
}


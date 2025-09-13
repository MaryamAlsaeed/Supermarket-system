namespace Supermarket__project
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.sign = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supermarket__project.Properties.Resources.Supermarket;
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(511, 162);
            this.Name1.Multiline = true;
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(204, 21);
            this.Name1.TabIndex = 10;
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.UserName.Location = new System.Drawing.Point(335, 156);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(193, 30);
            this.UserName.TabIndex = 9;
            this.UserName.Text = "User Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(399, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 88);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sign In Page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(353, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "password :";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(511, 221);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(204, 21);
            this.Password.TabIndex = 14;
            this.Password.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // sign
            // 
            this.sign.BackColor = System.Drawing.Color.SteelBlue;
            this.sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sign.Location = new System.Drawing.Point(445, 294);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(120, 48);
            this.sign.TabIndex = 15;
            this.sign.Text = "Login";
            this.sign.UseVisualStyleBackColor = false;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-161, -11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1122, 41);
            this.label3.TabIndex = 62;
            this.label3.Text = "                                             M and E Supermarket";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Label label3;
    }
}


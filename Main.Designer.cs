namespace Supermarket__project
{
    partial class Main
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
            this.Meat = new System.Windows.Forms.Button();
            this.Drinks = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Meat
            // 
            this.Meat.BackColor = System.Drawing.Color.SteelBlue;
            this.Meat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meat.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Meat.Location = new System.Drawing.Point(190, 277);
            this.Meat.Name = "Meat";
            this.Meat.Size = new System.Drawing.Size(120, 48);
            this.Meat.TabIndex = 0;
            this.Meat.Text = "Meat";
            this.Meat.UseVisualStyleBackColor = false;
            this.Meat.Click += new System.EventHandler(this.Meat_Click);
            // 
            // Drinks
            // 
            this.Drinks.BackColor = System.Drawing.Color.SteelBlue;
            this.Drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drinks.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Drinks.Location = new System.Drawing.Point(426, 277);
            this.Drinks.Name = "Drinks";
            this.Drinks.Size = new System.Drawing.Size(120, 48);
            this.Drinks.TabIndex = 1;
            this.Drinks.Text = "Drinks";
            this.Drinks.UseVisualStyleBackColor = false;
            this.Drinks.Click += new System.EventHandler(this.Drinks_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supermarket__project.Properties.Resources.photo_2025_05_04_03_10_52;
            this.pictureBox1.Location = new System.Drawing.Point(149, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Supermarket__project.Properties.Resources.photo_2025_05_06_00_12_16;
            this.pictureBox2.Location = new System.Drawing.Point(409, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-144, -9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1122, 41);
            this.label2.TabIndex = 61;
            this.label2.Text = "                                             M and E Supermarket";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(272, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 55);
            this.label1.TabIndex = 62;
            this.label1.Text = "Products";
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.Color.SteelBlue;
            this.list.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.list.Location = new System.Drawing.Point(706, 377);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(82, 44);
            this.list.TabIndex = 63;
            this.list.Text = "list";
            this.list.UseVisualStyleBackColor = false;
            this.list.Click += new System.EventHandler(this.list_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Drinks);
            this.Controls.Add(this.Meat);
            this.Name = "Main";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Meat;
        private System.Windows.Forms.Button Drinks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button list;
    }
}
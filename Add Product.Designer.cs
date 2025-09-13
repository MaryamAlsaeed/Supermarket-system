namespace Supermarket__project
{
    partial class AddProduct
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
            this.Price = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(143, 200);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(48, 20);
            this.Price.TabIndex = 2;
            this.Price.Text = "price";
            this.Price.Click += new System.EventHandler(this.Price_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(143, 69);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(28, 20);
            this.ID.TabIndex = 3;
            this.ID.Text = "ID";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(143, 133);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(55, 20);
            this.Name.TabIndex = 4;
            this.Name.Text = "Name";
            this.Name.Click += new System.EventHandler(this.Name_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(232, 71);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(304, 20);
            this.textBoxID.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(232, 135);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(304, 20);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(232, 200);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(304, 20);
            this.textBoxPrice.TabIndex = 7;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(251, 272);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(272, 49);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(-8, 33);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(49, 31);
            this.Back.TabIndex = 60;
            this.Back.Text = "←";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-156, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1122, 41);
            this.label2.TabIndex = 61;
            this.label2.Text = "                                             M and E Supermarket";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Price);
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label2;
    }
}
namespace Supermarket__project
{
    partial class List
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotal.Location = new System.Drawing.Point(111, 135);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(439, 23);
            this.lblTotal.TabIndex = 51;
            this.lblTotal.Text = "Total Price: 0.00";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductColumn,
            this.PriceColumn,
            this.AmountColumn,
            this.DeleteColumn});
            this.dataGridView1.Location = new System.Drawing.Point(111, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(439, 151);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // ProductColumn
            // 
            this.ProductColumn.HeaderText = "Product";
            this.ProductColumn.Name = "ProductColumn";
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.Name = "PriceColumn";
            // 
            // AmountColumn
            // 
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.Name = "AmountColumn";
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.Text = "Delete";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-182, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1122, 41);
            this.label2.TabIndex = 61;
            this.label2.Text = "                                             M and E Supermarket";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(0, 40);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(49, 31);
            this.Back.TabIndex = 62;
            this.Back.Text = "←";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataGridView1);
            this.Name = "List";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Back;
    }
}
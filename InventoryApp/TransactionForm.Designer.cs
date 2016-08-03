namespace InventoryApp
{
    partial class TransactionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nCustomerId = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nMovieId = new System.Windows.Forms.NumericUpDown();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nQty = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.nId = new System.Windows.Forms.NumericUpDown();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nCustomerId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMovieId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nId)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TransactionId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer";
            // 
            // nCustomerId
            // 
            this.nCustomerId.Location = new System.Drawing.Point(134, 73);
            this.nCustomerId.Name = "nCustomerId";
            this.nCustomerId.Size = new System.Drawing.Size(75, 20);
            this.nCustomerId.TabIndex = 3;
            this.nCustomerId.ValueChanged += new System.EventHandler(this.nCustomerId_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Movie";
            // 
            // nMovieId
            // 
            this.nMovieId.Location = new System.Drawing.Point(134, 112);
            this.nMovieId.Name = "nMovieId";
            this.nMovieId.Size = new System.Drawing.Size(75, 20);
            this.nMovieId.TabIndex = 5;
            this.nMovieId.ValueChanged += new System.EventHandler(this.nMovieId_ValueChanged);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustomerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCustomerName.Location = new System.Drawing.Point(234, 75);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(37, 13);
            this.lblCustomerName.TabIndex = 6;
            this.lblCustomerName.Text = "          ";
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.BackColor = System.Drawing.SystemColors.Control;
            this.lblMovieName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMovieName.Location = new System.Drawing.Point(234, 114);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(40, 13);
            this.lblMovieName.TabIndex = 7;
            this.lblMovieName.Text = "           ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrice.Location = new System.Drawing.Point(134, 145);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(28, 13);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "     $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity";
            // 
            // nQty
            // 
            this.nQty.Location = new System.Drawing.Point(134, 172);
            this.nQty.Name = "nQty";
            this.nQty.Size = new System.Drawing.Size(75, 20);
            this.nQty.TabIndex = 11;
            this.nQty.ValueChanged += new System.EventHandler(this.nQty_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tax";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.BackColor = System.Drawing.SystemColors.Control;
            this.lblTax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTax.Location = new System.Drawing.Point(134, 208);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(28, 13);
            this.lblTax.TabIndex = 13;
            this.lblTax.Text = "     $";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(134, 241);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(28, 13);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "     $";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(222, 452);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(387, 36);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(326, 449);
            this.listView.TabIndex = 17;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Customer Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Movie Name";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Qty";
            this.columnHeader4.Width = 30;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total";
            this.columnHeader5.Width = 70;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(47, 452);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // nId
            // 
            this.nId.Location = new System.Drawing.Point(134, 36);
            this.nId.Name = "nId";
            this.nId.Size = new System.Drawing.Size(75, 20);
            this.nId.TabIndex = 19;
            this.nId.ValueChanged += new System.EventHandler(this.nId_ValueChanged);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(249, 33);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(98, 23);
            this.btnNew.TabIndex = 20;
            this.btnNew.Text = "Set Unique ID";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 519);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.nId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nQty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.nMovieId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nCustomerId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TransactionForm";
            this.Text = "Create a New Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.nCustomerId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMovieId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nCustomerId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nMovieId;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.NumericUpDown nId;
        private System.Windows.Forms.Button btnNew;
    }
}
namespace InventoryApp
{
    partial class MovieForm
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
            this.panelMovie = new System.Windows.Forms.Panel();
            this.cbxRating = new System.Windows.Forms.NumericUpDown();
            this.tbDate1 = new System.Windows.Forms.DateTimePicker();
            this.gbLocation = new System.Windows.Forms.GroupBox();
            this.rbCanadian = new System.Windows.Forms.RadioButton();
            this.rbInternational = new System.Windows.Forms.RadioButton();
            this.nDuration = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxGenre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.nPrice = new System.Windows.Forms.NumericUpDown();
            this.nId = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxRating)).BeginInit();
            this.gbLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nId)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMovie
            // 
            this.panelMovie.Controls.Add(this.cbxRating);
            this.panelMovie.Controls.Add(this.tbDate1);
            this.panelMovie.Controls.Add(this.gbLocation);
            this.panelMovie.Controls.Add(this.nDuration);
            this.panelMovie.Controls.Add(this.label8);
            this.panelMovie.Controls.Add(this.label7);
            this.panelMovie.Controls.Add(this.label6);
            this.panelMovie.Controls.Add(this.cbxGenre);
            this.panelMovie.Controls.Add(this.label4);
            this.panelMovie.Controls.Add(this.tbNumber);
            this.panelMovie.Controls.Add(this.label3);
            this.panelMovie.Controls.Add(this.btnNew);
            this.panelMovie.Controls.Add(this.btnDelete);
            this.panelMovie.Controls.Add(this.nPrice);
            this.panelMovie.Controls.Add(this.nId);
            this.panelMovie.Controls.Add(this.label5);
            this.panelMovie.Controls.Add(this.label2);
            this.panelMovie.Controls.Add(this.label1);
            this.panelMovie.Controls.Add(this.tbName);
            this.panelMovie.Controls.Add(this.btnSave);
            this.panelMovie.Location = new System.Drawing.Point(12, 40);
            this.panelMovie.Name = "panelMovie";
            this.panelMovie.Size = new System.Drawing.Size(327, 483);
            this.panelMovie.TabIndex = 7;
            // 
            // cbxRating
            // 
            this.cbxRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRating.Location = new System.Drawing.Point(145, 337);
            this.cbxRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cbxRating.Name = "cbxRating";
            this.cbxRating.Size = new System.Drawing.Size(155, 20);
            this.cbxRating.TabIndex = 35;
            this.cbxRating.ValueChanged += new System.EventHandler(this.cbxRating_ValueChanged);
            // 
            // tbDate1
            // 
            this.tbDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbDate1.Location = new System.Drawing.Point(145, 202);
            this.tbDate1.Name = "tbDate1";
            this.tbDate1.Size = new System.Drawing.Size(154, 20);
            this.tbDate1.TabIndex = 34;
            this.tbDate1.ValueChanged += new System.EventHandler(this.tbDate1_ValueChanged);
            // 
            // gbLocation
            // 
            this.gbLocation.Controls.Add(this.rbCanadian);
            this.gbLocation.Controls.Add(this.rbInternational);
            this.gbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLocation.Location = new System.Drawing.Point(18, 241);
            this.gbLocation.Name = "gbLocation";
            this.gbLocation.Size = new System.Drawing.Size(243, 44);
            this.gbLocation.TabIndex = 33;
            this.gbLocation.TabStop = false;
            this.gbLocation.Text = "Location";
            // 
            // rbCanadian
            // 
            this.rbCanadian.AutoSize = true;
            this.rbCanadian.Location = new System.Drawing.Point(22, 22);
            this.rbCanadian.Name = "rbCanadian";
            this.rbCanadian.Size = new System.Drawing.Size(70, 17);
            this.rbCanadian.TabIndex = 8;
            this.rbCanadian.TabStop = true;
            this.rbCanadian.Text = "Canadian";
            this.rbCanadian.UseVisualStyleBackColor = true;
            this.rbCanadian.CheckedChanged += new System.EventHandler(this.rbCanadian_CheckedChanged);
            // 
            // rbInternational
            // 
            this.rbInternational.AutoSize = true;
            this.rbInternational.Location = new System.Drawing.Point(144, 22);
            this.rbInternational.Name = "rbInternational";
            this.rbInternational.Size = new System.Drawing.Size(83, 17);
            this.rbInternational.TabIndex = 9;
            this.rbInternational.TabStop = true;
            this.rbInternational.Text = "International";
            this.rbInternational.UseVisualStyleBackColor = true;
            this.rbInternational.CheckedChanged += new System.EventHandler(this.rbInternational_CheckedChanged);
            // 
            // nDuration
            // 
            this.nDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nDuration.Location = new System.Drawing.Point(145, 374);
            this.nDuration.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nDuration.Name = "nDuration";
            this.nDuration.Size = new System.Drawing.Size(155, 20);
            this.nDuration.TabIndex = 30;
            this.nDuration.ValueChanged += new System.EventHandler(this.nDuration_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Duration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Rating";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Genre";
            // 
            // cbxGenre
            // 
            this.cbxGenre.AutoCompleteCustomSource.AddRange(new string[] {
            "Action",
            "Biography",
            "Comedy",
            "Drama",
            "Educational",
            "History",
            "Horror",
            "Musical",
            "Mystery",
            "Romance",
            "Sci-Fi",
            "Thriller",
            "Western"});
            this.cbxGenre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxGenre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGenre.FormattingEnabled = true;
            this.cbxGenre.Items.AddRange(new object[] {
            "Action",
            "Biography",
            "Comedy",
            "Drama",
            "Educational",
            "History",
            "Horror",
            "Musical",
            "Mystery",
            "Romance",
            "Sci-Fi",
            "Thriller",
            "Western"});
            this.cbxGenre.Location = new System.Drawing.Point(145, 300);
            this.cbxGenre.MaxDropDownItems = 20;
            this.cbxGenre.MaxLength = 15;
            this.cbxGenre.Name = "cbxGenre";
            this.cbxGenre.Size = new System.Drawing.Size(154, 21);
            this.cbxGenre.TabIndex = 26;
            this.cbxGenre.TextChanged += new System.EventHandler(this.cbxGenre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Release Date";
            // 
            // tbNumber
            // 
            this.tbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumber.Location = new System.Drawing.Point(145, 163);
            this.tbNumber.MaxLength = 10;
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(154, 20);
            this.tbNumber.TabIndex = 24;
            this.tbNumber.TextChanged += new System.EventHandler(this.tbNumber_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "ISBN13 Number";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(212, 36);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(89, 23);
            this.btnNew.TabIndex = 21;
            this.btnNew.Text = "Set Unique ID";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(27, 447);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // nPrice
            // 
            this.nPrice.Location = new System.Drawing.Point(145, 118);
            this.nPrice.Name = "nPrice";
            this.nPrice.Size = new System.Drawing.Size(100, 20);
            this.nPrice.TabIndex = 14;
            this.nPrice.ValueChanged += new System.EventHandler(this.nPrice_ValueChanged);
            // 
            // nId
            // 
            this.nId.Location = new System.Drawing.Point(145, 36);
            this.nId.Name = "nId";
            this.nId.Size = new System.Drawing.Size(61, 20);
            this.nId.TabIndex = 13;
            this.nId.ValueChanged += new System.EventHandler(this.nId_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Movie Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Movie ID";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(145, 80);
            this.tbName.MaxLength = 20;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(155, 20);
            this.tbName.TabIndex = 8;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(226, 447);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(382, 40);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(220, 466);
            this.listView.TabIndex = 8;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.lvMovies_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 160;
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 522);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.panelMovie);
            this.Name = "MovieForm";
            this.Text = "MovieForm";
            this.panelMovie.ResumeLayout(false);
            this.panelMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxRating)).EndInit();
            this.gbLocation.ResumeLayout(false);
            this.gbLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMovie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nPrice;
        private System.Windows.Forms.NumericUpDown nId;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.NumericUpDown cbxRating;
        private System.Windows.Forms.DateTimePicker tbDate1;
        private System.Windows.Forms.GroupBox gbLocation;
        private System.Windows.Forms.RadioButton rbCanadian;
        private System.Windows.Forms.RadioButton rbInternational;
        private System.Windows.Forms.NumericUpDown nDuration;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxGenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label3;
    }
}
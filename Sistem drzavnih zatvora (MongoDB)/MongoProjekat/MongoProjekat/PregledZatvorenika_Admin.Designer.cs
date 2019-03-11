namespace MongoProjekat
{
    partial class PregledZatvorenika_Admin
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
            this.btnDodajZatvorenika = new System.Windows.Forms.Button();
            this.btnPregledajRadnike = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewZatvorenici = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodajZatvorenika
            // 
            this.btnDodajZatvorenika.Location = new System.Drawing.Point(19, 388);
            this.btnDodajZatvorenika.Name = "btnDodajZatvorenika";
            this.btnDodajZatvorenika.Size = new System.Drawing.Size(96, 52);
            this.btnDodajZatvorenika.TabIndex = 0;
            this.btnDodajZatvorenika.Text = "Dodaj zatvorenika";
            this.btnDodajZatvorenika.UseVisualStyleBackColor = true;
            this.btnDodajZatvorenika.Click += new System.EventHandler(this.btnDodajZatvorenika_Click);
            // 
            // btnPregledajRadnike
            // 
            this.btnPregledajRadnike.Location = new System.Drawing.Point(167, 388);
            this.btnPregledajRadnike.Name = "btnPregledajRadnike";
            this.btnPregledajRadnike.Size = new System.Drawing.Size(96, 50);
            this.btnPregledajRadnike.TabIndex = 1;
            this.btnPregledajRadnike.Text = "Pregledaj radnike";
            this.btnPregledajRadnike.UseVisualStyleBackColor = true;
            this.btnPregledajRadnike.Click += new System.EventHandler(this.btnPregledajRadnike_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(322, 388);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(99, 50);
            this.btnOtkazi.TabIndex = 2;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewZatvorenici);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 354);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zatvorenici";
            // 
            // listViewZatvorenici
            // 
            this.listViewZatvorenici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewZatvorenici.FullRowSelect = true;
            this.listViewZatvorenici.Location = new System.Drawing.Point(6, 29);
            this.listViewZatvorenici.Name = "listViewZatvorenici";
            this.listViewZatvorenici.Size = new System.Drawing.Size(402, 319);
            this.listViewZatvorenici.TabIndex = 0;
            this.listViewZatvorenici.UseCompatibleStateImageBehavior = false;
            this.listViewZatvorenici.View = System.Windows.Forms.View.Details;
            this.listViewZatvorenici.DoubleClick += new System.EventHandler(this.listViewZatvorenici_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Datum ulaska";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // PregledZatvorenika_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnPregledajRadnike);
            this.Controls.Add(this.btnDodajZatvorenika);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PregledZatvorenika_Admin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PregledZatvorenika_Admin_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajZatvorenika;
        private System.Windows.Forms.Button btnPregledajRadnike;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewZatvorenici;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
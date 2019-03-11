namespace MongoProjekat
{
    partial class FormZatvorenik
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
            this.buttonOtkazi = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDodajDelo = new System.Windows.Forms.Button();
            this.buttonPrikaziDelo = new System.Windows.Forms.Button();
            this.textBoxBrojCelije = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewKrivicnaDela = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePickerIzlazak = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerUlazak = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRodjenje = new System.Windows.Forms.DateTimePicker();
            this.textBoxJMBG = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOtkazi
            // 
            this.buttonOtkazi.Location = new System.Drawing.Point(310, 531);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(136, 23);
            this.buttonOtkazi.TabIndex = 45;
            this.buttonOtkazi.Text = "Otkazi";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            this.buttonOtkazi.Click += new System.EventHandler(this.buttonOtkazi_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(127, 531);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(143, 23);
            this.buttonSave.TabIndex = 44;
            this.buttonSave.Text = "OK";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDodajDelo
            // 
            this.buttonDodajDelo.Location = new System.Drawing.Point(669, 348);
            this.buttonDodajDelo.Name = "buttonDodajDelo";
            this.buttonDodajDelo.Size = new System.Drawing.Size(181, 23);
            this.buttonDodajDelo.TabIndex = 43;
            this.buttonDodajDelo.Text = "Dodaj krivicno delo";
            this.buttonDodajDelo.UseVisualStyleBackColor = true;
            this.buttonDodajDelo.Click += new System.EventHandler(this.buttonDodajDelo_Click);
            // 
            // buttonPrikaziDelo
            // 
            this.buttonPrikaziDelo.Location = new System.Drawing.Point(669, 303);
            this.buttonPrikaziDelo.Name = "buttonPrikaziDelo";
            this.buttonPrikaziDelo.Size = new System.Drawing.Size(181, 23);
            this.buttonPrikaziDelo.TabIndex = 42;
            this.buttonPrikaziDelo.Text = "Prikazi krivicno delo";
            this.buttonPrikaziDelo.UseVisualStyleBackColor = true;
            this.buttonPrikaziDelo.Click += new System.EventHandler(this.buttonPrikaziDelo_Click);
            // 
            // textBoxBrojCelije
            // 
            this.textBoxBrojCelije.Location = new System.Drawing.Point(127, 50);
            this.textBoxBrojCelije.Name = "textBoxBrojCelije";
            this.textBoxBrojCelije.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrojCelije.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "ID celije:";
            // 
            // listViewKrivicnaDela
            // 
            this.listViewKrivicnaDela.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewKrivicnaDela.FullRowSelect = true;
            this.listViewKrivicnaDela.Location = new System.Drawing.Point(127, 303);
            this.listViewKrivicnaDela.Name = "listViewKrivicnaDela";
            this.listViewKrivicnaDela.Size = new System.Drawing.Size(506, 181);
            this.listViewKrivicnaDela.TabIndex = 39;
            this.listViewKrivicnaDela.UseCompatibleStateImageBehavior = false;
            this.listViewKrivicnaDela.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 184;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv krivicnog dela";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 228;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Broj dana";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 90;
            // 
            // dateTimePickerIzlazak
            // 
            this.dateTimePickerIzlazak.Location = new System.Drawing.Point(127, 261);
            this.dateTimePickerIzlazak.Name = "dateTimePickerIzlazak";
            this.dateTimePickerIzlazak.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerIzlazak.TabIndex = 38;
            // 
            // dateTimePickerUlazak
            // 
            this.dateTimePickerUlazak.Location = new System.Drawing.Point(127, 223);
            this.dateTimePickerUlazak.Name = "dateTimePickerUlazak";
            this.dateTimePickerUlazak.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerUlazak.TabIndex = 37;
            // 
            // dateTimePickerRodjenje
            // 
            this.dateTimePickerRodjenje.Location = new System.Drawing.Point(127, 188);
            this.dateTimePickerRodjenje.Name = "dateTimePickerRodjenje";
            this.dateTimePickerRodjenje.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerRodjenje.TabIndex = 36;
            // 
            // textBoxJMBG
            // 
            this.textBoxJMBG.Location = new System.Drawing.Point(127, 154);
            this.textBoxJMBG.Name = "textBoxJMBG";
            this.textBoxJMBG.Size = new System.Drawing.Size(100, 20);
            this.textBoxJMBG.TabIndex = 35;
            this.textBoxJMBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxJMBG_KeyPress);
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(127, 116);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrezime.TabIndex = 34;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(127, 81);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(100, 20);
            this.textBoxIme.TabIndex = 33;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(127, 13);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Krivicna dela:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Datum izlaska:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Datum ulaska:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Datum rodjenja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "JMBG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID:";
            // 
            // FormZatvorenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 562);
            this.Controls.Add(this.buttonOtkazi);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDodajDelo);
            this.Controls.Add(this.buttonPrikaziDelo);
            this.Controls.Add(this.textBoxBrojCelije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewKrivicnaDela);
            this.Controls.Add(this.dateTimePickerIzlazak);
            this.Controls.Add(this.dateTimePickerUlazak);
            this.Controls.Add(this.dateTimePickerRodjenje);
            this.Controls.Add(this.textBoxJMBG);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(886, 601);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(886, 601);
            this.Name = "FormZatvorenik";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormZatvorenik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOtkazi;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDodajDelo;
        private System.Windows.Forms.Button buttonPrikaziDelo;
        private System.Windows.Forms.TextBox textBoxBrojCelije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewKrivicnaDela;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.DateTimePicker dateTimePickerIzlazak;
        private System.Windows.Forms.DateTimePicker dateTimePickerUlazak;
        private System.Windows.Forms.DateTimePicker dateTimePickerRodjenje;
        private System.Windows.Forms.TextBox textBoxJMBG;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
namespace MongoProjekat
{
    partial class FormKrivicnoDelo
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDatumPresude = new System.Windows.Forms.DateTimePicker();
            this.textBoxOpisDela = new System.Windows.Forms.TextBox();
            this.textBoxBrojDana = new System.Windows.Forms.TextBox();
            this.textBoxNazivDela = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOtkazi
            // 
            this.buttonOtkazi.Location = new System.Drawing.Point(393, 335);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(136, 23);
            this.buttonOtkazi.TabIndex = 53;
            this.buttonOtkazi.Text = "Otkazi";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            this.buttonOtkazi.Click += new System.EventHandler(this.buttonOtkazi_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(160, 335);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(143, 23);
            this.buttonSave.TabIndex = 52;
            this.buttonSave.Text = "OK";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(160, 17);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "ID:";
            // 
            // dateTimePickerDatumPresude
            // 
            this.dateTimePickerDatumPresude.Location = new System.Drawing.Point(160, 123);
            this.dateTimePickerDatumPresude.Name = "dateTimePickerDatumPresude";
            this.dateTimePickerDatumPresude.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDatumPresude.TabIndex = 49;
            // 
            // textBoxOpisDela
            // 
            this.textBoxOpisDela.Location = new System.Drawing.Point(160, 183);
            this.textBoxOpisDela.Multiline = true;
            this.textBoxOpisDela.Name = "textBoxOpisDela";
            this.textBoxOpisDela.Size = new System.Drawing.Size(369, 105);
            this.textBoxOpisDela.TabIndex = 48;
            // 
            // textBoxBrojDana
            // 
            this.textBoxBrojDana.Location = new System.Drawing.Point(160, 83);
            this.textBoxBrojDana.Name = "textBoxBrojDana";
            this.textBoxBrojDana.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrojDana.TabIndex = 47;
            this.textBoxBrojDana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBrojDana_KeyPress);
            // 
            // textBoxNazivDela
            // 
            this.textBoxNazivDela.Location = new System.Drawing.Point(160, 48);
            this.textBoxNazivDela.Name = "textBoxNazivDela";
            this.textBoxNazivDela.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazivDela.TabIndex = 46;
            this.textBoxNazivDela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNazivDela_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Datum presude:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Opis krivicnog dela:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Broj dana:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Naziv krivicnog dela:";
            // 
            // FormKrivicnoDelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 396);
            this.Controls.Add(this.buttonOtkazi);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerDatumPresude);
            this.Controls.Add(this.textBoxOpisDela);
            this.Controls.Add(this.textBoxBrojDana);
            this.Controls.Add(this.textBoxNazivDela);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(621, 435);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(621, 435);
            this.Name = "FormKrivicnoDelo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormKrivicnoDelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOtkazi;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumPresude;
        private System.Windows.Forms.TextBox textBoxOpisDela;
        private System.Windows.Forms.TextBox textBoxBrojDana;
        private System.Windows.Forms.TextBox textBoxNazivDela;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
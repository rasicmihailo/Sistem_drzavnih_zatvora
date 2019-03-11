using MongoProjekat.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoProjekat
{
    public partial class FormKrivicnoDelo : Form
    {
        #region Atributi

        public int Tip; //0-dodavanje novog, 1-prikaz

        public KrivicnaDela Delo;

        #endregion

        #region Konstruktori

        public FormKrivicnoDelo()
        {
            InitializeComponent();
        }

        #endregion

        #region Metode
        private void RetrieveInfo(KrivicnaDela d)
        {
            textBoxId.Text = d.Id.ToString();
            textBoxNazivDela.Text = d.NazivDela;
            textBoxBrojDana.Text = d.BrojDana.ToString();
            textBoxOpisDela.Text = d.OpisDela;
            dateTimePickerDatumPresude.Text = d.DatumOsudjivanja;
        }
        public bool validacija()
        {
            if (String.IsNullOrEmpty(textBoxNazivDela.Text))
            {
                MessageBox.Show("Unesite naziv krivicnog dela!");
                textBoxNazivDela.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(textBoxBrojDana.Text))
            {
                MessageBox.Show("Unesite duzinu kazne!");
                textBoxBrojDana.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(textBoxOpisDela.Text))
            {
                MessageBox.Show("Unesite opis krivicnog dela!");
                textBoxOpisDela.Focus();
                return false;
            }

            return true;
        }

        #endregion

        #region Events

        private void buttonSave_Click(object sender, EventArgs e)
        {            
            if (Tip == 0)//dodaj
            {
                if (validacija())
                {
                    Delo = new KrivicnaDela();
                    Delo.NazivDela = textBoxNazivDela.Text;
                    Delo.OpisDela = textBoxOpisDela.Text;
                    Delo.BrojDana = Int32.Parse(textBoxBrojDana.Text);

                    DateTime dateTime1 = dateTimePickerDatumPresude.Value;
                    String dan1 = dateTime1.Day.ToString();
                    String mesec1 = dateTime1.Month.ToString();
                    String godina1 = dateTime1.Year.ToString();
                    String datumPresude = mesec1 + "." + dan1 + "." + godina1;
                    Delo.DatumOsudjivanja = datumPresude;

                    this.Close();
                    DialogResult = DialogResult.OK;
                }
            }
            if(Tip==1)
            {
                this.Close();
                DialogResult = DialogResult.No;
            }
        }
        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormKrivicnoDelo_Load(object sender, EventArgs e)
        {
            textBoxId.Enabled = false;

            if (Tip == 0)//dodaj novo krivicno delo
            {

            }
            else if (Tip == 1)//prikaz
            {
                this.RetrieveInfo(Delo);

                textBoxNazivDela.Enabled = false;
                textBoxBrojDana.Enabled = false;
                textBoxOpisDela.Enabled = false;
                dateTimePickerDatumPresude.Enabled = false;
            }
        }
        private void textBoxNazivDela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBoxBrojDana_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

    }
}

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
    public partial class FormZatvorenik : Form
    {
        #region Atributi

        public int Tip; //0-dodavanje novog, 1-azuriraj
        public Radnik Admin;
        public Zatvorenik Lopov;
        public List<KrivicnaDela> Dela = new List<KrivicnaDela>();

        #endregion

        #region Konstruktori

        public FormZatvorenik()
        {
            InitializeComponent();
        }

        #endregion

        #region Metode

        private void RetrieveInfo(Zatvorenik z)
        {

            textBoxID.Text = Lopov.Id.ToString();
            textBoxIme.Text = Lopov.Ime;
            textBoxPrezime.Text = Lopov.Prezime;
            textBoxJMBG.Text = Lopov.JMBG;
            textBoxBrojCelije.Text = Lopov.CelijaID;

            dateTimePickerUlazak.Text = Lopov.DatumUlaska;
            dateTimePickerRodjenje.Text = Lopov.DatumRodjenja;
            dateTimePickerIzlazak.Text = Lopov.DatumIzlaska;
        }
        private void PrikaziSvaKrivicnaDela(Zatvorenik z)
        {
            Dela = DataManager.GetDela(z);

            foreach (var delo in Dela)
            {
                try
                {
                    ListViewItem item = new ListViewItem(new string[] { delo.Id.ToString(), delo.NazivDela, delo.BrojDana.ToString() });
                    listViewKrivicnaDela.Items.Add(item);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
            listViewKrivicnaDela.Refresh();
        }
        private String IzracunajDatumIzlaska()
        {
            int brojDana = 0;
            foreach (ListViewItem lvi in listViewKrivicnaDela.Items)
            {
                int pom = Int32.Parse(lvi.SubItems[2].Text);
                brojDana += pom;
            }
            DateTime ulaz = dateTimePickerUlazak.Value;
            DateTime izlaz = ulaz.AddDays(brojDana);

            String dan = izlaz.Day.ToString();
            String mesec = izlaz.Month.ToString();
            String godina = izlaz.Year.ToString();
            String datumIzlaska = mesec + "." + dan + "." + godina;            

            return datumIzlaska;
        }
        public bool validacija()
        {
            if (String.IsNullOrEmpty(textBoxIme.Text))
            {
                MessageBox.Show("Unesite ime zatvorenika!");
                textBoxIme.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(textBoxPrezime.Text))
            {
                MessageBox.Show("Unesite prezime zatvorenika!");
                textBoxPrezime.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(textBoxJMBG.Text))
            {
                MessageBox.Show("Unesite JMBG zatvorenika!");
                textBoxJMBG.Focus();
                return false;
            }
            if (listViewKrivicnaDela.Items.Count == 0)
            {
                MessageBox.Show("Morate uneti bar jednu kaznu!");
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
                    DateTime dateTime = dateTimePickerRodjenje.Value;
                    String dan = dateTime.Day.ToString();
                    String mesec = dateTime.Month.ToString();
                    String godina = dateTime.Year.ToString();
                    String datumRodjenja = mesec + "." + dan + "." + godina;

                    DateTime dateTime1 = dateTimePickerUlazak.Value;
                    String dan1 = dateTime1.Day.ToString();
                    String mesec1 = dateTime1.Month.ToString();
                    String godina1 = dateTime1.Year.ToString();
                    String datumUlaska = mesec1 + "." + dan1 + "." + godina1;

                    String datumIzlaska = IzracunajDatumIzlaska();
                    String celijaID = DataManager.VratiSlobodnuCeliju(Admin.ZatvorID);
                    DataManager.AzurirajBrojPopunjenostiCelije(celijaID);

                    DataManager.AddZatvorenik(new Zatvorenik
                    {
                        Ime = textBoxIme.Text,
                        Prezime = textBoxPrezime.Text,
                        JMBG = textBoxJMBG.Text,
                        DatumRodjenja = datumRodjenja,
                        DatumUlaska = datumUlaska,
                        DatumIzlaska = datumIzlaska,
                        ZatvorID = Admin.ZatvorID,
                        CelijaID = celijaID
                    });
                    if (Lopov == null)
                    {
                        Zatvorenik z = DataManager.GetZatvorenik(textBoxJMBG.Text);
                        foreach (KrivicnaDela k in this.Dela)
                        {
                            k.ZatvorenikID = z.Id.ToString();
                        }
                    }
                    DataManager.AddDela(Dela);
                    this.Close();
                    DialogResult = DialogResult.OK;
                }
            }
            else if (Tip == 1)//azuriraj
            {
                DataManager.DeleteDela(Lopov);
                DataManager.AddDela(Dela);
                this.Close();
                DialogResult = DialogResult.OK;
            }

            
        }

        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPrikaziDelo_Click(object sender, EventArgs e)
        {
            if (listViewKrivicnaDela.SelectedItems.Count == 0)
            {
                return;
            }
            String id = listViewKrivicnaDela.SelectedItems[0].SubItems[0].Text;
            KrivicnaDela kd = DataManager.GetDelo(id);



            FormKrivicnoDelo f = new FormKrivicnoDelo();

            f.Tip = 1;
            f.Delo = kd;


            f.Show();
        }

        private void buttonDodajDelo_Click(object sender, EventArgs e)
        {
            FormKrivicnoDelo f = new FormKrivicnoDelo();

            f.Tip = 0;

            if (f.ShowDialog() == DialogResult.OK)
            {
                if (Lopov != null)
                {
                    f.Delo.ZatvorenikID = Lopov.Id.ToString();
                }
                Dela.Add(f.Delo);
                ListViewItem item = new ListViewItem(new string[] { f.Delo.Id.ToString(), f.Delo.NazivDela, f.Delo.BrojDana.ToString() });
                listViewKrivicnaDela.Items.Add(item);
                listViewKrivicnaDela.Refresh();
                dateTimePickerIzlazak.Text = this.IzracunajDatumIzlaska();
            }
        }

        private void FormZatvorenik_Load(object sender, EventArgs e)
        {
            textBoxID.Enabled = false;
            dateTimePickerIzlazak.Enabled = false;
            textBoxBrojCelije.Enabled = false;

            if (Tip == 0)//dodaj novog zatvorenika
            {

            }
            else if (Tip == 1)//azuriraj
            {
                this.RetrieveInfo(Lopov);
                this.PrikaziSvaKrivicnaDela(Lopov);

                textBoxIme.Enabled = false;
                textBoxPrezime.Enabled = false;
                textBoxJMBG.Enabled = false;
                dateTimePickerUlazak.Enabled = false;
                dateTimePickerRodjenje.Enabled = false;
            }
        }

        private void textBoxJMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion


    }
}

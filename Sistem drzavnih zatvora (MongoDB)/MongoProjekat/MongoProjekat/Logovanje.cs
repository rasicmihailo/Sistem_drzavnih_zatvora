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
    public partial class Logovanje : Form
    {
        #region Atributi 

        Radnik radnik;

        #endregion

        #region Konstruktori

        public Logovanje()
        {
            InitializeComponent();
        }

        #endregion

        #region Metode

        public bool validacija()
        {
            if(this.radnik == null)
            {
                MessageBox.Show("Ne postoji takav radnik!");
                return false;
            }
            if (String.IsNullOrEmpty(txtKorisnicko.Text))
            {
                MessageBox.Show("Unesite korisnicko ime!");
                txtKorisnicko.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtSifra.Text))
            {
                MessageBox.Show("Unesite sifru!");
                txtSifra.Focus();
                return false;
            }
            return true;
        }

        #endregion

        #region Events
        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPrijavi_Click(object sender, EventArgs e)
        {
            radnik = DataManager.PrijaviRadnika(txtKorisnicko.Text, txtSifra.Text);

            if (validacija())
            {               
                if (radnik.Tip == 0) //strazar 
                {
                    PregledZatvorenika_Strazar p = new PregledZatvorenika_Strazar();
                    p.Tmp = 0;
                    p.Radnik = this.radnik;
                    p.ShowDialog();
                }
                else if(radnik.Tip == 1) //admin
                {
                    PregledZatvorenika_Admin p = new PregledZatvorenika_Admin();                    
                    p.Radnik = this.radnik;
                    p.ShowDialog();
                }
            }
        }
        private void Logovanje_Load(object sender, EventArgs e)
        {

        }
                  
        #endregion
    }
}

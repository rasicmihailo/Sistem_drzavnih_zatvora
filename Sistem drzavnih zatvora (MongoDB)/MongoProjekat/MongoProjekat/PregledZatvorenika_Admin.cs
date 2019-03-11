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
    public partial class PregledZatvorenika_Admin : Form
    {
        #region Atributi

        public Radnik Radnik { get; set; }
        public Zatvorenik Zatvorenik { get; set; }

        #endregion

        #region Konstruktori

        public PregledZatvorenika_Admin()
        {
            InitializeComponent();
        }


        #endregion

        #region Metode

        public void popuniListu()
        {
            listViewZatvorenici.Items.Clear();

            foreach (Zatvorenik z in DataManager.VratiSveZatvorenike(Radnik.ZatvorID))
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                        z.Id.ToString(),
                        z.Ime,
                        z.Prezime,
                        z.DatumUlaska
                });
                    listViewZatvorenici.Items.Add(item);
            }
                listViewZatvorenici.Refresh();
        }

        #endregion

        #region Events

        private void btnDodajZatvorenika_Click(object sender, EventArgs e)
        {
            FormZatvorenik f = new FormZatvorenik();
            f.Tip = 0;
            f.Admin = this.Radnik;
            if(DialogResult.OK == f.ShowDialog())
            {
                this.popuniListu();
            }
        }

        private void btnPregledajRadnike_Click(object sender, EventArgs e)
        {
            PregledRadnika pregledRadnika = new PregledRadnika();
            pregledRadnika.Admin = this.Radnik;
            pregledRadnika.ShowDialog();
        }
        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PregledZatvorenika_Admin_Load(object sender, EventArgs e)
        {
            this.popuniListu();
        }
        private void listViewZatvorenici_DoubleClick(object sender, EventArgs e)
        {
            Zatvorenik = DataManager.VratiZatvorenika(listViewZatvorenici.SelectedItems[0].SubItems[0].Text);
            FormZatvorenik f = new FormZatvorenik();
            f.Tip = 1;
            f.Admin = this.Radnik;
            f.Lopov = this.Zatvorenik;
            if (DialogResult.OK == f.ShowDialog())
            {
                this.popuniListu();
            }
        }

        #endregion


    }
}

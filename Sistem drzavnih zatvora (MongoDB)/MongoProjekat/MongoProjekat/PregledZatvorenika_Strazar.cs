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
    public partial class PregledZatvorenika_Strazar : Form
    {
        #region Atributi

        public Radnik Radnik { get; set; }
        public int Tmp { get; set; }
        #endregion    

        #region Konstruktori

        public PregledZatvorenika_Strazar()
        {
            InitializeComponent();
        }


        #endregion

        #region Metode

        public void popuniListu()
        {
            listViewStrazari.Items.Clear();

            //za svaki blok se trazi lista zatvorenika u tom bloku
            for(int i=0; i<Radnik.Blokovi.Count; i++)
            {
                //ispis zatvorenika u listView
                foreach (Zatvorenik z in DataManager.VratiZatvorenikePoBloku(Radnik.Blokovi[i], Radnik.ZatvorID))
                {
                    Celija c = DataManager.VratiCeliju(z.CelijaID);
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        z.Id.ToString(),
                        z.Ime,
                        z.Prezime,
                        c.Broj.ToString(),
                        c.Blok
                    });
                    listViewStrazari.Items.Add(item);
                }
            }
            listViewStrazari.Refresh();
        }

        #endregion

        #region Events

        private void PregledZatvorenika_Strazar_Load(object sender, EventArgs e)
        {            
            txtSmena.Text = Radnik.Smena;
            String b = "";
            for (int i = 0; i < Radnik.Blokovi.Count; i++)
            {
                b += Radnik.Blokovi[i] + " ";
            }
            txtBlokovi.Text = b;

            this.popuniListu();

            if (Tmp == 1) //usao je admin, moze da podesi smenu i blokove
            {
                txtSmena.ReadOnly = false;
                txtSmena.Enabled = true;
            }

        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Tmp == 1)
            {
                DataManager.AzurirajSmenu(Radnik, txtSmena.Text);
            }

            txtSmena.ReadOnly = true;
            txtSmena.Enabled = false;
            this.Close();                    
        }

        #endregion
    }
}

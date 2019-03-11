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
    public partial class PregledRadnika : Form
    {
        #region Atributi
        public Radnik Admin { get; set; }
        
        #endregion

        #region Konstruktori

        public PregledRadnika()
        {
            InitializeComponent();
        }

        #endregion

        #region Metode

        public void popuniListu()
        {
            listViewStrazari.Items.Clear();

            foreach (Radnik r in DataManager.PregledajRadnike(Admin.ZatvorID))
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                        r.Id.ToString(),
                        r.Ime,
                        r.Prezime,
                        r.Smena
                });
                listViewStrazari.Items.Add(item);
            }
            listViewStrazari.Refresh();
        }

        #endregion

        #region Events

        private void btnPromeni_Click(object sender, EventArgs e)
        {
            Radnik r = DataManager.VratiRadnika(listViewStrazari.SelectedItems[0].SubItems[0].Text);

            PregledZatvorenika_Strazar p = new PregledZatvorenika_Strazar();
            p.Radnik = r;
            p.Tmp = 1;
            p.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PregledRadnika_Load(object sender, EventArgs e)
        {
            this.popuniListu();
        }



        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autokululaskuri
{
    public partial class KustannusForm : Form
    {
        public KustannusForm()
        {
            InitializeComponent();
        }

        private void KilometriCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Double laina, nesteet, vakuutus, pesut, huollot, renkaat, muut, kilometrit, energia, kustannukset;
            laina = Convert.ToDouble(LainaTB.Text);
            nesteet = Convert.ToDouble(NesteetTB.Text);
            vakuutus = Convert.ToDouble(VakuutuksetTB.Text);
            pesut = Convert.ToDouble(PesutTB.Text);
            huollot = Convert.ToDouble(HuollotTB.Text);
            renkaat = Convert.ToDouble(RenkaatTB.Text);
            muut = Convert.ToDouble(MuutTB.Text);
            energia = Convert.ToDouble(PolttonesteTB.Text);
            kilometrit = Convert.ToDouble(KilometriCB.Text);
            kustannukset = (laina + nesteet + vakuutus + pesut + huollot + renkaat + energia + muut) / (kilometrit / 12);
            VastausLB.Text = "Kustannukset kilometriä kohti ovat: " + kustannukset;
            VastausLB.Visible = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matekform
{
    public partial class frmFo : Form
    {
        private List<int> szamok = new List<int>();
        private bool hiba = false;
        public frmFo()
        {

            InitializeComponent();
            try
            {
                StreamReader be = new StreamReader("adatok.txt");
                while (!be.EndOfStream)
                {
                    szamok.Add(int.Parse(be.ReadLine()));
                }
                be.Close();
            }
            catch (Exception ex)
            {
                
                hiba = true;
            if (hiba)
            {
                lblStatus.Text = "Volt hiba a beolvasásban. A  hibás adatot figyelmen kívül hagytam.";
            }
            else
            {
                lblStatus.Text = "Nincs hiba a beolvasásban";
            }
            }
           
        }

        private void btnAtlag_Click(object sender, EventArgs e)
        {
            double szum = 0;
            double atlag = 0;

            foreach (var i in szamok)
            {
                szum = szum + i;
            }
            atlag = Math.Round(szum / szamok.Count,2);

            lbEred.Items.Add($"Átlag: {atlag}");
            btnAtlag.Enabled = false;
        }

        private void btnHany_Click(object sender, EventArgs e)
        {
            int h = 1;
            while (h < szamok.Count && szamok[h] != 7143)
            {
                h++;
            }
            if (h <= szamok.Count)
            {
                lbEred.Items.Add($"A keresett elem a {h}. helyen van");
            }
            btnHany.Enabled = false;
        }

        private void btnHanyszor_Click(object sender, EventArgs e)
        {
            int db = 0;
            foreach (var i in szamok)
            {
                if (i == 1170)
                {
                    db++;
                }
            }
            lbEred.Items.Add($"Az elem {db}-szor fordul elő.");
            btnHanyszor.Enabled = false;

            
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVane_Click(object sender, EventArgs e)
        {
            bool vane = false;
            foreach (var i in szamok)
            {
                if (i == 8876)
                {
                    vane = true;
                }
            }
            if (vane)
            {
                lbEred.Items.Add($"Van benne 8876");
            }
            btnVane.Enabled = false;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            int max = 0;
            foreach (var i in szamok)
            {
                if (max < i)
                {
                    max = i;
                }
            }
            lbEred.Items.Add($"Maximum: {max}");
            btnMax.Enabled = false;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int min = szamok[0];
            foreach (var i in szamok)
            {
                if (min > i)
                {
                    min = i;
                }

            }
            lbEred.Items.Add($"Minimum: {min}");
            btnMin.Enabled = false;
        }
    }
}

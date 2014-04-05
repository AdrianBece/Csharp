using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Zad2
{
    public partial class Form1 : Form
    {
        int vrijednost = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            string ulaz = dat.Text;
            StreamReader citac = new StreamReader(ulaz);
            string line;
            int kriticno = Convert.ToInt32(kv.Text);
            line = citac.ReadLine();
            while ((line = citac.ReadLine()) != null)
            {
                int.TryParse(line, out vrijednost);
                rtb.Text += vrijednost.ToString() + "\n";
                rtb.Update();
                if (vrijednost >= kriticno)
                {
                    DateTime datum= DateTime.Now;
                    MessageBox.Show("Kriticno!\n"+"Vrijednost: "+vrijednost+"\nDatum: "+datum.ToString());
                }
                Thread.Sleep(1000);
            }
            citac.Close();
        }
    }
}

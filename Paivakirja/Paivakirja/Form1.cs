﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Paivakirja
{
    public partial class DiaryForm : Form
    {
        public DiaryForm()
        {
            InitializeComponent();
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = File.ReadAllText(@"C:\\Users\\jimil\\source\\repos\\Paivakirja\\Paiivakirja.txt");
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:\\Users\\jimil\\source\\repos\\Paivakirja\\Paiivakirja.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}

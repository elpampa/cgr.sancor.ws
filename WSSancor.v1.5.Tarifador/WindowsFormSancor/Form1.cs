using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormSancor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(WSSancor.Tarifas.RecuperarProvincias());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(WSSancor.Tarifas.CotizarART(30599791716, 611093, 2, 13200M, 1425 ));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(WSSancor.Tarifas.CotizarPMX(30599791716, 611093, 2, 13200M));
        }
    }
}

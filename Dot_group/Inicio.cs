using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Bots
{
    public partial class Inicio : Form
    {
        Thread t1;
        Bots.Robo Comeco;
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comeco = new Bots.Robo(new Bots.Robo.ResultDelegate(ResultCallback));
            t1 = new Thread(Comeco.Inicar);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        public static void ResultCallback(String valor)
        {
            MessageBox.Show(valor);
        }

    }
}

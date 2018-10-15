using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bots
{
    public partial class FormInCaptcha : Form
    {
        String _captcha;


        public FormInCaptcha(Image src)
        {
            InitializeComponent();
            pictureBoxCaptcha.Image = src;
        }


        public String captcha { get { return this._captcha; } set { this._captcha = value; } }


        private void textCaptcha_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxCaptcha_Click(object sender, EventArgs e)
        {

        }

        private void btOK_Click_1(object sender, EventArgs e)
        {
            EnviaCaptcha();
        }

        private void EnviaCaptcha()
        {
            _captcha = textCaptcha.Text.Trim();
            this.Close();
        }
    }
}

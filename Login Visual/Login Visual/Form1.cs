using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void USERNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string name = USERNAME.Text;
            string key = PASSWORD.Text;
            if(name=="Juancho")
            {
                if(key=="123tamarindo")
                {
                    MessageBox.Show("Que onda, listo para tocar el clarinete "+name);
                }
            }
            else
            {
                MessageBox.Show("Algo anda mal, OwO");
            }
        }
    }
}

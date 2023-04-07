using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicatie_boli
{
    public partial class Form3_register : Form
    {
        public Form3_register()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Form4_register cont = new Form4_register();
            this.Hide();
            cont.Show();
        }
    }
}

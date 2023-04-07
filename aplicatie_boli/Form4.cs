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
    public partial class Form4_register : Form
    {
        public Form4_register()
        {
            InitializeComponent();
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            Form2_login login = new Form2_login();
            this.Hide();
            login.Show();
        }

        private void maskedTextBox_BirthDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

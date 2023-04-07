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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_login_Click(object sender, EventArgs e)
        {
            Form2_login login = new Form2_login();
            this.Hide();
            login.Show();
        }

        private void button1_register_Click(object sender, EventArgs e)
        {
            Form3_register register = new Form3_register();
            this.Hide();
            register.Show();
        }
    }
}

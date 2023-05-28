using aplicatie_boli.DiseaseProbabilityDataSetTableAdapters;
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

        string encrypt(string s)
        {
            char[] pass = s.ToCharArray();
            for(int i = 0; i < pass.Length; i++)
            {
                pass[i] = (char)(pass[i] + i);
            }
            s = new string(pass);
            return s;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if(textBox3_username.Text.Length < 5)
            {
                MessageBox.Show("The username must have at least 5 characters!");
                textBox3_username.Text = "";
            }
            else if((textBox3_email.Text.IndexOf('@') == -1) || (textBox3_email.Text.IndexOf('@') != -1 && textBox3_email.Text.IndexOf('.', textBox3_email.Text.IndexOf('@')) == -1))
            {
                MessageBox.Show("The email is not valid!");
                textBox3_email.Text = "";
            }
            else if(textBox3_password.Text.Length < 6)
            {
                MessageBox.Show("The password must have at least 6 characters!");
                textBox3_password.Text = "";
                textBox3_confirmPassword.Text = "";
            }
            else if(textBox3_password.Text != textBox3_confirmPassword.Text)
            {
                MessageBox.Show("The passwords are not the same!");
                textBox3_confirmPassword.Text = "";
            }
            else
            {
                DiseaseProbabilityDataSet dataSet = new DiseaseProbabilityDataSet();
                UserTableAdapter userTA = new UserTableAdapter();
                userTA.Fill(dataSet.User);
                var rows = dataSet.User.Select("Username = '" + textBox3_username.Text + "'");
                if(rows.Length > 0)
                {
                    MessageBox.Show("This username is not available!");
                    textBox3_username.Text = "";
                }
                else
                {
                    rows = dataSet.User.Select("Email = '" + textBox3_email.Text + "'");
                    if(rows.Length > 0)
                    {
                        MessageBox.Show("There already is an account with this email!");
                        textBox3_email.Text = "";
                    }
                    else
                    {
                        DateTime temp = new DateTime();
                        userTA.Insert(textBox3_username.Text, textBox3_email.Text, encrypt(textBox3_password.Text), "", "", temp, "");
                        Form4_register cont = new Form4_register(textBox3_username.Text);
                        this.Hide();
                        cont.ShowDialog();
                        
                    }
                }
            }
            
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void Form3_register_Load(object sender, EventArgs e)
        {

        }
    }
}

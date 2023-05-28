using aplicatie_boli.DiseaseProbabilityDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicatie_boli
{
    public partial class Form2_login : Form
    {
        public Form2_login()
        {
            InitializeComponent();
        }

        string decrypt(string s)
        {
            char[] pass = s.ToCharArray();
            for (int i = 0; i < pass.Length; i++)
                pass[i] = (char)(pass[i] - i);
            s = new string(pass);
            return s;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_login_Load(object sender, EventArgs e)
        {


        }

        private void button2_login_Click(object sender, EventArgs e)
        {
            string enteredUsername = textBox2_username.Text;
            string enteredPassword = textBox2_password.Text;
            UserTableAdapter userTA = new UserTableAdapter();
            DiseaseProbabilityDataSet dataSet = new DiseaseProbabilityDataSet();
            userTA.Fill(dataSet.User);
            var rows = dataSet.User.Select("Username = '" + enteredUsername + "'");
            if (rows.Length == 0)
            {
                MessageBox.Show("There is no account with these credentials!");
                textBox2_username.Text = "";
                textBox2_password.Text = "";
                Form3_register f = new Form3_register();
                this.Hide();
                f.Show();
            }
            else
            {
                var row = rows[0];
                if (decrypt(row["Password"].ToString()) != enteredPassword)
                {
                    MessageBox.Show("Wrong password!");
                    textBox2_password.Text = "";
                }
                    
                else
                {
                    /** Form5 f = new Form5();
                     this.Hide();
                     f.Show(); **/
                    FormProfile f = new FormProfile(Int32.Parse(row["Id"].ToString()));
                    this.Hide();
                    f.Show();
                }

                
            }
                
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            
            this.Hide();
            f.ShowDialog();
        }
    }
}

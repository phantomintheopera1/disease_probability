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
    public partial class Form4_register : Form
    {
        private string Username;
        public Form4_register(string username)
        {
            InitializeComponent();
            Username = username;
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            string date = maskedTextBox_BirthDate.Text;
            if (DateTime.TryParse(date, out DateTime result))
            {
                DiseaseProbabilityDataSet dataSet = new DiseaseProbabilityDataSet();
                UserTableAdapter userTA = new UserTableAdapter();
                userTA.Fill(dataSet.User);
                var rows = dataSet.User.Select("Username = '" + Username + "'");
                var row = rows[0];
                row["First name"] = textBox_FirstName.Text;
                row["Last name"] = textBox_LastName.Text;
                row["Birth date"] = result;
                row["Medical history"] = "";
                userTA.Update(dataSet.User);
                MessageBox.Show("Registered succesfully!");
                Form2_login fl = new Form2_login();
                this.Hide();
                fl.Show();
            }
            else
            {
                MessageBox.Show("Invalid date!");
                maskedTextBox_BirthDate.Text = "";
            }
            
            

        }

        private void maskedTextBox_BirthDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void Form4_register_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class FormProfile : Form
    {
        public int ID;
        public FormProfile(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            DiseaseProbabilityDataSet dataSet = new DiseaseProbabilityDataSet();
            UserTableAdapter userTA = new UserTableAdapter();
            userTA.Fill(dataSet.User);
            var rows = dataSet.User.Select("Id = " + ID);
            labelUsername.Text += rows[0]["Username"].ToString();
            labelName.Text += rows[0]["First name"].ToString() + " " + rows[0]["Last name"].ToString();
            labelBirth.Text += rows[0]["Birth date"].ToString();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5(ID);
            this.Hide();
            f.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select the field you want to change by pressing the button next to it!");

            buttonChangeUsername.Enabled = true;
            buttonChangeFullName.Enabled = true;
            buttonChangeBirthDate.Enabled = true;
            buttonChangeUsername.Visible = true;
            buttonChangeFullName.Visible = true;
            buttonChangeBirthDate.Visible = true;
            labelUsername.Text = "Username: ";
            labelName.Text = "Full name: ";
            labelBirth.Text = "Birth date: ";
            buttonSave.Visible = true;
        }

        private void buttonChangeUsername_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter the new username!");
            textBoxNewUsername.Visible = true;
            buttonUpdateUsername.Visible = true;
            textBoxNewUsername.Select();
        }

        private void buttonChangeFullName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select the name you want to change from the drop-down!");
            comboBox1.Visible = true;
            textBoxNewName.Visible = true;
            buttonUpdateName.Visible = true;
        }

        private void buttonChangeBirthDate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter the new birthdate!");
            maskedTextBoxNewBirthDate.Visible = true;
            buttonUpdateBirthDate.Visible = true;
            maskedTextBoxNewBirthDate.Select();
        }

        private void buttonUpdateUsername_Click(object sender, EventArgs e)
        {
            DiseaseProbabilityDataSet dataSet = new DiseaseProbabilityDataSet();
            UserTableAdapter userTA = new UserTableAdapter();
            userTA.Fill(dataSet.User);
            var rows = dataSet.User.Select("Id = " + ID);
            if (textBoxNewUsername.Text == "")
                MessageBox.Show("Please enter the new username before pressing!");
            else if(textBoxNewUsername.TextLength < 5)
            {
                MessageBox.Show("The username must have at least 5 characters!");
                textBoxNewUsername.Text = "";
            }
            else
            {
                rows[0]["Username"] = textBoxNewUsername.Text;
                userTA.Update(dataSet.User);
                MessageBox.Show("Username updated succesfully!");
                textBoxNewUsername.Visible = false;
                buttonUpdateUsername.Visible = false;
            }
        }

        private void buttonUpdateName_Click(object sender, EventArgs e)
        {
            DiseaseProbabilityDataSet dataSet = new DiseaseProbabilityDataSet();
            UserTableAdapter userTA = new UserTableAdapter();
            userTA.Fill(dataSet.User);
            var rows = dataSet.User.Select("Id = " + ID);
            if (textBoxNewName.Text == "")
                MessageBox.Show("Please enter the new name before pressing!");
            else
            {
                int ok = 1;
                if (comboBox1.Text == "First name")
                    rows[0]["First name"] = textBoxNewName.Text;
                else if (comboBox1.Text == "Last name")
                    rows[0]["Last name"] = textBoxNewName.Text;
                else if(comboBox1.Text == "Both")
                {
                    var name = textBoxNewName.Text.Split(' ');
                    if (name.Length < 2)
                    {
                        ok = 0;
                        MessageBox.Show("Please enter both names!");
                    }
                        
                    else if (name.Length > 2)
                    {
                        ok = 0;
                        MessageBox.Show("If any of your names has more than 2 words, please enter \'-\' between the words of it!");
                    }
                        
                    else
                    {
                        rows[0]["First name"] = name[0];
                        rows[0]["Last name"] = name[1];
                    }
                }
                if(ok == 1)
                {
                    userTA.Update(dataSet.User);
                    MessageBox.Show("Name updated succesfully!");
                    textBoxNewName.Visible = false;
                    comboBox1.Visible = false;
                    buttonUpdateName.Visible = false;
                }
                
            }
        }

        private void buttonUpdateBirthDate_Click(object sender, EventArgs e)
        {
            DiseaseProbabilityDataSet dataSet = new DiseaseProbabilityDataSet();
            UserTableAdapter userTA = new UserTableAdapter();
            userTA.Fill(dataSet.User);
            var rows = dataSet.User.Select("Id = " + ID);
            if (maskedTextBoxNewBirthDate.Text == "")
                MessageBox.Show("Please enter the new birth date before pressing!");
            else if (DateTime.TryParse(maskedTextBoxNewBirthDate.Text, out DateTime x) == false)
            {
                MessageBox.Show("The date is not valid!");
                maskedTextBoxNewBirthDate.Text = "";
            }
            else
            {
                rows[0]["Birth date"] = DateTime.Parse(maskedTextBoxNewBirthDate.Text);
                userTA.Update(dataSet.User);
                MessageBox.Show("Birth date updated succesfully!");
                maskedTextBoxNewBirthDate.Visible = false;
                buttonUpdateBirthDate.Visible = false;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Both")
                MessageBox.Show("Please enter the first name, then the last name, separated by a space!");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The app must be closed for saving the changes! It will automatically close after closing this window");
            Application.Exit();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonViewHistory_Click(object sender, EventArgs e)
        {
            FormHistory f = new FormHistory(ID);
            this.Hide();
            f.Show();
        }
    }
}

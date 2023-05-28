using aplicatie_boli.DiseaseProbabilityDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicatie_boli
{
    public partial class Form5 : Form
    {
        public int[] fr;
        public int k;
        public int ID;
        public Form5(int id)
        {
            InitializeComponent();
            ID = id;
        }
        struct pair
        {
            public string disease;
            public float probability;
        }
        pair[] found;

        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Please choose a symptom from the list!";
            fr = new int[240];
            found = new pair[240];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fr[comboBox1.SelectedIndex] == 0)
            {
                richTextBox1.Text += comboBox1.Text + "\n";
                fr[comboBox1.SelectedIndex] = 1;
            }
            else
                MessageBox.Show("This symptom was chosen already!");
            comboBox1.Text = "Please choose a symptom from the list!";

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data (if any) will be saved and can be accessed by pressing \"View history of probabilities\" button from profile window");
            FormProfile f = new FormProfile(ID);
            this.Hide();
            f.Show();
        }

        private void buttonDiagnostic_Click(object sender, EventArgs e)
        {
            string x = richTextBox1.Text;
            var lines = x.Split('\n');
            for(int i = 1; i <= 50; i++)
            {
                var rows = File.ReadAllLines(string.Format("simptome/fisier_{0}.txt", i));
                string disease = rows[0];
                string symptoms = rows[1];
                var listofsymptoms = symptoms.Split('*');
                int common = 0;
                foreach (var line in lines)
                {
                    foreach (var s in listofsymptoms)
                        if (line == s)
                        {
                            common++;
                            break;
                        }
                            
                }
                if(common != 0)
                {
                    found[k].disease = disease;
                    float prob = ((float)common / listofsymptoms.Length) * 100;
                    string formatted = prob.ToString("F" + 2);
                    found[k].probability = float.Parse(formatted);
                    k++;
                }
            }
            for(int i = 0; i < k - 1; i++)
                for(int j = i + 1; j < k; j++)
                    if (found[i].probability < found[j].probability)
                    {
                        pair aux = found[i];
                        found[i] = found[j];
                        found[j] = aux;
                    }
            richTextBox1.Text = "";

            DiseaseProbabilityDataSet dataSet = new DiseaseProbabilityDataSet();
            HistoryTableAdapter historyTA = new HistoryTableAdapter();
            historyTA.Fill(dataSet.History);
            for(int i = 0; i < k; i++)
            {
                richTextBox1.Text += string.Format("{0}. {1} (Probability: {2}%)", i + 1, found[i].disease, found[i].probability) + "\n";
                historyTA.Insert(ID, found[i].disease, found[i].probability);
            }
            var rows1 = dataSet.History.Select("IdUser = " + ID);
            for(int i = 0; i < rows1.Length - 1; i++)
                for(int j = i + 1; j < rows1.Length; j++)
                    if (float.Parse(rows1[i]["Probability"].ToString()) < float.Parse(rows1[j]["Probability"].ToString()))
                    {
                        var aux = rows1[i];
                        rows1[i] = rows1[j];
                        rows1[j] = aux;
                    }
            historyTA.Update(dataSet.History);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

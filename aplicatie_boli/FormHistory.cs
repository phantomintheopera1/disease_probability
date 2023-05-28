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
    public partial class FormHistory : Form
    {
        private int ID;
        public FormHistory(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            DiseaseProbabilityDataSet dataSet = new DiseaseProbabilityDataSet();
            HistoryTableAdapter historyTA = new HistoryTableAdapter();
            historyTA.Fill(dataSet.History);
            var rows = dataSet.History.Select("IdUser = " + ID);
            for(int i = 0; i < rows.Length - 1; i++)
                for(int j = i + 1; j < rows.Length; j++)
                    if (float.Parse(rows[i]["Probability"].ToString()) < float.Parse(rows[j]["Probability"].ToString()))
                    {
                        var aux = rows[i];
                        rows[i] = rows[j];
                        rows[j] = aux;
                    }
            for (int i = 0; i < rows.Length; i++)
                dataGridView1.Rows.Add(rows[i]["Disease"].ToString(), float.Parse(rows[i]["Probability"].ToString()).ToString("F" + 2) + "%");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProfile f = new FormProfile(ID);
            this.Hide();
            f.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Task[] processi = new Task[30];
        int count = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            var processo = new Task();
            processo.name = txtName.Text;
            processo.time = Convert.ToInt32(txtTime.Text);

            processi[count] = processo;

            txtName.Clear();
            txtTime.Clear();
            count++;
        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < count; i++)
            {
                lblWrite.Text = $"{processi[i].name} {processi[i].time}\n";
            }
        }
    }
}

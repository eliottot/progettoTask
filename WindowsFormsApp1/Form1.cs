using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Task[] processi = new Task[30];
        int counter = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selector.Text = "First Come First Served";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            var processo = new Task();
            processo.name = txtName.Text; processo.time = Convert.ToInt32(txtTime.Text); processo.priority = selectorPriority.Text;

            processi[counter] = processo;

            txtName.Clear();
            txtTime.Clear();
            selectorPriority.Items.Clear();
            counter++;

            try
            {
                
            }
            catch
            {
                    
            }
        }

        
         private void btnEsegui_Click(object sender, EventArgs e)
        {
            ProcessiAggiuntiTesto(processi, counter);

            switch (selector.Text)
            {
                case "First Come First Served":
                    {
                        FirstComeFirstServed(processi, counter);
                        break;
                    }
                case "Shortest Job First":
                    {
                        ShortestJobFirst(processi, counter);
                        break;
                    }
                case "Round Robin":
                    {
                        break;
                    }
                case "Round Robin Limitato":
                    {
                        break;
                    }
                default:
                    {
                        lblError.Text = "ERROR\nLa politica selezionata non esiste o è stata scritta nel modo errato.";
                        lblError.Visible = true;
                        break;
                    }
            }
        }

        private void ProcessiAggiuntiTesto(Task[] processi, int counter)
        {
            for (int i = 0; i < counter; i++)
            {
                listBox.Items.Add($"{processi[i].name}.exe aggiunto. Tempo necessario: {processi[i].time} ms");
            }
            listBox.Items.Add($"||| Inizializzazione processi... |||");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtTime.Clear();
            selectorPriority.Items.Clear();
            listBox.Items.Clear();
            for (int i = 0; i < counter ; i++)
            {
                processi[i].name = null;
                processi[i].time = 0;
                processi[i].priority = null;
            }
            counter = 0;
        }

        private void FirstComeFirstServed(Task[] processi, int counter)
        {
            listBox.Items.Clear();
            ProcessiAggiuntiTesto(processi, counter);
            for (int i = 0; i < counter; i++)
            {
                listBox.Items.Add($"{processi[i].name}.exe iniziato.");
                listBox.Items.Add($"{processi[i].name}.exe terminato. Trascorsi: {processi[i].time} ms");
            }
        }
        private void ShortestJobFirst(Task[] processi, int counter)
        {
            listBox.Items.Clear();
            ProcessiAggiuntiTesto(processi, counter);
            OrdinamentoCrescente(processi, counter);
            FirstComeFirstServed(processi, counter);
        }
        private void RoundRobin(Task[] processi, int counter)
        {
            listBox.Items.Clear();
            ProcessiAggiuntiTesto(processi, counter);
        }

        private void OrdinamentoCrescente(Task[] array, int counter)
        {
            int temp = 0;

            for (int i = 0; i < counter - 1; i++)
            {
                for (int j = i + 1; j < counter; j++)
                {
                    if (array[j].time < array[i].time)
                    {
                        temp = array[j].time;
                        array[j].time = array[i].time;
                        array[i].time = temp;
                    }
                }
            }
        }

        /*private void RoundRobin(Task[] processi, int counter, int tempoTot, int timeSlice)
        {
            int i = 0;
            while (tempoTot > 0 && processi.Any(p => p.time > 0))
            {
                if (processi[i].time > 0)
                {
                    int temp = Math.Min(processi[i].time, timeSlice);
                    processi[i].time -= temp;
                    tempoTot -= temp;
                    processi[i].counter++;
                    listBox.Items.Add($"Processo {processi[i].name}.exe {(processi[i].counter == 1 ? "inizia" : "continua")} con {processi[i].time} tempo rimanente");
                    if (processi[i].time <= 0) listBox.Items.Add($"Processo {processi[i].name}.exe terminato in {processi[i].counter} time-slice");
                }
                i = (i + 1) % counter;
            }
        }*/


    }
}

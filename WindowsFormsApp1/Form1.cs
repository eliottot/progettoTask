﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        #region funzioni iniziali
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selector.Text = "First Come First Served";
            btnEsegui.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region tasti
        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            var processo = new Task();

            try
            {
                processo.name = txtName.Text; processo.time = Convert.ToInt32(txtTime.Text); 
            }
            catch (Exception error)
            {
                MessageBox.Show("I dati non sono stati inseriti nel modo corretto\n" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Clear();
                txtTime.Clear();
            }

            processi[counter] = processo;

            ProcessoAggiuntoTesto(processi, counter);

            txtName.Clear();
            txtTime.Clear();
            counter++;
            btnEsegui.Enabled = true;
        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            switch (selector.Text)
            {
                case "First Come First Served":
                    FirstComeFirstServed(processi, counter); btnMetriche.Visible = true; break;

                case "Shortest Job First":
                    ShortestJobFirst(processi, counter); btnMetriche.Visible = true; break;

                case "Round Robin":
                    RoundRobin(processi, counter); btnMetriche.Visible = true; break;

                case "Round Robin Limitato":
                    RoundRobinLimitato(processi, counter); btnMetriche.Visible = true; break;

                default:
                    lblError.Text = "ERROR\nLa politica selezionata non esiste o è stata scritta nel modo errato.";
                    lblError.Visible = true; btnMetriche.Visible = false; break;
            }           
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtTime.Clear();
            listBox.Items.Clear();
            btnMetriche.Visible = false;
            for (int i = 0; i < counter; i++)
            {
                processi[i].name = null;
                processi[i].time = 0;
            }
            counter = 0;
        }
        private void btnMetriche_Click(object sender, EventArgs e)
        {
            listBox.Items.Add($"");
            listBox.Items.Add($"||| METRICHE |||");
            listBox.Items.Add($"Throughput: {Throughput(processi, counter)} processi");
            listBox.Items.Add($"Tournaround Time: {TournaroundTime(processi, counter)} ms");
            listBox.TopIndex = listBox.Items.Count - 1;

        }
        #endregion

        #region funzioni processi aggiunti
        private void ProcessoAggiuntoTesto(Task[] processi, int counter)
        {
            listBox.Items.Add($"{processi[counter].name}.exe aggiunto. Tempo necessario: {processi[counter].time} ms");
        }
        private void ProcessiAggiuntiTesto(Task[] processi, int counter)
        {
            for (int i = 0; i < counter; i++)
            {
                listBox.Items.Add($"{processi[i].name}.exe aggiunto. Tempo necessario: {processi[i].time} ms");
            }
            listBox.Items.Add($"||| Inizializzazione processi... |||");
        }
        #endregion

        #region politiche
        private void FirstComeFirstServed(Task[] processi, int counter)
        {
            listBox.Items.Clear();
            ProcessiAggiuntiTesto(processi, counter);
            OrdinamentoFCFS(processi, counter);
            listBox.TopIndex = listBox.Items.Count - 1; // arriva alla fine della listbox automaticamente
        }
        private void ShortestJobFirst(Task[] processi, int counter)
        {
            listBox.Items.Clear();
            ProcessiAggiuntiTesto(processi, counter);
            OrdinamentoCrescente(processi, counter);
            OrdinamentoFCFS(processi, counter);
            listBox.TopIndex = listBox.Items.Count - 1;
        }
        private void RoundRobin(Task[] processi, int counter)
        {
            listBox.Items.Clear();
            ProcessiAggiuntiTesto(processi, counter);
            OrdinamentoRoundRobin(processi, counter);
            listBox.TopIndex = listBox.Items.Count - 1;
        }
        private void RoundRobinLimitato(Task[] processi, int counter)
        {
            listBox.Items.Clear();
            ProcessiAggiuntiTesto(processi, counter);
            OrdinamentoRoundRobinLimitato(processi, counter);
            listBox.TopIndex = listBox.Items.Count - 1;
        }
        private void OrdinamentoFCFS(Task[] processi, int counter)
        {
            for (int i = 0; i < counter; i++)
            {
                listBox.Items.Add($"{processi[i].name}.exe iniziato.");
                listBox.Items.Add($"{processi[i].name}.exe terminato. Trascorsi: {processi[i].time} ms");
            }
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

        private void OrdinamentoRoundRobin(Task[] processi, int counter)
        {
            int tempoTot = CalcolaTempoTotale(processi, counter);
            int timeSlice = Convert.ToInt32(txtTimeSlice.Text);
            int tempoTrascorso = 0;

            listBox.Items.Add($"--- Time Slice per ogni processo: {timeSlice} ms ---");

            while (tempoTrascorso < tempoTot) // continua finchè non esaurisce il tempo stabilito
            {
                for (int i = 0; i < counter; i++)
                {
                    if (processi[i].time > 0)
                    {
                        int tempoEseguito = Math.Min(processi[i].time, timeSlice); // restituisce il valore minore
                        listBox.Items.Add($"{processi[i].name}.exe iniziato. Trascorsi: {tempoTrascorso} ms");
                        listBox.Items.Add($"{processi[i].name}.exe sospeso.");
                        processi[i].time -= tempoEseguito;
                        tempoTrascorso += tempoEseguito;
                        if (processi[i].time <= 0)
                        {
                            listBox.Items.Add($"{processi[i].name}.exe terminato. Trascorsi: {tempoTrascorso} ms");
                        }
                    }
                }
            }
        }
        private void OrdinamentoRoundRobinLimitato(Task[] processi, int counter)
        {
            int timeSlice = Convert.ToInt32(txtTimeSlice.Text);
            int maxTimeSlice = Convert.ToInt32(txtTimeMax.Text);
            int tempoTot = CalcolaTempoTotale(processi, counter);
            int tempoTrascorso = 0;

            listBox.Items.Add($"--- Time Slice per ogni processo: {timeSlice} ms ---");

            while (tempoTrascorso < tempoTot)
            {
                for (int i = 0; i < counter; i++)
                {
                    for (int j = 0; j < maxTimeSlice; j++)
                    {
                        if (processi[i].time > 0)
                        {
                            int tempoEseguito = Math.Min(processi[i].time, timeSlice); // restituisce il valore minore
                            listBox.Items.Add($"{processi[i].name}.exe iniziato. Trascorsi: {tempoTrascorso} ms");
                            listBox.Items.Add($"{processi[i].name}.exe sospeso.");
                            processi[i].time -= tempoEseguito;
                            tempoTrascorso += tempoEseguito;
                            if (processi[i].time <= 0)
                            {
                                listBox.Items.Add($"{processi[i].name}.exe terminato. Trascorsi: {tempoTrascorso} ms");
                            }
                        }
                    }               
                }
            }
        }
        
            private int CalcolaTempoTotale(Task[] processi, int counter)
        {
            int tempoTot = 0;
            for (int i = 0; i < counter; i++)
            {
                tempoTot += processi[i].time;
            }
            return tempoTot;
        }
        #endregion

        private void selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selector.SelectedIndex == 3)
            {
                txtTimeSlice.Visible = true;
                txtTimeMax.Visible = true;
                lblTimeSlice.Visible = true;
                lblTimeMax.Visible = true;
            }
            else if (selector.SelectedIndex == 2)
            {
                txtTimeSlice.Visible = true;
                txtTimeMax.Visible = false;
                lblTimeSlice.Visible = true;
                lblTimeMax.Visible = false;
            }
            else
            {
                txtTimeSlice.Visible = false;
                txtTimeMax.Visible = false;
                lblTimeSlice.Visible = false;
                lblTimeMax.Visible = false;
            }          
        }

        #region funzioni metriche
        private float Throughput(Task[] processi, int counter)
        {
            float throughput = 0;
            for (int i = 0; i < counter; i++)
            {
                throughput += processi[i].time;
            }

            throughput = counter / throughput;

            return throughput;
        }
        private float TournaroundTime(Task[] processi, int counter)
        {
            float tournaroundTIme = 0;

            for (int i = 0; i < counter; i++)
            {
                tournaroundTIme += processi[i].time;
            }

            tournaroundTIme /= counter;

            return tournaroundTIme;
        }
        #endregion
    }
}
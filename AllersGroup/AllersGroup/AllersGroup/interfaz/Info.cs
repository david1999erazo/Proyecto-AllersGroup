﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace AllersGroup.interfaz
{
    public partial class Info : Form
    {
        private InterfazPrincipal a;
        public Info(InterfazPrincipal b)
        {
            a = b;
            InitializeComponent();
        }
        private void Info_Load(object sender, EventArgs e)
        {

        }

        private void inicio_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_CriticalDamping(2000));
            t.add(a, "Left", -10);
            Visible = false;
            a.Show();
            t.run();
        }

        private void recom_Click(object sender, EventArgs e)
        {
            a.recom_Click(sender, e);
            Visible = false;
        }

        private void graf_Click(object sender, EventArgs e)
        {
            a.graf_Click(sender, e);
            Visible = false;
        }

        private void butDistribuidorC_Click(object sender, EventArgs e)
        {
            string[] frec = a.frecuentesCategoria("DISTRIBUIDORES");
            for (int i = 0; i < frec.Count(); i++)
            {
                richTextBox1.Text += "- " + frec[i] + "\n";
            }
            MessageBox.Show("Productos Cargados");

        }

        private void butLimpiarInfoPF_Click(object sender, EventArgs e)
        {

            richTextBox1.Clear();
            txtSoporteFP.Text = "";

        }

        private void butDrogFarmaciaMiscC_Click(object sender, EventArgs e)
        {
            string[] frec = a.frecuentesCategoria("DROG FARMACIA Y MISC");
            for (int i = 0; i < frec.Count(); i++)
            {
                richTextBox1.Text += "- " + frec[i] + "\n";
            }
            MessageBox.Show("Productos Cargados");
        }

        private void butAplicarControladorPF_Click(object sender, EventArgs e)
        {
            double support = Double.Parse(txtSoporteFP.Text);
            a.cargar(support);
            MessageBox.Show("Datos Cargados");
            
        }

        

        private void butCPrivadaC_Click(object sender, EventArgs e)
        {
            string[] frec = a.frecuentesCategoria("CLINICAS PRIVADAS");
            for (int i = 0; i < frec.Count(); i++)
            {
                richTextBox1.Text += "- " + frec[i] + "\n";

            }
            MessageBox.Show("Productos Cargados");
        }

        private void butCPublicasC_Click(object sender, EventArgs e)
        {
            string[] frec = a.frecuentesCategoria("CLINICAS PUBLICAS");
            for (int i = 0; i < frec.Count(); i++)
            {
                richTextBox1.Text += "- " + frec[i] + "\n";
            }
            MessageBox.Show("Productos Cargados");
        }

        private void butNoDedicadoSaludC_Click(object sender, EventArgs e)
        {
            string[] frec = a.frecuentesCategoria("NO DEDICADO A SALUD");
            for (int i = 0; i < frec.Count(); i++)
            {
                richTextBox1.Text += "- " + frec[i] + "\n";
            }
            MessageBox.Show("Productos Cargados");
        }

        private void butAlmacenCadenaC_Click(object sender, EventArgs e)
        {
            string[] frec = a.frecuentesCategoria("ALMACENES DE CADENA");
            for (int i = 0; i < frec.Count(); i++)
            {
                richTextBox1.Text += "- " + frec[i] + "\n";
            }
            MessageBox.Show("Productos Cargados");
        }

        private void butBellezayEsteticaC_Click(object sender, EventArgs e)
        {
            string[] frec = a.frecuentesCategoria("BELLEZA Y ESTETICA");
            for (int i = 0; i < frec.Count(); i++)
            {
                richTextBox1.Text += "- " + frec[i] + "\n";
            }
            MessageBox.Show("Productos Cargados");
        }

        private void butVeterinarioC_Click(object sender, EventArgs e)
        {
            string[] frec = a.frecuentesCategoria("VETERINARIOS");
            for (int i = 0; i < frec.Count(); i++)
            {
                richTextBox1.Text += "- " + frec[i] + "\n";
            }
            MessageBox.Show("Productos Cargados");
        }

        private void butOdontoCentroOdontoC_Click(object sender, EventArgs e)
        {
            string[] frec = a.frecuentesCategoria("ODONTO CENTRO ODONTO");
            for (int i = 0; i < frec.Count(); i++)
            {
                richTextBox1.Text += "- " + frec[i] + "\n";
            }
            MessageBox.Show("Productos Cargados");
        }

        private void butMedAmbulC_Click(object sender, EventArgs e)
        {
            string[] frec = a.frecuentesCategoria("MED LAB OP AMBUL");
            for (int i = 0; i < frec.Count(); i++)
            {
                richTextBox1.Text += "- " + frec[i] + "\n";
            }
            MessageBox.Show("Productos Cargados");
        }

       
    }
}

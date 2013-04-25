using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practica7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbPregunta1_TextChanged(object sender, EventArgs e)
        {
            
        }

        int resto = 3;
        private void btEvaluar_Click(object sender, EventArgs e)
        {
            if (resto != 0)
            {
                int aciertos = 0;
                if (tbPregunta1.Text == "Jupiter")
                    aciertos += 2;
                if (numPregunta2.Value == 3)
                    aciertos += 2;
                if (cb1.Checked && cb2.Checked && cb5.Checked && cb3.Checked == false && cb4.Checked == false)
                    aciertos += 2;
                if (rb2.Checked)
                    aciertos += 2;
                string fecha = mCalendario.SelectionStart.ToString();
                if (fecha == "05/12/2000 12:00:00 a.m.")
                    aciertos += 2;
                pbAciertos.Value = aciertos;
                lbAciertos.Text = "Tus aciertos: " + aciertos;
                lbAciertos.Visible = true;
                resto--;
                MessageBox.Show("Te quedan " + resto + " intentos", "Cuidado");
            }
            if (resto == 0)
                btEvaluar.Enabled = false;
        }
    }
}

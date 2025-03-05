using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PROGRAMA_DE_FRECUENCIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FRECUENCIA_Click(object sender, EventArgs e)
        {
            //URIAS JACOBO EDWIN ISAAC #14210425
            //VARIABLES
            int frec;
            //DECLARAR VARIABLES
            frec = System.Int32.Parse(txtfrec.Text);
            //CONDICION
            if (frec > 60) etresultado.Text = "LA FRECUENCIA ES DEMACIADO ALTA";
        }

        private void LIMPIAR_Click(object sender, EventArgs e)
        {
            txtfrec.Clear();
            etresultado.Text = " ";
            txtfrec.Focus();
        }

        private void CERRAR_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

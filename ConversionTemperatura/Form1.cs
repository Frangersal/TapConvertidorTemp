using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversionTemperatura
{
    public partial class Form1 : Form
    {
      

        //Definimos las cajas de texto y recibimos el valor tecleado
        private void ctGradosC_KeyPress(object sender, KeyPressEventArgs e)
        {
            objTextBox = (TextBox)sender;
        }

        private void ctGradosF_KeyPress(object sender, KeyPressEventArgs e)
        {
            objTextBox = (TextBox)sender;
        }

        //
        private TextBox objTextBox = null;

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //Definimos boton Aceptar como boton predeterminado.

        private void btAceptar_Click(object sender, EventArgs e)
        {
            this.AcceptButton = this.btAceptar;
            try
            {
                double grados;
                // Si se escribió en la caja de texto grados centígrados...
                if (objTextBox == ctGradosC)
                {
                    grados = Convert.ToDouble(ctGradosC.Text) * 9.0 / 5.0 + 32.0;
                    // Mostrar el resultado redondeado a dos decimales
                    ctGradosF.Text = string.Format("{0:F2}", grados);
                }
                // Si se escribió en la caja de texto grados Fahrenheit...
                if (objTextBox == ctGradosF)
                {
                    grados = (Convert.ToDouble(ctGradosF.Text) - 32.0) * 5.0 / 9.0;
                    // Mostrar el resultado redondeado a dos decimales
                    ctGradosC.Text = string.Format("{0:F2}", grados);
                }
            }
            catch (FormatException)
            {
                ctGradosC.Text = "0,00";
                ctGradosF.Text = "32,00";
            }
        }

        //Enfocar un objeto
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = true;
            ctGradosC.Focus();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            ctGradosC.Focus();
        }
        //Seleccionar el texto de una caja de texto
        private void CajaTexto_Enter(object sender, EventArgs e)
        {
            TextBox ObjTextBox = (TextBox)sender;
            ObjTextBox.SelectAll();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

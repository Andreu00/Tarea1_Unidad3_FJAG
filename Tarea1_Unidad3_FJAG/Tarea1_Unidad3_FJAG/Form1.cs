using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1_Unidad3_FJAG
{
    public partial class Form1 : Form
    {
        private bool formato24Horas;
        private Timer timer;
        public Form1()
        {
            InitializeComponent();           

        }

        private void btnCambiarFormato_Click(object sender, EventArgs e)
        {
            reloj1.Formato24Horas = !reloj1.Formato24Horas;
        }

        private void btnEstablecerAlarma_Click(object sender, EventArgs e)
        {
            //Convertir el texto del TextBox a un objeto DateTime
            MessageBox.Show("Alarma Puesta");
            if (DateTime.TryParse(txtAlarma.Text, out DateTime horaAlarma)){                
                reloj1.EstablecerAlarma(horaAlarma);
            }else{
                MessageBox.Show("Formato de hora no válido. Por favor, ingrese la hora en formato válido.");
            }
        }
    }
}

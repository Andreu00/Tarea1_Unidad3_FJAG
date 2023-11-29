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
    public partial class reloj : Label
    {
        private bool formato24Horas;
        private Timer timer;
        private DateTime horaAlarma; //Variable para almacenar la hora de la alarma
        public reloj()
        {
            InitializeComponent(); InitializeComponent();
            this.Text = DateTime.Now.ToString("hh:mm:ss");
            formato24Horas = false; // Por defecto, se establece en formato de 12 horas

            // Configuración del temporizador
            timer = new Timer();
            timer.Interval = 1000; // Intervalo en milisegundos (1000 ms = 1 segundo)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        public bool Formato24Horas
        {

            get { return formato24Horas; }
            set
            {
                formato24Horas = value;
                // Actualizar el texto del reloj cuando se cambia el formato
                this.Text = ObtenerHoraActual();
            }
        }

        public string ObtenerHoraActual()
        {

            if (formato24Horas)
            {
                return DateTime.Now.ToString("HH:mm:ss"); // Formato de 24 horas
            }
            else
            {
                return DateTime.Now.ToString("hh:mm:ss"); // Formato de 12 horas con AM/PM
            }
        }

        public void EstablecerAlarma(DateTime hora)
        {
            horaAlarma = hora;

        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            string horaActual = DateTime.Now.ToString("hh:mm:ss");

            // Actualizar el texto del reloj en cada tick del temporizador
            this.Text = ObtenerHoraActual();

            // Verificar si la alarma está programada y si ha llegado la hora
            if (horaAlarma != DateTime.MinValue && DateTime.Now >= horaAlarma)
            {
                // Mostrar un MessageBox cuando la alarma se active
                MessageBox.Show("RIIIING RIIING!!!!");
                // Restablecer la hora de la alarma para evitar que el MessageBox se muestre repetidamente
                horaAlarma = DateTime.MinValue;
            }
        }
    }
}

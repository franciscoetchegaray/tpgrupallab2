using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FColorestp2
{
    public partial class FColores : Form
    {
        int amarilloRequerido;
        int rojoRequerido;
        int azulRequerido;
        int Primero, Segundo, Tercero ;
        public FColores()
        {
            amarilloRequerido = 0;
            rojoRequerido = 0;
            azulRequerido = 0;
            InitializeComponent();
        }

        private void FColores_Load(object sender, EventArgs e)
        {

        }

        private void BAmarillo_Click(object sender, EventArgs e)
        {
            Color colorActual = BackColor;
            if (colorActual == Color.Orange)
            {
                this.BackColor = Color.Yellow;
            }
            else if (colorActual == Color.Blue)
            {
                this.BackColor = Color.Green;
            }
            else if (colorActual == Color.Green)
            {
                this.BackColor = Color.Yellow;
            }
            else if (colorActual == Color.Purple)
            {
                this.BackColor = Color.Black;
            }

            else if (colorActual == Color.Red)
            {
                this.BackColor = Color.Orange;
            }
            else
            {
                this.BackColor = Color.Yellow;
            }
            amarilloRequerido = int.Parse(lAmarillo.Text);
            amarilloRequerido++;
            lAmarillo.Text = amarilloRequerido.ToString();
        }

        private void BRojo_Click(object sender, EventArgs e)
        {
            Color colorActual = BackColor;
            if (colorActual == Color.Orange)
            {
                this.BackColor = Color.Red;
            }
            else if (colorActual == Color.Purple)
            {
                this.BackColor = Color.Red;
            }
            else if (colorActual == Color.Yellow)
            {
                this.BackColor = Color.Orange;
            }
            else if (colorActual == Color.Green)
            {
                this.BackColor = Color.Black;
            }
            else if (colorActual == Color.Blue)
            {
                this.BackColor = Color.Purple;
            }
            else
            {
                this.BackColor = Color.Red;
            }
            rojoRequerido = int.Parse(lRojo.Text);
            rojoRequerido++;
            lRojo.Text = rojoRequerido.ToString();
          
        }

        private void Bazul_Click(object sender, EventArgs e)
        {
            Color colorActual = BackColor;
            if (colorActual == Color.Yellow)
            {
                this.BackColor = Color.Green;
            }
            else if (colorActual == Color.Blue)
            {
                this.BackColor = Color.Blue;
            }
            else if (colorActual == Color.Red)
            {
                this.BackColor = Color.Purple;
            }
            else if (colorActual == Color.Orange)
            {
                this.BackColor = Color.Black;
            }
            else if (colorActual == Color.Purple)
            {
                this.BackColor = Color.Blue;
            }
            else
            {
                this.BackColor = Color.Blue;
            }
            azulRequerido = int.Parse(lAzul.Text);
            azulRequerido++;
            lAzul.Text = azulRequerido.ToString();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            string primerLugar, segundoLugar, tercerLugar;
            int primerSumatoria, segundoSumatoria, tercerSumatoria;

            if (amarilloRequerido >= rojoRequerido && amarilloRequerido >= azulRequerido)
            {
                primerLugar = "Amarillo";
                primerSumatoria = amarilloRequerido;
                if (rojoRequerido >= azulRequerido)
                {
                    segundoLugar = "Rojo";
                    segundoSumatoria = rojoRequerido;
                    tercerLugar = "Azul";
                    tercerSumatoria = azulRequerido;
                }
                else
                {
                    segundoLugar = "Azul";
                    segundoSumatoria = azulRequerido;
                    tercerLugar = "Rojo";
                    tercerSumatoria = rojoRequerido;
                }
            }
            else if (rojoRequerido >= amarilloRequerido && rojoRequerido >= azulRequerido)
            {
                primerLugar = "Rojo";
                primerSumatoria = rojoRequerido;
                if (amarilloRequerido >= azulRequerido)
                {
                    segundoLugar = "Amarillo";
                    segundoSumatoria = amarilloRequerido;
                    tercerLugar = "Azul";
                    tercerSumatoria = azulRequerido;
                }
                else
                {
                    segundoLugar = "Azul";
                    segundoSumatoria = azulRequerido;
                    tercerLugar = "Amarillo";
                    tercerSumatoria = amarilloRequerido;
                }
            }
            else
            {
                primerLugar = "Azul";
                primerSumatoria = azulRequerido;
                if (amarilloRequerido >= rojoRequerido)
                {
                    segundoLugar = "Amarillo";
                    segundoSumatoria = amarilloRequerido;
                    tercerLugar = "Rojo";
                    tercerSumatoria = rojoRequerido;
                }
                else
                {
                    segundoLugar = "Rojo";
                    segundoSumatoria = rojoRequerido;
                    tercerLugar = "Amarillo";
                    tercerSumatoria = amarilloRequerido;
                }
            }

            string mensaje = $"1°. - Color \"{primerLugar}\": {primerSumatoria} veces\n" +
                             $"2°. - Color \"{segundoLugar}\": {segundoSumatoria} veces\n" +
                             $"3°. - Color \"{tercerLugar}\": {tercerSumatoria} veces";

            MessageBox.Show("Ranking de Colores Primarios" + "\n" +mensaje);
            Close();
        }
    }
}

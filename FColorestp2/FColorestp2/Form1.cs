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
            Color colorActual = this.BackColor;
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
                this.BackColor = Color.Black;
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
            amarilloRequerido++;
        }

        private void BRojo_Click(object sender, EventArgs e)
        {
            Color colorActual = this.BackColor;
            if (colorActual == Color.Orange)
            {
                this.BackColor = Color.Red;
            }
            else if (colorActual == Color.Purple)
            {
                this.BackColor = Color.Black;
            }
            else if (colorActual == Color.Yellow)
            {
                this.BackColor = Color.Orange;
            }
            else if (colorActual == Color.Green)
            {
                this.BackColor = Color.Yellow;
            }
            else if (colorActual == Color.Blue)
            {
                this.BackColor = Color.Purple;
            }
            else
            {
                this.BackColor = Color.Red;
            }
            rojoRequerido++;
        }

        private void Bazul_Click(object sender, EventArgs e)
        {
            Color colorActual = this.BackColor;
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
                this.BackColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.Blue;
            }
            azulRequerido++;
        }
    }
}

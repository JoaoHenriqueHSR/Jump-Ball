using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME
{
    public partial class Form1 : Form
    {
        int picMainPos;
        int picObt1;
        int picObt2;
        int gravidade = 1;
        int velocidade = 0;
        int velociadePulo = -20;
        int qtdPulo = 1;
        int ponto;
        bool passouObt1;
        bool passouObt2;
        SoundPlayer pop;
        public Form1()
        {
            InitializeComponent();
            picMainPos = picMain.Top;
            picObt1 = picObstaculo1.Left;
            picObt2 = picObstaculo2.Left;
            NovoJogo();
        }

        private void NovoJogo()
        {
            picMain.Top = picMainPos;
            picObstaculo1.Left = picObt1;
            picObstaculo2.Left = picObt2;
            velocidade = 0;
            gravidade = 1;
            timer1.Stop();
            picMain.Visible = true;
            lbPonto.Text = "0";
            lbPonto.Visible = false;
            lbStart.Visible = true;
            ponto = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            velocidade += gravidade;
            picMain.Top += velocidade;
            if (picMain.Bottom > this.ClientSize.Height)
            {
                picMain.Top = picMainPos;
                velocidade = 0;
            }

            picObstaculo1.Left -= 5;
            picObstaculo2.Left -= 5;

            if (picObstaculo1.Right < 0)
            {
                picObstaculo1.Left = this.ClientSize.Width;
                passouObt1 = false;
            }

            if (picObstaculo2.Right < 0)
            {
                picObstaculo2.Left = this.ClientSize.Width;
                passouObt2 = false;
            }

            if (picMain.Right > picObstaculo1.Left &&
                picMain.Bottom > picObstaculo1.Top &&
                picMain.Left < picObstaculo1.Right)
            {
                GamerOver();
            }

            if (picMain.Right > picObstaculo2.Left &&
                picMain.Bottom > picObstaculo2.Top &&
                picMain.Left < picObstaculo2.Right)
            {
                GamerOver();
            }


            if (!passouObt1 && picMain.Left > picObstaculo1.Right)
            {
                ponto++;
                lbPonto.Text = ponto.ToString();
                passouObt1 = true;
            }

            if (!passouObt2 && picMain.Left > picObstaculo2.Right)
            {
                ponto++;
                lbPonto.Text = ponto.ToString();
                passouObt2 = true;
            }
        }

        private void GamerOver()
        {
            pop= new SoundPlayer();
            pop.SoundLocation = "pop.wav";
            pop.Play();
            picMain.Visible = false;
            timer1.Stop();
            MessageBox.Show($"Você perdeu!\nPontos: {ponto}");
            NovoJogo();
        }

        

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            timer1.Start();
            lbPonto.Visible = true;
            lbStart.Visible = false;
            if (picMain.Bottom >= this.ClientSize.Height)
            {
                qtdPulo = 1;
            }

            if (qtdPulo > 0)
            {
                velocidade = velociadePulo;
                qtdPulo = 0;
            }
        }
    }
}

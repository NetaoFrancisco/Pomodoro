using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronomentro_Pomodoro
{
    public partial class Cronometro : Form
    {

        int segundos = 0;
        int horas = 0;
        int minutos = 0;
        int soma;


        public Cronometro()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            horas = Convert.ToInt32(textBox1.Text);
            soma = soma + (horas * 3600);

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }

        private void txtMinutos_TextChanged(object sender, EventArgs e)
        {
            minutos = Convert.ToInt32(txtMinutos.Text);
            soma = soma + (minutos * 60);


        }

        private void txtSegundos_TextChanged(object sender, EventArgs e)
        {
            segundos = Convert.ToInt32(txtSegundos.Text);
            soma = soma + segundos;



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            soma = soma - 1;

            lblCronomentro.Text = Convert.ToString(soma);
            if (soma == 0)
            {
                timer1.Stop();
                MessageBox.Show("Seu tempo acabou,agora faça a pausa de 5 minutos e faça outro objetivo ");

            }


        }

        private void lblCronomentro_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                {
                    //Se a tecla digitada não for número e nem backspace
                    if (!char.IsDigit(e.KeyChar))
                    {
                        //Atribui True no Handled para cancelar o evento
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtMinutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            {

                if (!char.IsDigit(e.KeyChar))
                {

                    e.Handled = true;
                }
            }
        }

        private void txtSegundos_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                //Se a tecla digitada não for número e nem backspace
                if (!char.IsDigit(e.KeyChar))
                {
                    //Atribui True no Handled para cancelar o evento
                    e.Handled = true;
                }
            }
        }

        private void lblHoras_Click(object sender, EventArgs e)
        {

        }

        private void btnLimparHoras_Click(object sender, EventArgs e)
        {


            

        }
       
    }
 }
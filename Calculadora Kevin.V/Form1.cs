﻿using System.Diagnostics.Eventing.Reader;

namespace Calculadoradefi
{

    public partial class Form1 : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char Operador;
        bool numeroElemento = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += boton.Text;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            numeroElemento = false;

            if (Operador == '+')
            {
                txtResultado.Text = (Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operador == '−')
            {
                txtResultado.Text = (Numero1 - Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operador == 'X')
            {
                txtResultado.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operador == '/')
            {
                if (txtResultado.Text != "o")

                {
                    txtResultado.Text = (Numero1 / Numero2).ToString();
                    Numero1 = Convert.ToDouble(txtResultado.Text);
                }
                else
                {
                    MessageBox.Show("No se peude dividir por 0");
                }
            }
        }
        private void buttonQuitar_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else
            {
                txtResultado.Text = "0";
            }
        }
        private void buttonBorrarTodo_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            Operador = '\0';
            txtResultado.Text = "0";

        }
        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
        }
        private void buttonPunto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains("."))
            {
                txtResultado.Text += ".";
            }


        }
        private void buttonSigno_Click(object sender, EventArgs e)
        {
            if (numeroElemento = false)
            {
                Numero1 = Convert.ToDouble(txtResultado.Text);
                Numero1 *= -1;
                txtResultado.Text = Numero1.ToString();
            }
            else
            {
                Numero2 = Convert.ToDouble(txtResultado.Text);
                Numero2 *= -1;
                txtResultado.Text = Numero2.ToString();
            }
        }



        private void clickoperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            Numero1 = Convert.ToDouble(txtResultado.Text);
            Operador = Convert.ToChar(boton.Tag);


            if (Operador == '²')
            {
                Numero1 = Math.Pow(Numero1, 2);
                txtResultado.Text = Numero1.ToString();
            }
            else if (Operador == '√')
            {
                Numero1 = Math.Sqrt(Numero1);
                txtResultado.Text = Numero1.ToString();
            }
            else
            {

                txtResultado.Text = "0";

            }
        }


    }
}


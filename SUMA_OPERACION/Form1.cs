using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUMA_OPERACION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            bool txt1Es_Numero, txt2Es_Numero;
            double Num1 = 0, Num2 = 0;
            

            if (txtPrimerNum.Text == string.Empty || txtSegundoNum.Text == string.Empty)
            {
                MessageBox.Show("llene todos los textBox para poder hacer la suma");
            }
            if(txtPrimerNum.Text != string.Empty && txtSegundoNum.Text != string.Empty)
            {
                txt1Es_Numero = EsNumero(txtPrimerNum.Text);
                txt2Es_Numero = EsNumero(txtSegundoNum.Text);
                if (txt1Es_Numero)
                {
                    Num1 = Convert.ToDouble(txtPrimerNum.Text);
                    lblVadiartxt1.Text = "CORRECTO";

                }
                else
                {
                    lblVadiartxt1.Text = "INCORRECTO, NO PUEDE Contener Letras";
                    txtPrimerNum.Text = "";
                }
                if(txt2Es_Numero)
                {
                    Num2 = Convert.ToDouble(txtSegundoNum.Text);
                    lblValidarTxt2.Text = "CORRECTO ";
                }
                else
                {
                    lblValidarTxt2.Text = "INCORRECTO, NO PUEDE Contener Letras";
                    txtSegundoNum.Text = "";
                }

                if (txt1Es_Numero && txt2Es_Numero)
                {
                    lblResultado.Text = "" +(Num1 + Num2);//Convert.ToString(Num1+Num2);
                    Limpiar();
                }
            }
            
        }


        private void Limpiar()
        {
            txtPrimerNum.Text = string.Empty;
            txtSegundoNum.Text = String.Empty;
        }

        private bool EsNumero(string texto)
        {
            bool respuesta;

            respuesta = double.TryParse(texto, out double Num);

            return respuesta;
        }
    }
}

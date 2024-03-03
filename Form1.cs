using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        //Funcion que permite determinar la operacion a realizar.
        public double operacion()
        {   
            switch(signo)
            {
                case '+': return num1 + num2; 
                case '-': return num1 - num2;
                case '*': return num1 * num2;
                case '/': if(num2 == 0)
                    {
                        label1.Text = "No se puede dividir entre 0";
                        error = true;
                        return 0;

                    }
                    return num1 / num2;
            }
            return 0;
        }

        private void btn_off_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            //Si hay un error, limpia la caja de texto y el historial.
            if(tbx_result.Text == "ERROR")
            {
                tbx_result.Text = "";
                label1.Text = "Historial";
                num1 = 0;
                num2 = 0;
            }

            if(btn_delete.Enabled == false)
            {
                tbx_result.Text = "";
                btn_delete.Enabled = true;
            }

            if (tbx_result.Text == "0")
            {
                tbx_result.Text = "1";
            }
            else
            {
                tbx_result.Text += "1";
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            //Si hay un error, limpia la caja de texto y el historial.
            if (tbx_result.Text == "ERROR")
            {
                tbx_result.Text = "";
                label1.Text = "Historial";
                num1 = 0;
                num2 = 0;
            }

            if (btn_delete.Enabled == false)
            {
                tbx_result.Text = "";
                btn_delete.Enabled = true;
            }

            if (tbx_result.Text == "0")
            {
                tbx_result.Text = "2";
            }
            else
            {
                tbx_result.Text += "2";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            //Si hay un error, limpia la caja de texto y el historial.
            if (tbx_result.Text == "ERROR")
            {
                tbx_result.Text = "";
                label1.Text = "Historial";
                num1 = 0;
                num2 = 0;
            }

            if (btn_delete.Enabled == false)
            {
                tbx_result.Text = "";
                btn_delete.Enabled = true;
            }

            if (tbx_result.Text == "0")
            {
                tbx_result.Text = "3";
            }
            else
            {
                tbx_result.Text += "3";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            //Si hay un error, limpia la caja de texto y el historial.
            if (tbx_result.Text == "ERROR")
            {
                tbx_result.Text = "";
                label1.Text = "Historial";
                num1 = 0;
                num2 = 0;
            }

            if (btn_delete.Enabled == false)
            {
                tbx_result.Text = "";
                btn_delete.Enabled = true;
            }

            if (tbx_result.Text == "0")
            {
                tbx_result.Text = "4";
            }
            else
            {
                tbx_result.Text += "4";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            //Si hay un error, limpia la caja de texto y el historial.
            if (tbx_result.Text == "ERROR")
            {
                tbx_result.Text = "";
                label1.Text = "Historial";
                num1 = 0;
                num2 = 0;
            }

            if (btn_delete.Enabled == false)
            {
                tbx_result.Text = "";
                btn_delete.Enabled = true;
            }

            if (tbx_result.Text == "0")
            {
                tbx_result.Text = "5";
            }
            else
            {
                tbx_result.Text += "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            //Si hay un error, limpia la caja de texto y el historial.
            if (tbx_result.Text == "ERROR")
            {
                tbx_result.Text = "";
                label1.Text = "Historial";
                num1 = 0;
                num2 = 0;
            }

            if (btn_delete.Enabled == false)
            {
                tbx_result.Text = "";
                btn_delete.Enabled = true;
            }

            if (tbx_result.Text == "0")
            {
                tbx_result.Text = "6";
            }
            else
            {
                tbx_result.Text += "6";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            //Si hay un error, limpia la caja de texto y el historial.
            if (tbx_result.Text == "ERROR")
            {
                tbx_result.Text = "";
                label1.Text = "Historial";
                num1 = 0;
                num2 = 0;
            }

            if (btn_delete.Enabled == false)
            {
                tbx_result.Text = "";
                btn_delete.Enabled = true;
            }

            if (tbx_result.Text == "0")
            {
                tbx_result.Text = "7";
            }
            else
            {
                tbx_result.Text += "7";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            //Si hay un error, limpia la caja de texto y el historial.
            if (tbx_result.Text == "ERROR")
            {
                tbx_result.Text = "";
                label1.Text = "Historial";
                num1 = 0;
                num2 = 0;
            }

            if (btn_delete.Enabled == false)
            {
                tbx_result.Text = "";
                btn_delete.Enabled = true;
            }

            if (tbx_result.Text == "0")
            {
                tbx_result.Text = "8";
            }
            else
            {
                tbx_result.Text += "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            //Si hay un error, limpia la caja de texto y el historial.
            if (tbx_result.Text == "ERROR")
            {
                tbx_result.Text = "";
                label1.Text = "Historial";
                num1 = 0;
                num2 = 0;
            }

            if (btn_delete.Enabled == false)
            {
                tbx_result.Text = "";
                btn_delete.Enabled = true;
            }
            if (tbx_result.Text == "0") {
                tbx_result.Text = "9";
            }
            else
            {
                tbx_result.Text += "9";
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            //Si hay un error, limpia la caja de texto y el historial.
            if (tbx_result.Text == "ERROR")
            {
                tbx_result.Text = "";
                label1.Text = "Historial";
                num1 = 0;
                num2 = 0;
            }

            if (btn_delete.Enabled == false)
            {
                tbx_result.Text = "0";
                btn_delete.Enabled = true;
            }

            else
            {
                //Si hay solo un 0, no se concatena el 0.
                if (tbx_result.Text != "0")
                {
                    tbx_result.Text += "0";
                }  tbx_result.Text = "0";
            }
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            //Si hay un error, limpia la caja de texto y el historial.
            if (tbx_result.Text == "ERROR")
            {
                tbx_result.Text = "";
                label1.Text = "Historial";
                num1 = 0;
                num2 = 0;
            }

            if (btn_delete.Enabled == false)
            {
                tbx_result.Text = "";
                btn_delete.Enabled = true;
            }

            tbx_result.Text += ".";

            //Solo se puede tener un punto, por lo cual deshabilita el boton.
            btn_dot.Enabled = false;
        }

        private void btn_switch_Click(object sender, EventArgs e)
        {       
            //Cambia el signo de los valores, negativo/positivo.
            if(tbx_result.Text != "")
            {
                //Si solo hay un punto no se activa.
                if(tbx_result.Text != ".")
                {
                    tbx_result.Text = Convert.ToString(-1 * Convert.ToDouble(tbx_result.Text));
                }
            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(tbx_result.Text != "0")
            {
                //Si el digito es un . vuelve habilitar el boton .
                if (tbx_result.Text[tbx_result.Text.Length - 1] == '.')
                {
                    btn_dot.Enabled = true;
                }

                tbx_result.Text = tbx_result.Text.Remove(tbx_result.Text.Length - 1);
            }

            //Si el txtbox es vacio pone un 0.
            if(tbx_result.Text == "")
            {
                tbx_result.Text = "0";
            }
        }

        //Funcion que limpia todo al darle al boton "limpiar".
        private void btn_clean_Click(object sender, EventArgs e)
        {
            tbx_result.Text = "0";
            label1.Text = "Historial";
            btn_dot.Enabled = true;
            btn_delete.Enabled = true;
            num1 = 0;
            num2 = 0;
        }

         private void btn_suma_Click(object sender, EventArgs e)
         {
            if (tbx_result.Text != "0")
            {
                if (signo == 'n')
                {
                    label1.Text = "";
                    num1 = Convert.ToDouble(tbx_result.Text);
                    signo = '+';
                    label1.Text += tbx_result.Text + signo;
                }
                else
                {
                    num2 = Convert.ToDouble(tbx_result.Text);
                    label1.Text += tbx_result.Text + signo;
                    tbx_result.Text = Convert.ToString(operacion());

                    if (error)
                    {
                        num1 = 0;
                        signo = 'n';
                        error = false;
                    }
                    else
                    {
                        num1 = Convert.ToDouble(tbx_result.Text);
                        signo = '+';

                    }
                }

                tbx_result.Text = "0";
                btn_dot.Enabled = true;
                btn_delete.Enabled = false;
            }
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            if (tbx_result.Text != "0")
            {
                if (signo == 'n')
                {
                    label1.Text = "";
                    num1 = Convert.ToDouble(tbx_result.Text);
                    signo = '-';
                    label1.Text += tbx_result.Text + signo;
                }
                else
                {
                    num2 = Convert.ToDouble(tbx_result.Text);
                    label1.Text += tbx_result.Text + signo;
                    tbx_result.Text = Convert.ToString(operacion());

                    if (error)
                    {
                        num1 = 0;
                        signo = 'n';
                        error = false;
                    }
                    else
                    {
                        num1 = Convert.ToDouble(tbx_result.Text);
                        signo = '-';

                    }
                }

                tbx_result.Text = "0";
                btn_dot.Enabled = true;
                btn_delete.Enabled = false;
            }
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            if (tbx_result.Text != "0")
            {
                if (signo == 'n')
                {
                    label1.Text = "";
                    num1 = Convert.ToDouble(tbx_result.Text);
                    signo = '*';
                    label1.Text += tbx_result.Text + signo;
                }
                else
                {
                    num2 = Convert.ToDouble(tbx_result.Text);
                    label1.Text += tbx_result.Text + signo;
                    tbx_result.Text = Convert.ToString(operacion());

                    if (error)
                    {
                        num1 = 0;
                        signo = 'n';
                        error = false;
                    }
                    else
                    {
                        num1 = Convert.ToDouble(tbx_result.Text);
                        signo = '*';

                    }
                }

                tbx_result.Text = "0";
                btn_dot.Enabled = true;
                btn_delete.Enabled = false;
            }
        }

        /*private void btn_division_Click(object sender, EventArgs e)
        {
            //hace una comprobacion para realizar una operacion solo si ya se agrego un valor.
            if (tbx_result.Text != "0" && signo == 'n')
            {
                signo = '/';
                num1 = Convert.ToDouble(tbx_result.Text);
                label1.Text = tbx_result.Text + " / ";
                tbx_result.Text = "0";
            }
        }*/

        private void btn_division_Click(object sender, EventArgs e)
        {
            if(tbx_result.Text != "0")
            {
                if(signo == 'n')
                {
                    label1.Text = "";
                    num1 = Convert.ToDouble(tbx_result.Text);
                    signo = '/';
                    label1.Text += tbx_result.Text + signo;
                }
                else
                {
                    num2 = Convert.ToDouble(tbx_result.Text);
                    label1.Text += tbx_result.Text + signo;
                    tbx_result.Text = Convert.ToString(operacion());

                    if (error)
                    {
                        num1 = 0;
                        signo = 'n';
                        error = false;
                    }
                    else
                    {
                        num1 = Convert.ToDouble(tbx_result.Text);
                        signo = '/';

                    }
                }

                tbx_result.Text = "0";
                btn_dot.Enabled = true;
                btn_delete.Enabled = false;
            }
        }

        //Funcion que realiza la operacion al darle al boton "=".
        private void btn_total_Click(object sender, EventArgs e)
        {
            if(signo != 'n' && tbx_result.Text != "n")
            {
                num2 = Convert.ToDouble(tbx_result.Text);
                label1.Text += tbx_result.Text + " = ";
                tbx_result.Text = Convert.ToString(operacion());

                if(error)
                {
                    tbx_result.Text = "ERROR";
                    num1 = 0;
                    error = false;
                }
                else
                {
                    num1 = Convert.ToDouble(tbx_result.Text);
                }

                num2 = 0;
                signo = 'n';
                btn_dot.Enabled=true;
                btn_delete.Enabled=false;
            }
        }
    }
}

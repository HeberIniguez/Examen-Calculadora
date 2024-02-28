using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    
    public partial class Calculadora : Form
    {
        //Variables Globales
        double num1;
        double num2;
        double resultado;
        char signo;

        public Calculadora()
        {
            InitializeComponent();
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
            }

            if (btn_delete.Enabled == false)
            {
                tbx_result.Text = "";
                btn_delete.Enabled = true;
            }

            //Si no hay solo un 0, no se concatena el cero.
            if(tbx_result.Text != "0")
            {
                tbx_result.Text += "0";
            }
            
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            //Si hay un error, limpia la caja de texto y el historial.
            if (tbx_result.Text == "ERROR")
            {
                tbx_result.Text = "";
                label1.Text = "Historial";
            }

            if (btn_delete.Enabled == false)
            {
                tbx_result.Text = "";
                btn_delete.Enabled = true;
            }

            tbx_result.Text += ".";
            btn_dot.Enabled = false;
        }

        private void btn_switch_Click(object sender, EventArgs e)
        {       
            //Cambia el signo de los valores, negativo/positivo.
            if(tbx_result.Text != "")
            {
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
                if(tbx_result.Text[tbx_result.Text.Length - 1] == '.')
                {
                    btn_dot.Enabled = true;
                }
                tbx_result.Text = tbx_result.Text.Remove(tbx_result.Text.Length - 1);
            }

            //Si el ultimo digito es vacio pone un 0.
            if(tbx_result.Text == "")
            {
                tbx_result.Text = "0";
            }
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            tbx_result.Text = "";
            label1.Text = "Historial";
            btn_dot.Enabled = true;
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            //Si hay un error, limpia la caja de texto y el historial.
            if (tbx_result.Text == "ERROR")
            {
                tbx_result.Text = "";
                label1.Text = "Historial";
            }

            if (btn_delete.Enabled == false)
            {
                tbx_result.Text = "";
                btn_delete.Enabled = true;
            }

            if (tbx_result.Text != "0")
            {
                if(label1.Text != "Historial")
                {
                    num2 = Convert.ToDouble(tbx_result.Text);
                    num1 += num2; 
                }
                else
                {
                    num1 = Convert.ToDouble(tbx_result.Text);
                }

                signo = '+';
                label1.Text =  Convert.ToString(num1) + "+";
                tbx_result.Text = "0";
            }
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {

        }

        private void btn_multi_Click(object sender, EventArgs e)
        {

        }

        private void btn_division_Click(object sender, EventArgs e)
        {

        }

        private void btn_total_Click(object sender, EventArgs e)
        {

        }
    }
}

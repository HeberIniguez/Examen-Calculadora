namespace Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        double num1 = 0;
        double num2 = 0;
        bool error = false;
        char signo = 'n';

        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.btn_switch = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.btn_total = new System.Windows.Forms.Button();
            this.btn_suma = new System.Windows.Forms.Button();
            this.btn_resta = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clean = new System.Windows.Forms.Button();
            this.btn_off = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_switch
            // 
            this.btn_switch.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_switch.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_switch.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_switch.Location = new System.Drawing.Point(10, 356);
            this.btn_switch.Name = "btn_switch";
            this.btn_switch.Size = new System.Drawing.Size(72, 64);
            this.btn_switch.TabIndex = 1;
            this.btn_switch.Text = "+/-";
            this.btn_switch.UseVisualStyleBackColor = false;
            this.btn_switch.Click += new System.EventHandler(this.btn_switch_Click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_0.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_0.Location = new System.Drawing.Point(88, 356);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(74, 64);
            this.btn_0.TabIndex = 2;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_dot
            // 
            this.btn_dot.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_dot.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dot.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_dot.Location = new System.Drawing.Point(167, 356);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(72, 64);
            this.btn_dot.TabIndex = 3;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = false;
            this.btn_dot.Click += new System.EventHandler(this.btn_dot_Click);
            // 
            // btn_total
            // 
            this.btn_total.BackColor = System.Drawing.Color.Turquoise;
            this.btn_total.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_total.Location = new System.Drawing.Point(244, 356);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(68, 64);
            this.btn_total.TabIndex = 4;
            this.btn_total.Text = "=";
            this.btn_total.UseVisualStyleBackColor = false;
            this.btn_total.Click += new System.EventHandler(this.btn_total_Click);
            // 
            // btn_suma
            // 
            this.btn_suma.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_suma.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn_suma.FlatAppearance.BorderSize = 15;
            this.btn_suma.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suma.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_suma.Location = new System.Drawing.Point(244, 286);
            this.btn_suma.Name = "btn_suma";
            this.btn_suma.Size = new System.Drawing.Size(68, 64);
            this.btn_suma.TabIndex = 5;
            this.btn_suma.Text = "+";
            this.btn_suma.UseVisualStyleBackColor = false;
            this.btn_suma.Click += new System.EventHandler(this.btn_suma_Click);
            // 
            // btn_resta
            // 
            this.btn_resta.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_resta.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resta.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_resta.Location = new System.Drawing.Point(244, 217);
            this.btn_resta.Name = "btn_resta";
            this.btn_resta.Size = new System.Drawing.Size(68, 64);
            this.btn_resta.TabIndex = 6;
            this.btn_resta.Text = "-";
            this.btn_resta.UseVisualStyleBackColor = false;
            this.btn_resta.Click += new System.EventHandler(this.btn_resta_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_multi.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multi.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_multi.Location = new System.Drawing.Point(244, 147);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(68, 64);
            this.btn_multi.TabIndex = 7;
            this.btn_multi.Text = "*";
            this.btn_multi.UseVisualStyleBackColor = false;
            this.btn_multi.Click += new System.EventHandler(this.btn_multi_Click);
            // 
            // btn_division
            // 
            this.btn_division.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_division.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_division.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_division.Location = new System.Drawing.Point(244, 107);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(68, 34);
            this.btn_division.TabIndex = 8;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = false;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_delete.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_delete.Location = new System.Drawing.Point(167, 107);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(72, 34);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "BORRAR";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clean
            // 
            this.btn_clean.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_clean.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clean.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_clean.Location = new System.Drawing.Point(88, 107);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(74, 34);
            this.btn_clean.TabIndex = 10;
            this.btn_clean.Text = "LIMPIAR";
            this.btn_clean.UseVisualStyleBackColor = false;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // btn_off
            // 
            this.btn_off.BackColor = System.Drawing.Color.Red;
            this.btn_off.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_off.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_off.Location = new System.Drawing.Point(10, 107);
            this.btn_off.Name = "btn_off";
            this.btn_off.Size = new System.Drawing.Size(72, 34);
            this.btn_off.TabIndex = 11;
            this.btn_off.Text = "Salir";
            this.btn_off.UseVisualStyleBackColor = false;
            this.btn_off.Click += new System.EventHandler(this.btn_off_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_7.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_7.Location = new System.Drawing.Point(10, 147);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(72, 64);
            this.btn_7.TabIndex = 16;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_4.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_4.Location = new System.Drawing.Point(10, 217);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(72, 64);
            this.btn_4.TabIndex = 17;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_1.Location = new System.Drawing.Point(10, 286);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(72, 64);
            this.btn_1.TabIndex = 18;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_8.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_8.Location = new System.Drawing.Point(88, 147);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(74, 64);
            this.btn_8.TabIndex = 19;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_5.Location = new System.Drawing.Point(88, 217);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(74, 64);
            this.btn_5.TabIndex = 20;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_2.Location = new System.Drawing.Point(88, 286);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(74, 64);
            this.btn_2.TabIndex = 21;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_9.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_9.Location = new System.Drawing.Point(167, 147);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(72, 64);
            this.btn_9.TabIndex = 22;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_6.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_6.Location = new System.Drawing.Point(167, 217);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(72, 64);
            this.btn_6.TabIndex = 23;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_3.Location = new System.Drawing.Point(167, 286);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(72, 64);
            this.btn_3.TabIndex = 24;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Historial";
            // 
            // tbx_result
            // 
            this.tbx_result.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbx_result.Enabled = false;
            this.tbx_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_result.ForeColor = System.Drawing.Color.Cyan;
            this.tbx_result.Location = new System.Drawing.Point(10, 47);
            this.tbx_result.Name = "tbx_result";
            this.tbx_result.Size = new System.Drawing.Size(302, 45);
            this.tbx_result.TabIndex = 27;
            this.tbx_result.Text = "0";
            this.tbx_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(323, 439);
            this.Controls.Add(this.tbx_result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_off);
            this.Controls.Add(this.btn_clean);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_resta);
            this.Controls.Add(this.btn_suma);
            this.Controls.Add(this.btn_total);
            this.Controls.Add(this.btn_dot);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_switch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_switch;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_dot;
        private System.Windows.Forms.Button btn_total;
        private System.Windows.Forms.Button btn_suma;
        private System.Windows.Forms.Button btn_resta;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button btn_off;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_result;
    }
}


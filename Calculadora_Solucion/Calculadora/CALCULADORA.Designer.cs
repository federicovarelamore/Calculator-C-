namespace Calculadora
{
    partial class CALCULADORA
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnborrarTotal = new System.Windows.Forms.Button();
            this.btnN8 = new System.Windows.Forms.Button();
            this.btnN9 = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnN7 = new System.Windows.Forms.Button();
            this.btnN5 = new System.Windows.Forms.Button();
            this.btnN6 = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnN4 = new System.Windows.Forms.Button();
            this.btnN2 = new System.Windows.Forms.Button();
            this.btnN3 = new System.Windows.Forms.Button();
            this.btnN1 = new System.Windows.Forms.Button();
            this.btnN0 = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.txtScreen = new System.Windows.Forms.TextBox();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnSigno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnborrarTotal
            // 
            this.btnborrarTotal.BackColor = System.Drawing.Color.IndianRed;
            this.btnborrarTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnborrarTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnborrarTotal.Location = new System.Drawing.Point(54, 59);
            this.btnborrarTotal.Name = "btnborrarTotal";
            this.btnborrarTotal.Size = new System.Drawing.Size(47, 47);
            this.btnborrarTotal.TabIndex = 15;
            this.btnborrarTotal.Text = "C";
            this.btnborrarTotal.UseVisualStyleBackColor = false;
            // 
            // btnN8
            // 
            this.btnN8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnN8.Location = new System.Drawing.Point(54, 112);
            this.btnN8.Name = "btnN8";
            this.btnN8.Size = new System.Drawing.Size(47, 47);
            this.btnN8.TabIndex = 8;
            this.btnN8.Text = "8";
            this.btnN8.UseVisualStyleBackColor = false;
            this.btnN8.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnN9
            // 
            this.btnN9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnN9.Location = new System.Drawing.Point(105, 112);
            this.btnN9.Name = "btnN9";
            this.btnN9.Size = new System.Drawing.Size(47, 47);
            this.btnN9.TabIndex = 9;
            this.btnN9.Text = "9";
            this.btnN9.UseVisualStyleBackColor = false;
            this.btnN9.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.IndianRed;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.Location = new System.Drawing.Point(3, 59);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(47, 47);
            this.btnBorrar.TabIndex = 17;
            this.btnBorrar.Text = "CE";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrarTotal_Click);
            // 
            // btnN7
            // 
            this.btnN7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnN7.Location = new System.Drawing.Point(3, 112);
            this.btnN7.Name = "btnN7";
            this.btnN7.Size = new System.Drawing.Size(47, 47);
            this.btnN7.TabIndex = 7;
            this.btnN7.Text = "7";
            this.btnN7.UseVisualStyleBackColor = false;
            this.btnN7.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnN5
            // 
            this.btnN5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnN5.Location = new System.Drawing.Point(54, 163);
            this.btnN5.Name = "btnN5";
            this.btnN5.Size = new System.Drawing.Size(47, 47);
            this.btnN5.TabIndex = 5;
            this.btnN5.Text = "5";
            this.btnN5.UseVisualStyleBackColor = false;
            this.btnN5.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnN6
            // 
            this.btnN6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnN6.Location = new System.Drawing.Point(105, 163);
            this.btnN6.Name = "btnN6";
            this.btnN6.Size = new System.Drawing.Size(47, 47);
            this.btnN6.TabIndex = 6;
            this.btnN6.Text = "6";
            this.btnN6.UseVisualStyleBackColor = false;
            this.btnN6.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.IndianRed;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuitar.Location = new System.Drawing.Point(105, 59);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(47, 47);
            this.btnQuitar.TabIndex = 16;
            this.btnQuitar.Text = "←";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click_1);
            // 
            // btnN4
            // 
            this.btnN4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnN4.Location = new System.Drawing.Point(3, 163);
            this.btnN4.Name = "btnN4";
            this.btnN4.Size = new System.Drawing.Size(47, 47);
            this.btnN4.TabIndex = 4;
            this.btnN4.Text = "4";
            this.btnN4.UseVisualStyleBackColor = false;
            this.btnN4.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnN2
            // 
            this.btnN2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnN2.Location = new System.Drawing.Point(54, 214);
            this.btnN2.Name = "btnN2";
            this.btnN2.Size = new System.Drawing.Size(47, 47);
            this.btnN2.TabIndex = 2;
            this.btnN2.Text = "2";
            this.btnN2.UseVisualStyleBackColor = false;
            this.btnN2.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnN3
            // 
            this.btnN3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnN3.Location = new System.Drawing.Point(105, 214);
            this.btnN3.Name = "btnN3";
            this.btnN3.Size = new System.Drawing.Size(47, 47);
            this.btnN3.TabIndex = 3;
            this.btnN3.Text = "3";
            this.btnN3.UseVisualStyleBackColor = false;
            this.btnN3.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnN1
            // 
            this.btnN1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnN1.Location = new System.Drawing.Point(3, 214);
            this.btnN1.Name = "btnN1";
            this.btnN1.Size = new System.Drawing.Size(47, 47);
            this.btnN1.TabIndex = 1;
            this.btnN1.Text = "1";
            this.btnN1.UseVisualStyleBackColor = false;
            this.btnN1.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnN0
            // 
            this.btnN0.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnN0.Location = new System.Drawing.Point(54, 263);
            this.btnN0.Name = "btnN0";
            this.btnN0.Size = new System.Drawing.Size(47, 47);
            this.btnN0.TabIndex = 10;
            this.btnN0.Text = "0";
            this.btnN0.UseVisualStyleBackColor = false;
            this.btnN0.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnPunto
            // 
            this.btnPunto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPunto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPunto.Location = new System.Drawing.Point(105, 263);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(47, 47);
            this.btnPunto.TabIndex = 11;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIgual.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIgual.Location = new System.Drawing.Point(182, 214);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(100, 47);
            this.btnIgual.TabIndex = 18;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // txtScreen
            // 
            this.txtScreen.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScreen.Font = new System.Drawing.Font("DS-Digital", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtScreen.Location = new System.Drawing.Point(3, 2);
            this.txtScreen.MaxLength = 16;
            this.txtScreen.Name = "txtScreen";
            this.txtScreen.ReadOnly = true;
            this.txtScreen.Size = new System.Drawing.Size(279, 42);
            this.txtScreen.TabIndex = 20;
            this.txtScreen.Text = "0";
            this.txtScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRaiz
            // 
            this.btnRaiz.BackColor = System.Drawing.Color.IndianRed;
            this.btnRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRaiz.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRaiz.Location = new System.Drawing.Point(182, 59);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(47, 47);
            this.btnRaiz.TabIndex = 21;
            this.btnRaiz.Tag = "√";
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = false;
            this.btnRaiz.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.BackColor = System.Drawing.Color.IndianRed;
            this.btnCuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCuadrado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCuadrado.Location = new System.Drawing.Point(235, 59);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(47, 47);
            this.btnCuadrado.TabIndex = 22;
            this.btnCuadrado.Tag = "²";
            this.btnCuadrado.Text = "x²";
            this.btnCuadrado.UseVisualStyleBackColor = false;
            this.btnCuadrado.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.IndianRed;
            this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiplicar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplicar.Location = new System.Drawing.Point(235, 112);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(47, 47);
            this.btnMultiplicar.TabIndex = 24;
            this.btnMultiplicar.Tag = "×";
            this.btnMultiplicar.Text = "×";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.IndianRed;
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDividir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDividir.Location = new System.Drawing.Point(182, 112);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(47, 47);
            this.btnDividir.TabIndex = 23;
            this.btnDividir.Tag = "⁄";
            this.btnDividir.Text = "⁄";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.IndianRed;
            this.btnResta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResta.Location = new System.Drawing.Point(235, 163);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(47, 47);
            this.btnResta.TabIndex = 26;
            this.btnResta.Tag = "−";
            this.btnResta.Text = "−";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.IndianRed;
            this.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuma.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuma.Location = new System.Drawing.Point(182, 163);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(47, 47);
            this.btnSuma.TabIndex = 27;
            this.btnSuma.Tag = "+";
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnSigno
            // 
            this.btnSigno.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSigno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSigno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSigno.Location = new System.Drawing.Point(3, 264);
            this.btnSigno.Name = "btnSigno";
            this.btnSigno.Size = new System.Drawing.Size(47, 46);
            this.btnSigno.TabIndex = 28;
            this.btnSigno.Text = "+⁄−";
            this.btnSigno.UseVisualStyleBackColor = false;
            // 
            // CALCULADORA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 315);
            this.Controls.Add(this.btnSigno);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnCuadrado);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.txtScreen);
            this.Controls.Add(this.btnN0);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnN2);
            this.Controls.Add(this.btnN3);
            this.Controls.Add(this.btnN1);
            this.Controls.Add(this.btnN5);
            this.Controls.Add(this.btnN6);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnN4);
            this.Controls.Add(this.btnN8);
            this.Controls.Add(this.btnN9);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnN7);
            this.Controls.Add(this.btnborrarTotal);
            this.MaximizeBox = false;
            this.Name = "CALCULADORA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALC";
            this.Load += new System.EventHandler(this.CALCULADORA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnborrarTotal;
        private Button btnN8;
        private Button btnN9;
        private Button btnBorrar;
        private Button btnN7;
        private Button btnN5;
        private Button btnN6;
        private Button btnQuitar;
        private Button btnN4;
        private Button btnN2;
        private Button btnN3;
        private Button btnN1;
        private Button btnN0;
        private Button btnPunto;
        private Button btnIgual;
        private TextBox txtScreen;
        private Button btnRaiz;
        private Button btnCuadrado;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnResta;
        private Button btnSuma;
        private Button btnSigno;
    }
}
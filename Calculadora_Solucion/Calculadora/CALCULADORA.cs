namespace Calculadora
{
    public partial class CALCULADORA : Form
    {
        double primero = 0, segundo = 0;

        char operador;
        public CALCULADORA()
        {
            InitializeComponent();
        }

        Clases.ClsSuma objSuma = new Clases.ClsSuma();
        Clases.ClsResta objResta = new Clases.ClsResta();
        Clases.ClsDivision objDivision = new Clases.ClsDivision();
        Clases.ClsMultiplicacion objMultiplicacion = new Clases.ClsMultiplicacion();

        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (txtScreen.Text == "0")
            {
                txtScreen.Text = "";
            }
            txtScreen.Text += boton.Text;
        }

        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            primero = Convert.ToDouble(txtScreen.Text);
            operador = Convert.ToChar(boton.Tag);

            if (operador == '²')
            {
                primero = Math.Pow(primero, 2);
                txtScreen.Text = primero.ToString();
            }
            else if(operador == '√')
            {
                primero = Math.Sqrt(primero);
                txtScreen.Text = primero.ToString();
            }
            else
            {

                txtScreen.Text = "0";
            }
            
        }
        

        private void btnPunto_Click(object sender, EventArgs e)
        {
            
            if (!txtScreen.Text.Contains(".")) //primero verificamos que no contenga ningun punto decimal
            {
                if (txtScreen.Text.Length < 1) //luego que si el textbox esta vacio, que en ves de agregar un "." que agrege un "0."
                {
                    txtScreen.Text += "0.";
                }
                else
                {
                    txtScreen.Text += ".";
                }

            }
        }


        private void btnBorrarTotal_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txtScreen.Text);
            

            double Suma;
            double Resta;
            double Multiplicacion;
            double Division;

            switch (operador)
            {
                case '+':
                    Suma = objSuma.Sumar((primero), (segundo)); 
                    txtScreen.Text = Suma.ToString();
                    break;

                case '−': 
                    Resta = objResta.Restar((primero), (segundo));
                    txtScreen.Text = Resta.ToString();
                    break;

                case '×':
                     Multiplicacion = objMultiplicacion.Multiplicar((primero), (segundo));
                    txtScreen.Text = Multiplicacion.ToString();
                    break;

                case '⁄':
                    if(txtScreen.Text != "0")
                    {
                        Division = objDivision.Division((primero), (segundo));
                        txtScreen.Text = Division.ToString();
                        break;

                    }
                    else
                    {
                        MessageBox.Show("Error! no es posible dividir por 0", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    
            }

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text.Length > 1) //verificamos si el Textbox esta vacio, diciendole que si el número de cifras es mayor o igual a uno que borre.
            {
                txtScreen.Text = txtScreen.Text.Substring(0, txtScreen.Text.Count() - 1);
            } // de lo contrario este no borraria
        }



        private void CALCULADORA_Load(object sender, EventArgs e)
        {

        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {

        }

        private void btnborrarTotal_Click_1(object sender, EventArgs e)
        {
            primero = 0;
            segundo = 0;
            operador = '\0';
            txtScreen.Text = "";
        }

        private void btnSigno_Click(object sender, EventArgs e)
        {
            var valor = Convert.ToDouble(txtScreen.Text);
            valor *= (-1);
            txtScreen.Text = valor.ToString();
            
        }

        private void btnQuitar_Click_1(object sender, EventArgs e)
        {
            if (txtScreen.Text.Length > 1) //verificamos si el Textbox esta vacio, diciendole que si el número de cifras es mayor o igual a uno que borre.
            {
                txtScreen.Text = txtScreen.Text.Substring(0, txtScreen.Text.Count() - 1);
            }
            else
            {
                txtScreen.Text = "0";
            }
        }
    }
}
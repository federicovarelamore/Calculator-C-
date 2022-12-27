namespace Calculadora
{
    public partial class CALCULADORA : Form
    {
        double primero;
        double segundo;
        string operador;
        public CALCULADORA()
        {
            InitializeComponent();
        }

        Clases.ClsSuma objSuma = new Clases.ClsSuma();
        Clases.ClsResta objResta = new Clases.ClsResta();
        Clases.ClsDivision objDivision = new Clases.ClsDivision();
        Clases.ClsMultiplicacion objMultiplicacion = new Clases.ClsMultiplicacion();




        private void btnN0_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + ".";
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "1";
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "2";
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "3";
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "4";
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "5";
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "6";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "7";
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "8";
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "9";
        }

        private void btnBorrarTotal_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(txtScreen.Text);
            txtScreen.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(txtScreen.Text);
            txtScreen.Clear();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(txtScreen.Text);
            txtScreen.Clear();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(txtScreen.Text);
            txtScreen.Clear();
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
                case "+":
                    Suma = objSuma.Sumar((primero), (segundo)); 
                    txtScreen.Text = Suma.ToString();
                    break;

                case "-": 
                    Resta = objResta.Restar((primero), (segundo));
                    txtScreen.Text = Resta.ToString();
                    break;

                case "*":
                     Multiplicacion = objMultiplicacion.Multiplicar((primero), (segundo));
                    txtScreen.Text = Multiplicacion.ToString();
                    break;

                case "/":
                    Division = objDivision.Division((primero), (segundo));
                    txtScreen.Text = Division.ToString();
                    break;
            }

        }
    }
}
namespace AppCalcRevisão
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        Calculadora calc = new Calculadora();

        public string contatena(string x)
        {
            return txtResultado.Text += x;
        }
      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            txtTroca.Clear();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            
            contatena("0");
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            
            contatena("1");
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            
            contatena("2");
            
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            
            contatena("3");
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            
            contatena("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            
            contatena("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            
            contatena("6");
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            
            contatena("7");
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            
            contatena("8");
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            
            contatena("9");
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {

            calc.v1 = Convert.ToDouble(txtResultado.Text);
            calc.opera = '+';
            txtTroca.Text = txtResultado.Text + calc.opera;
            txtResultado.Clear();

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {

            calc.v1 = Convert.ToDouble(txtResultado.Text);
            calc.opera = '-';
            txtTroca.Text = txtResultado.Text + calc.opera;
            txtResultado.Clear();

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {

            calc.v1 = Convert.ToDouble(txtResultado.Text);
            calc.opera = '*';
            txtTroca.Text = txtResultado.Text + calc.opera;
            txtResultado.Clear();
        }
        private void btnDividir_Click(object sender, EventArgs e)
        {

            calc.v1 = Convert.ToDouble(txtResultado.Text);
            calc.opera = '/';
            txtTroca.Text = txtResultado.Text + calc.opera;
            txtResultado.Clear();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            calc.v2 = Convert.ToDouble(txtResultado.Text);
            txtTroca.Text += txtResultado.Text;
            txtResultado.Clear();
            calc.Calcular();
            txtResultado.Text = calc.resultado.ToString();
        }
    }
}

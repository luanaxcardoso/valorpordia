namespace HorasTrabalhadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome;
            float  valorrecebido, salario;
            double HorasTrab;

            nome = textBox1.Text;
            HorasTrab = Convert.ToDouble(textBox2.Text);
            valorrecebido= Convert.ToSingle(textBox3.Text); 

            salario = (float)HorasTrab * valorrecebido;

            label4.Text = " O valor recebido por " + nome + " por dia é R$" + salario.ToString()+",00";





        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
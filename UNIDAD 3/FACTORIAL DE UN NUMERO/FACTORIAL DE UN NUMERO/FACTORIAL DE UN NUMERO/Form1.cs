namespace FACTORIAL_DE_UN_NUMERO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            int factorial = 1;
            for (int i = 1; i <=numero; i++)
            {
                listBox1.Items.Add(i);
                factorial *= i;
            }
            textBox2.Text = numero.ToString();
            textBox3.Text = factorial.ToString();
        }
    }
}

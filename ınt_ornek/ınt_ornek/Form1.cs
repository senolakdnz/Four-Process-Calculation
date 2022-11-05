namespace ınt_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1, number2, addition, subraction, multiplication, division;
            number1 = Convert.ToInt16(textBox1.Text);
            number2 = Convert.ToInt16(textBox2.Text);
            addition = number1 + number2;
            subraction = number1 - number2;
            multiplication = number1 * number2;
            division = number1 / number2;

            MessageBox.Show("Addition : " + addition + "\n" + "Subraction : " + subraction + "\n" + "Multiplication : " + multiplication + "\n" + "Division : " + division);
        }
    }
}
using SimpleCalc.Data;

namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MainCalculatorPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void UniversalNumberKey_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if(button != null)
            {
                ExpressionHolder.ExpressionStringHolder += button.Text;
                MainDisplay.Text = ExpressionHolder.ExpressionStringHolder;
            }
        }
    }
}

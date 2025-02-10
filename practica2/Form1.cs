namespace Practica2
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

        private void btnclean_Click(object sender, EventArgs e)
        {
           clean();
        }

        public void clean()
        {
            num1.Clear();
            num2.Clear();
            tbresult.Clear();
        }
    }
}

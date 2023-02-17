namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int number = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            number  ++;
            label1.Text=number.ToString();
                
        }
    }
}
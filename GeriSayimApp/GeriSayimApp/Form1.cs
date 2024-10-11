namespace GeriSayimApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        int second = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(second > 0)
            {
                second--;
                progressBar2.Value++;
                label3.Text = second + " second let";
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("Time is Up");
            }
        }
    }
}

namespace Lesson4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form açılır");
        }
        int s = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            label1.Text=s.ToString();
            if (s == 100)
            {
                Close();
            }
        }
    }
}
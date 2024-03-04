namespace Twitter
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

        private void button1_Click(object sender, EventArgs e)
        {
            string message;
            message = Convert.ToString(textBox1.Text);
            int characters = message.Length;
            if (characters <= 140)
                label2.Text = "Your message will be displayed as...    " + message;
            else
                label2.Text = "This message was too long to be displayed";
        }
    }
}

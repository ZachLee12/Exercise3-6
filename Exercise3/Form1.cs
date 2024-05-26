namespace Exercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "";
        }

        private void HelloButton_Click(object sender, EventArgs e)
        {
            // Append the button's text to the form's title
            this.Text = this.Text + "Hello, ";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.Text = "";
        }

        private void WorldButton_Click(object sender, EventArgs e)
        {
            this.Text = this.Text + "World! ";
        }
    }
}

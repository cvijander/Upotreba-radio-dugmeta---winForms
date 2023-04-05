namespace Upotreba_radio_dugmeta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtZelena.Checked)
                this.BackColor = Color.Green;
            else if (rbtPlava.Checked)
                this.BackColor = Color.Blue;
            else if (rbtZuta.Checked)
                this.BackColor = Color.Yellow;
            else if (rbtCrvena.Checked)
                this.BackColor = Color.Red;
            else if (rbtSiva.Checked)
                this.BackColor = Color.Gray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbtSiva.Checked = true;
            this.BackColor = Color.Gray;
        }
    }
}
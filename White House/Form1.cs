namespace White_House
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100,0,0,0);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            Form2 form = new Form2();
            form.ShowDialog();  
            this.Hide();
           

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
            this.Hide();
        }
    }
}
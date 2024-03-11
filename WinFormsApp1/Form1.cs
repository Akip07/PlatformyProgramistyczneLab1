using ConsoleApp6;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int items;
        int seed;
        int capacity;
        public Form1()
        {
            InitializeComponent();

        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            if (textBox1.Text != null)
            {


                try
                {
                    items = Convert.ToInt32(textBox1.Text);
                }
                catch
                {
                    textBox1.BackColor = Color.Red;
                    items = 0;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            if (textBox1.Text != null)
            {


                try
                {
                    seed = Convert.ToInt32(textBox2.Text);
                }
                catch
                {
                    textBox2.BackColor = Color.Red;
                    seed = 0;
                }
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
            if (textBox1.Text != null)
            {


                try
                {
                    capacity = Convert.ToInt32(textBox3.Text);
                }
                catch
                {
                    textBox3.BackColor = Color.Red;
                    capacity = 0;
                }
            }
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Backpack bckp = new Backpack(items, seed);
            textBox4.Text = bckp.ToString();
            textBox5.Text = bckp.Solve(capacity).ToString();
        }
    }
}

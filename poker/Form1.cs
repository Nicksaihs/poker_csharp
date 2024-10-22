namespace poker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int point;
        int pointpc;
        Random rand = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pointpc = rand.Next(13);
            pictureBox1.Image = imageList1.Images[point];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
            timer1.Interval = 100;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (point > pointpc)
            {
                label3.Text = "You win¡I";
            }
            else if (point < pointpc)
            {
                label3.Text = "Computer win¡I";
            }
            else
            {
                label3.Text = "Draw";
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            point = rand.Next(13);
            pictureBox2.Image = imageList1.Images[point];
        }
    }
}
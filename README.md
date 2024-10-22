# poker_csharp
## 2024/10/22

### poker

* 名稱：撲克牌比大小
* 功能：
    1. 按 開始 啟動計時器，計時器會以每0.05秒用亂數切換poker1.jpg~poker13.jpg 撲克牌圖。
    1. 按 暫停 顯示點數及對應鋪克牌圖。

![image](https://hackmd.io/_uploads/SyadraVlyx.png)

```csharp=
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
                label3.Text = "You win！";
            }
            else if (point < pointpc)
            {
                label3.Text = "Computer win！";
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
```


 

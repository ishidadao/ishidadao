using System;
using System.Windows.Forms;
namespace WindowsFormsApp1 
{
    public partial class Form1 : Form
    {
        int i = 0;
        
    public Form1()
    {
            InitializeComponent();
            { button3.Enabled = false; }
    }


    
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("欢迎抽奖！");
            this.SetVisibleCore(false);
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.SetVisibleCore(true);
            
        }

            private void Button1_Click(object sender, EventArgs e)
            {
                System.Diagnostics.Process.Start("cmd.exe", "/cshutdown -s -t 5");
                MessageBox.Show("5秒后电脑自动关机qwq~");
                Application.Exit();


            }

            private void button2_Click(object sender, EventArgs e)
            {
                System.Diagnostics.Process.Start("cmd.exe", "/cshutdown -r -t 5");
                MessageBox.Show("5秒后电脑自动重启qaq~");
                Application.Exit();

            }

            private void button4_Click(object sender, EventArgs e)
            {
                MessageBox.Show("给你一个搞事情的机会");
                System.Diagnostics.Process.Start("cmd.exe", "/cshutdown -i -t 0");
                Application.Exit();
            }

            private void button3_Click(object sender, EventArgs e)
            {
                MessageBox.Show("竟然被你发现了" +
                    "可恶！！！！");
                Application.Exit();

            }

            private void button5_Click(object sender, EventArgs e)
            {
                MessageBox.Show("再抽一次");
            }

            private void button6_Click(object sender, EventArgs e)
            {
               
                int a = 1;
                int b = 1000;
              while (a<=999)
              {
                    a++;                
                   b--;
                MessageBox.Show("你出不去了，上面的标题就是你还要按多少下才能退出" , b.ToString());
                
              }
                Application.Exit();

        }



            private void button8_Click(object sender, EventArgs e)
            {
               i++;
            while (i == 1)
            {
                MessageBox.Show("坚持就是胜利！");
                break;
            }
            while (i == 7)
            {
                button3.Enabled = true;
                break;
            }
            while (i > 7)
            {
                button3.Enabled = false;
                break;
            }

            }
    }
}
    


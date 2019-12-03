using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KostebekOyunu
{
    public partial class Form1 : Form
    {
        private const int HT_CAPTION = 0x2;
        private const int WM_NCLBUTTONDOWN = 0x00A1;
        [DllImport("user32", CharSet = CharSet.Auto)]
        private static extern bool ReleaseCapture();
        [DllImport("user32", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);


        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                Rectangle rct = DisplayRectangle;
                if (rct.Contains(e.Location))
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            OnMouseDown(e);
        }

        Random rnd = new Random();

        int skor = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 0, y = 0, a = 1;

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Button btn = new Button();
                    btn.Name = "btn" + a.ToString();
                    btn.Height = btn.Width = 35;
                    btn.BackColor = Color.White;
                    btn.Location = new Point(3 + x, 3 + y);
                    btn.Click += Btn_Click;
                    btn.MouseLeave += Btn_MouseLeave;
                    pnlYuva.Controls.Add(btn);
                    x += 41;
                    a++;
                }
                y += 41;
                x = 0;
            }
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            Button rengiGeriGetir = (Button)sender;
            if (rengiGeriGetir.BackColor != Color.Yellow)
            {
                rengiGeriGetir.BackColor = Color.White;
            }
        }

        bool tiklandimi = true;

        private void Btn_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            if (tiklanan.BackColor == Color.Yellow && tiklandimi)
            {
                lblSkor.Text = "PUAN\n" + (++skor).ToString();
                tiklanan.BackColor = Color.Lime;
                tiklandimi = false;
            }
            else if (!tiklandimi)
            {

            }
            else if (duraklatBaslat)
            {
                lblSkor.Text = "PUAN\n" + (--skor).ToString();
                tiklanan.BackColor = Color.Red;
            }
        }

        int tut = 0;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int yan = rnd.Next(0, 100);
            pnlYuva.Controls[yan].BackColor = Color.Yellow;
            pnlYuva.Controls[tut].BackColor = Color.White;
            tut = yan;
            tiklandimi = true;
            if (skor < 0)
            {
                timer1.Interval = 2000;
            }
            else if (skor >= 0 && skor < 20)
            {
                timer1.Interval = 1500;
            }
            else if (skor >= 20 && skor < 30)
            {
                timer1.Interval = 1250;
            }
            else if (skor >= 30 && skor < 40)
            {
                timer1.Interval = 1000;
            }
            else if (skor >= 40 && skor < 50)
            {
                timer1.Interval = 750;
            }
            else
            {
                timer1.Interval = 500;
            }
        }

        bool duraklatBaslat = false;

        private void BtnDuraklatDevamet_Click(object sender, EventArgs e)
        {
            btnYenidenBasla.Enabled = true;
            if (duraklatBaslat)
            {
                btnDuraklatDevamet.BackgroundImage = Properties.Resources.Play;
                duraklatBaslat = false;
            }
            else
            {
                btnDuraklatDevamet.BackgroundImage = Properties.Resources.Pause;
                duraklatBaslat = true;
            }
            timer1.Enabled = !timer1.Enabled;
            tiklandimi = false;
        }

        private void BtnYenidenBasla_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DialogResult cevap = MessageBox.Show("Skor sıfırlanarak oyun yeniden başlayacak devam etmek istiyor musunuz?", "Yeniden Başlat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cevap == DialogResult.Yes)
            {
                btnYenidenBasla.Enabled = false;
                lblSkor.Text = "PUAN\n0";
                btnDuraklatDevamet.BackgroundImage = Properties.Resources.Play;
                duraklatBaslat = false;
                for (int i = 0; i < 100; i++)
                {
                    pnlYuva.Controls[i].BackColor = Color.White;
                }
                skor = 0;
            }
            else
            {
                timer1.Start();
            }

        }
    }
}

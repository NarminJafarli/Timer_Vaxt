namespace Timer_Vaxt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saniye = 0, deq = 0, saat = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label3.Text = saniye.ToString();
            if (saniye == 60 ) 
            {
                deq++;
                label4.Text= deq.ToString();
                saniye = 0;

                if (deq== 60 ) 
                {
                    saat = saat + 1;
                    label1.Text= saat.ToString();
                    deq= 0;
                }
            }
        }
    }
}

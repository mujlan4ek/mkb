using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMessageBox
{
    public partial class MyMessageBox : Form
    {
        int _delay;
        Timer tmr = new Timer();

        private void TimerTick(object sender, EventArgs e)
        {
            if (_delay > 0)
                btnStop.Text = "СТОП (" + _delay--.ToString() + ")";
            else
                this.Close();
        }

        public MyMessageBox(string Caption, string Message, int Delay)
        {
            InitializeComponent();

            _delay = Delay - 1;

            btnStop.Text = "СТОП (" + Delay.ToString() + ")";
            this.Text = Caption;
            lblMessage.Text = Message;

            tmr.Interval = 1000;
            tmr.Tick += TimerTick;
            tmr.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmr.Enabled = false;
            btnStop.Text = "СТОП";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

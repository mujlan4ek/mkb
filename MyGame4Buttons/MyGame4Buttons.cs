using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MyGame4Buttons
{
    public delegate void MB_Delegate(int buttonnum, int pixels);

    public partial class MyGame4Buttons : Form
    {
        private const int _movestep = 20;
        private const int _stepdelay = 100;

        private bool _flagfinish = false;
        private bool _flaginterupt = false;
        private int _leftpos;
        private int _leader = 1;

        public MyGame4Buttons()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _leftpos = button1.Left;
            _flagfinish = false;
            _flaginterupt = false;

            Thread[] thread = new Thread[4];
            for (int i = 1; i <= 4; i++)
            {
                int tmp = i;
                thread[tmp-1]= new Thread(() => DoThread(tmp));
                thread[tmp-1].Start();
            }

            Thread watcher = new Thread(Watch);
            watcher.Start(thread);  
        }

        private void Watch(object arg)
        {
            var threads = arg as Thread[];
            foreach (var thread in threads)
                thread.Join();

            if (!_flaginterupt)
                MessageBox.Show("Победила лошадь №" + _leader.ToString());            
        }


        private void DoThread(int buttonnum)
        {
            while (!_flagfinish)
            {
                Random rnd = new Random();
                MovePaintButton(buttonnum, rnd.Next(_movestep));
                Thread.Sleep(_stepdelay);
            }
        }

        public void MovePaintButton(int buttonnum, int pixels)
        {
            Button btn = this.Controls["button" + buttonnum] as Button;

            if (btn.InvokeRequired)
            {
                MB_Delegate d1 = new MB_Delegate(MovePaintButton);
                this.Invoke(d1, new object[] { buttonnum, pixels });
            }
            else
            {
                if (_leftpos <= btn.Left + pixels)
                {
// перекрашиваем старого лидера, иначе возможны 2 красные кнопки!
                    Button btn_exleader = this.Controls["button" + _leader] as Button;
                    btn_exleader.BackColor = SystemColors.Control;

                    btn.BackColor = Color.Red;
                    _leftpos = btn.Left + pixels;
                    _leader = buttonnum;
                }
                btn.Left = btn.Left + pixels;

                _flagfinish = btn.Left >= (this.ClientSize.Width - button1.Width);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _flaginterupt = true;
            _flagfinish = true;

            for (int i = 1; i <= 4; i++)
                (this.Controls["button" + i.ToString()] as Button).Left = 20;
        }

        private void MyGame4Buttons_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}

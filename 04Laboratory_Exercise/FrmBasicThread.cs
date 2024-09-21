using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace _04Laboratory_Exercise
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before starting thread-");

            Thread ThreadA = new Thread(new ThreadStart(MyThreadClass.Thread1));
            Thread ThreadB = new Thread(new ThreadStart(MyThreadClass.Thread1));

            ThreadA.Name = "Thread A";
            ThreadB.Name = "Thread B";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine($"The thread 0x2e38 has exited with code 0 (0x0)");
            Console.WriteLine($"The thread 0x14a0 has exited with code 0 (0x0)");


            lblThread.Text = "- End of Thread -";
            Console.WriteLine("-End of thread-");
        }
    }
}

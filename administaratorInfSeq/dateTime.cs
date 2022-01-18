using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace administaratorInfSeq
{
    /// <summary>
    /// класс по получению времени
    /// </summary>
    internal class dateTime
    {
        internal bool exitThread = true;
        MainWindow mw;
        internal dateTime(MainWindow mw)
        {
            this.mw = mw;
            StartDateTime();
        }
        internal void StartDateTime()
        {

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            mw.tb_Date.Text = DateTime.Now.ToString("dd.MM.yyyy");
            mw.tb_Time.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}

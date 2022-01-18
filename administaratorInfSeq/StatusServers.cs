using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Threading;

namespace administaratorInfSeq
{
    /// <summary>
    /// класс для пинга серверов
    /// </summary>
    public class StatusServers : INotifyPropertyChanged
    {
        private SolidColorBrush red = new BrushConverter().ConvertFromString("#fe6c3f") as SolidColorBrush;
        private SolidColorBrush green = new BrushConverter().ConvertFromString("#00b389") as SolidColorBrush;

        public Thread tr;
        public Brush statusserver1 { get { return _statusserver1; } set { if (value != _statusserver1) { _statusserver1 = value; OnPropertyChanged("statusserver1"); }  } }
        public Brush statusserver2 { get { return _statusserver2; } set { if (value != _statusserver2) { _statusserver2 = value; OnPropertyChanged("statusserver2"); } } }
        public Brush statusZvo { get { return _statusZvo; } set { if (value != _statusZvo) { _statusZvo = value; OnPropertyChanged("statusZvo"); } } }
        public Brush statusVvo { get { return _statusVvo; } set { if (value != _statusVvo) { _statusVvo = value; OnPropertyChanged("statusVvo"); } } }
        public Brush statusCvo { get { return _statusCvo; } set { if (value != _statusCvo) { _statusCvo = value; OnPropertyChanged("statusCvo"); } } }
        public Brush statusUvo { get { return _statusUvo; } set { if (value != _statusUvo) { _statusUvo = value; OnPropertyChanged("statusUvo"); } } }
        public Brush statusSf { get { return _statusSf; } set { if (value != _statusSf) { _statusSf = value; OnPropertyChanged("statusSf"); } } }
        internal bool exitThread = true;

        Brush _statusserver1;
        Brush _statusserver2;
        Brush _statusZvo;
        Brush _statusVvo;
        Brush _statusCvo;
        Brush _statusUvo;
        Brush _statusSf;
        internal List<string> ipServers;
       public StatusServers()
        {
            tr = new Thread(()=>
            {
                while(exitThread)
                {
                    List<SolidColorBrush> res = GetStatusServers();
                    statusserver1 = res[0];
                    statusserver2 = res[1];
                    statusZvo = res[2];
                    statusUvo = res[3];
                    statusCvo = res[4];
                    statusVvo = res[5];
                    statusSf = res[6];
                    Thread.Sleep(5000);
                }
            });
            tr.Start();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string info)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
        public List<SolidColorBrush> GetStatusServers()
        {
            List<SolidColorBrush> res = new List<SolidColorBrush>();
            List<Task<SolidColorBrush>> tasks = new List<Task<SolidColorBrush>>();
            if (ipServers == null)
                Thread.Sleep(1000);
            foreach(var e in ipServers)
            {
                tasks.Add(new Task<SolidColorBrush>(() => pingStatus(e)));
            };
            foreach (var e in tasks)
                e.Start();
            Task.WaitAll(tasks.ToArray());
            foreach (var e in tasks)
                res.Add(e.Result);
            return res;
        }

        private SolidColorBrush pingStatus(string adress)
        {
            PingReply png = new Ping().Send(adress);
            if (png.Status == IPStatus.Success)
                return green;
            else
                return red;
        }
    }
}

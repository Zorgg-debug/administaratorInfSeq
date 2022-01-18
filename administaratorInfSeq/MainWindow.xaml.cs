using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace administaratorInfSeq
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Control control;
        StatusServers statusServ;
        Speaker speaker;
        private MediaPlayer player;
        dateTime dtSetter;
        DoubleAnimation FadeIn;
        DoubleAnimation FadeIn1;
        DoubleAnimation FadeOut;
        DoubleAnimation FadeOut1;
        public MainWindow()
        {
            InitializeComponent();
            control = new Control(this);
            statusServ = new StatusServers();
            control.SetIpServers(statusServ);
            control.SetserverViev("цс1");
            this.GridserversInfo.DataContext = statusServ;
            speaker = new Speaker(this, control); 
            player = new MediaPlayer();
            background.Play();
            dtSetter = new dateTime(this);
            setAnimation();
        }

        private void GetUnderlineText(object sender)
        {
            tb_audite.Foreground = Brushes.White;
            tb_import.Foreground = Brushes.White;
            tb_Reports.Foreground = Brushes.White;
            tb_synchoze.Foreground = Brushes.White;
            tb_centr1.Foreground = Brushes.White;
            tb_centr2.Foreground = Brushes.White;
            tb_Cvo.Foreground = Brushes.White;
            tb_Uvo.Foreground = Brushes.White;
            tb_Zvo.Foreground = Brushes.White;
            tb_Vvo.Foreground = Brushes.White;
            tb_Sf.Foreground = Brushes.White;
            br_centr1.BorderBrush = null;
            br_centr2.BorderBrush = null;
            br_cvo.BorderBrush = null;
            br_uvo.BorderBrush = null;
            br_vvo.BorderBrush = null;
            br_zvo.BorderBrush = null;
            br_sf.BorderBrush = null;
            br_import.BorderBrush = null;
            br_report.BorderBrush = null;
            br_synh.BorderBrush = null;
            br_audit.BorderBrush = null;
            br_Administration.BorderBrush = null;
            if (((Grid)sender).Children.OfType<StackPanel>().FirstOrDefault() != null)
            { 
            ((Grid)sender).Children.OfType<StackPanel>().FirstOrDefault().Children.OfType<TextBlock>().FirstOrDefault().Foreground = 
                new BrushConverter().ConvertFromString("#00b389") as SolidColorBrush; 
            ((Grid)sender).Children.OfType<StackPanel>().FirstOrDefault().Children.OfType<Border>().FirstOrDefault().BorderBrush =
                new BrushConverter().ConvertFromString("#00b389") as SolidColorBrush;
            }
            else
            {
                ((Grid)sender).Children.OfType<Border>().FirstOrDefault().BorderBrush =
                new BrushConverter().ConvertFromString("#00b389") as SolidColorBrush;
            }
        }

       

        internal void GridserversInfo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e = default)
        {
            GetUnderlineText(sender);
            string nameServer ="";
            switch(((Grid)sender).Name)
            {
                case "GridCenter1":
                    nameServer = "цс1";
                    control.StartAnimation("ServerCenter1");
                    break;
                case "GridCenter2":
                    nameServer = "цс2";
                    control.StartAnimation("ServerCenter2");
                    break;
                case "GridZvo":
                    nameServer = "зво";
                    control.StartAnimation("ServerZvo");
                    break;
                case "GridUvo":
                    nameServer = "юво";
                    control.StartAnimation("ServerUvo");
                    break;
                case "GridCvo":
                    nameServer = "цво";
                    control.StartAnimation("ServerCvo");
                    break;
                case "GridVvo":
                    nameServer = "вво";
                    control.StartAnimation("ServerVvo");
                    break;
                case "GridSf":
                    nameServer = "сф";
                    control.StartAnimation("ServerSf");
                    break;
            }
            control.SetserverViev(nameServer);
        }

        internal void tb_audite_MouseLeftButtonDown(object sender, MouseButtonEventArgs e = default)
        {
            GetUnderlineText(sender);
            control.SetValueIntoFrameFromLeftPanel("audit");
            control.StartAnimation("audit");

        }

        internal void tb_import_MouseLeftButtonDown(object sender, MouseButtonEventArgs e = default)
        {
            GetUnderlineText(sender);
            control.SetValueIntoFrameFromLeftPanel("import");
            control.StartAnimation("import");


        }

        internal void tb_Reports_MouseLeftButtonDown(object sender, MouseButtonEventArgs e = default)
        {
            GetUnderlineText(sender);
            control.SetValueIntoFrameFromLeftPanel("report");
            control.StartAnimation("report");
        }
        internal void tb_synchoze_MouseLeftButtonDown(object sender, MouseButtonEventArgs e = default)
        {
            GetUnderlineText(sender);
            control.SetValueIntoFrameFromLeftPanel("synhronise");
            control.StartAnimation("synhronise");
        }
        internal void GridAdministration_MouseLeftButtonDown(object sender, MouseButtonEventArgs e = default)
        {
            GetUnderlineText(sender);
            control.SetValueIntoFrameFromLeftPanel("administration");
            control.StartAnimation("administration");
        }
        private void MainWindowProg_Closed(object sender, EventArgs e)
        {
            statusServ.exitThread = false;
            speaker.namePipe.runThread = false;
            dtSetter.exitThread = false;
        }

        private void MainWindowProg_Loaded(object sender, RoutedEventArgs e)
        {
            img_statusProgram.Height = 100;
        }

        private void background_MediaEnded(object sender, RoutedEventArgs e)
        {
            background.Stop();
            background.Play();
        }

        private void setAnimation()
        {
            FadeIn = new DoubleAnimation();
            FadeIn1 = new DoubleAnimation();
            FadeIn.From = 0;
            FadeIn.To = 345;
            FadeIn1.From = 0;
            FadeIn1.To = 322;
            FadeIn.Duration = TimeSpan.FromSeconds(0.3);
            FadeIn1.Duration = TimeSpan.FromSeconds(0.3);
            FadeOut = new DoubleAnimation();
            FadeOut1 = new DoubleAnimation();
            FadeOut.To = 0;
            FadeOut.From = 345;
            FadeOut1.To = 0;
            FadeOut1.From = 322;
            FadeOut.Duration = TimeSpan.FromSeconds(0.5);
            FadeOut1.Duration = TimeSpan.FromSeconds(0.5);
            FadeIn.Completed += FadeIn_Completed;
            me_Face1.MediaEnded += Me_Face1_MediaEnded;
        }
        internal void startAnimation(string path)
        {
            if (path != "")
            {
                me_Face1.Source = new Uri(System.IO.Path.Combine(Environment.CurrentDirectory, path));
                me_Face1.Play();
                grid_Face.BeginAnimation(Grid.WidthProperty, FadeIn);
                grid_Face.BeginAnimation(Grid.HeightProperty, FadeIn1);
            }
        }

        private void Me_Face1_MediaEnded(object sender, RoutedEventArgs e)
        {
            grid_Face.BeginAnimation(Grid.WidthProperty, FadeOut);
            grid_Face.BeginAnimation(Grid.HeightProperty, FadeOut1);
        }

        private void FadeIn_Completed(object sender, EventArgs e)
        {
        }

        
    }
}

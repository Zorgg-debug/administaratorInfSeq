using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace administaratorInfSeq
{
    /// <summary>
    /// Логика взаимодействия для ImportView.xaml
    /// </summary>
    public partial class ImportView : Page
    {
        internal Control control;
        public importInfo info;

        public ImportView(Control control)
        {
            InitializeComponent();
            info = new importInfo();
            this.control = control;
        }
        internal void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e = default)
        {
            string nameInformation;
            int checkMark = ((Grid)sender).Children.OfType<TextBlock>().Select(b => Convert.ToInt32(b.Text)).FirstOrDefault();
            if (checkMark > 0)
            {
                nameInformation = ((Grid)sender).Children.OfType<TextBlock>().Where(a => a.Name == string.Empty).Select(b => b.Text).FirstOrDefault();
                control.ShowTablePersonal(nameInformation, this, statuslastcolumn:false);
                control.StartAnimation(((Grid)sender).Tag.ToString());
            }

        }
    }
}

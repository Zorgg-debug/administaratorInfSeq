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
    /// Логика взаимодействия для ShowTable.xaml
    /// </summary>
    public partial class ShowTable : Page, IHavePageBack
    {
        Control control;
        internal Page page;

        public ShowTable(Control control)
        {
            this.control = control;
            InitializeComponent();
        }

        private void Img_back_MouseLeftButtonDown(object sender = default, MouseButtonEventArgs e = default)
        {
            control.SetValueDataContext(page);
            control.playSound("action");
        }

        public void ClickBackPage()
        {
            Img_back_MouseLeftButtonDown();
        }
    }
}

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
    /// Логика взаимодействия для administartionView.xaml
    /// </summary>
    public partial class administartionView : Page
    {
        public AdministratorInfo administratorInfo { get; set; }
        public administartionView()
        {
            InitializeComponent();
            DataContext = this;
        }

    }
}

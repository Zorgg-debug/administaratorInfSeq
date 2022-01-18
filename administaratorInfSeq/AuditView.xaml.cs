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
    /// Логика взаимодействия для AuditView.xaml
    /// </summary>
    /// 
    public partial class AuditView : Page
    {
        public AuditInfo audit;
        Control control;
        public AuditView(Control control)
        {
            this.control = control;
            InitializeComponent();
            audit = new AuditInfo();
            this.DataContext = audit;
        }

        internal void ImgRankOut_MouseLeftButtonDown(object sender = default , MouseButtonEventArgs e = default)
        {
            control.SetValueDataContextTable("Воинское звание", audit.rankOut.countColumn, audit.rankOut.queries, this);
            control.StartAnimation("AuditRankOut");
        }

        internal void ImgContract_MouseLeftButtonDown(object sender = default, MouseButtonEventArgs e = default)
        {
            control.SetValueDataContextTable("Истек контракт", audit.contr.countColumn, audit.contr.queries, this);
            control.StartAnimation("AuditContract");
        }

        internal void ImgInstitute_MouseLeftButtonDown(object sender = default, MouseButtonEventArgs e = default)
        {
            control.SetValueDataContextTable("Образование", audit.institute.countColumn, audit.institute.queries, this);
            control.StartAnimation("AuditInstitute");
        }

        internal void ImgPeriods_MouseLeftButtonDown(object sender = default, MouseButtonEventArgs e = default)
        {
            control.SetValueDataContextTable("Периоды службы", audit.periods.countColumn, audit.periods.queries, this);
            control.StartAnimation("AuditPeriods");
        }

        internal void ImgPk_MouseLeftButtonDown(object sender = default, MouseButtonEventArgs e = default)
        {
            control.SetValueDataContextTable("Отсутствует ПК", audit.pk.countColumn, audit.pk.queries, this);
            control.StartAnimation("AuditPk");
        }

        internal void ImgPodch_MouseLeftButtonDown(object sender = default, MouseButtonEventArgs e = default)
        {
            control.SetValueDataContextTable("Расхождение подчиненности", audit.militarydistrict.countColumn, audit.militarydistrict.queries, this);
            control.StartAnimation("AuditPodch");
        }

        internal void ImgPkVsKpu_MouseLeftButtonDown(object sender = default, MouseButtonEventArgs e = default)
        {
            control.SetValueDataContextTable("Расхождение ПК с КПУ", audit.pkVSkpu.countColumn, audit.pkVSkpu.queries, this);
            control.StartAnimation("AuditPkVsKpu");
        }

        internal void ImgShtat_MouseLeftButtonDown(object sender = default, MouseButtonEventArgs e = default)
        {
            control.SetValueDataContextTable("Численность сверх штата", audit.shtat.countColumn, audit.shtat.queries, this);
            control.StartAnimation("AuditShtat");
        }

        internal void ImgBzv_MouseLeftButtonDown(object sender = default, MouseButtonEventArgs e = default)
        {
            control.SetValueDataContextTable("Безвозвратные потери без приказа", audit.bezvz.countColumn, audit.bezvz.queries, this);
            control.StartAnimation("AuditBzv");
        }
    }
}

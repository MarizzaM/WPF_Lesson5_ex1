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
using WPF_Lesson5.DataContext;

namespace WPF_Lesson5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MainWindowDataContext m_mainWindowDataContext = new MainWindowDataContext();

        MobileDataContext m_mobileDataContext = new MobileDataContext();

        public MainWindow()
        {
            InitializeComponent();

            // this.DataContext = this; // not good
            this.DataContext = m_mainWindowDataContext;

            lblModel.DataContext = m_mobileDataContext;
            lblBrand.DataContext = m_mobileDataContext;
            lblColor.DataContext = m_mobileDataContext;

            // Add INotifyPropertyChange to Number property
            // button should change the number value

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            m_mobileDataContext.MyMobilePhone.Model = "S21";

            m_mainWindowDataContext.MyNumber.Number = 777;

        }
    }

}

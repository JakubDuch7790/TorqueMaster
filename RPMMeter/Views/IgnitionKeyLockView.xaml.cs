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


namespace RPMMeter.UserControls
{
    /// <summary>
    /// Interaction logic for IgnitionLock.xaml
    /// </summary>
    public partial class IgnitionLock : UserControl
    {
        public IgnitionLock()
        {
            InitializeComponent();
            this.DataContext = new IgnitionKeyLockViewModel();
        }

        private void StartEngineBtn_Click(object sender, RoutedEventArgs e)
        {
        }

        private void sss_Changed(object sender, EventArgs e)
        {

        }
    }
}

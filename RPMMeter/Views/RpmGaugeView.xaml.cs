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

namespace RPMMeter
{
    /// <summary>
    /// Interaction logic for RPMs.xaml
    /// </summary>
    public partial class RPMs : UserControl
    {
        public RPMs()
        {
            InitializeComponent();
            this.DataContext = new RPMViewModel();
        }
    }
}

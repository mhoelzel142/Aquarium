using Waterlog.ViewModels;
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

namespace Waterlog
{
    /// <summary>
    /// Interaction logic for TankPage.xaml
    /// </summary>
    public partial class TankPage : UserControl
    {
        private TankPageViewModel viewModel;

        public TankPage()
        {
            InitializeComponent();
            // Parameterless ctor for designer
        }

        public TankPage(TankPageViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}

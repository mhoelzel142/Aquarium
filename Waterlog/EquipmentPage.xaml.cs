using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Waterlog.Common.Interfaces;
using Waterlog.Common.Models;
using Waterlog.ViewModels;

namespace Waterlog
{
    /// <summary>
    /// Interaction logic for EquipmentPage.xaml
    /// </summary>
    public partial class EquipmentPage : UserControl
    {
        public EquipmentPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var vm = new AddEquipmentViewModel();
            var page = new AddEquipmentWindow(vm);
            page.Show();
        }
    }
}

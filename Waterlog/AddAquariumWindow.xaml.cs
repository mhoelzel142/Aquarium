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
using System.Windows.Shapes;
using Waterlog.Common.Models;
using Waterlog.Database;
using Waterlog.ViewModels;

namespace Waterlog
{
    /// <summary>
    /// Interaction logic for AddAquariumWindow.xaml
    /// </summary>
    public partial class AddAquariumWindow : Window
    {
        private AddAquariumViewModel vm;

        public AddAquariumWindow()
        {
            InitializeComponent();
        }

        public AddAquariumWindow(AddAquariumViewModel _vm)
        {
            vm = _vm;
            InitializeComponent();
        }

        // TODO: Rewrite this using RelayCommand/MVVM, or install MVVMLight. Quick and dirty test of CRUD and to get some stuff in the database
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm.Aquarium = new Aquarium();
            vm.Aquarium.Name = txtName.Text;
            vm.SaveAquarium();

            this.Close();
        }
    }
}

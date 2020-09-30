﻿using System;
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
using Waterlog.ViewModels;

namespace Waterlog
{
    /// <summary>
    /// Interaction logic for AddEquipmentPage.xaml
    /// </summary>
    public partial class AddEquipmentWindow : Window
    {
        private AddEquipmentViewModel vm;
        public AddEquipmentWindow()
        {
            InitializeComponent();
        }
        public AddEquipmentWindow(AddEquipmentViewModel _vm)
        {
            vm = _vm;
            InitializeComponent();
            this.DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            textBox.DataContext = numpad;
        }

        private double _total;

        public double Total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
            }
        }

        private void buttonEquals_Click(object sender, RoutedEventArgs e)
        {
            numpad.Value = (Total + double.Parse(numpad.Value)).ToString();
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            Total += double.Parse(numpad.Value);
            numpad.Value = "";
        }
    }
}

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
using WpfStylesLib.UC_s;

namespace WpfStylesLib
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Body.Children.Add(new TabControls());
        }

        private void TabControls(object sender, MouseButtonEventArgs e)
        {
            Body.Children.Clear();
            Body.Children.Add(new TabControls());
        }
        private void RadioButtons(object sender, MouseButtonEventArgs e)
        {
            Body.Children.Clear();
            
            Body.Children.Add(new RadioButtons());
        }
    }
}

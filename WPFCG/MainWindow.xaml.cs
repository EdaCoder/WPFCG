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
using WPFCG.UserCtrl;

namespace WPFCG
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Handle(object sender, RoutedEventArgs e)
        {
            var index = int.Parse((sender as Button).CommandParameter.ToString());
            if (index == 1) this.WindowState = WindowState.Minimized;
            if (index == 2) this.Close();
            if (index == 3) XC.Content = new HardwareCheck();
            if (index == 4) XC.Content = new HandwareInfo();
            if (index == 5) { }
            if (index == 6) { }
            if (index == 7) { }
            if (index == 8) { }
        }
    }
}

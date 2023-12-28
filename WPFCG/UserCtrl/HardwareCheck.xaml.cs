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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFCG.UserCtrl
{
    /// <summary>
    /// HardwareCheck.xaml 的交互逻辑
    /// </summary>
    public partial class HardwareCheck : UserControl
    {
        public HardwareCheck()
        {
            InitializeComponent();
            ((Storyboard)FindResource("LoadingX")).Begin();
            ((Storyboard)FindResource("LoadingY")).Begin();
            ((Storyboard)FindResource("LoadingZ")).Begin();
            this.CPUText.Text = "38";
            this.GPUText.Text = "72";
            this.RAMText.Text = "15";
        }

        private void InitEvent(object sender, RoutedEventArgs e)
        {

        }
    }
}

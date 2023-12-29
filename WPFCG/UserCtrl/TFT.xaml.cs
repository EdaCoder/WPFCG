using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFCG.UserCtrl
{
    /// <summary>
    /// TFT.xaml 的交互逻辑
    /// </summary>
    public partial class TFT : UserControl
    {
        public TFT()
        {
            InitializeComponent();
        }
        /// <summary>
        /// CPU选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void CPUCheckEvent(object sender, RoutedEventArgs e)
        {
            var index = int.Parse((sender as ToggleButton).CommandParameter.ToString());
            if (index == 1) { }
            if (index == 2) { }
            if (index == 3) { }
            if (index == 4) { }
        }
        /// <summary>
        /// CPU未选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnCPUCheckEvent(object sender, RoutedEventArgs e)
        {
            var index = int.Parse((sender as ToggleButton).CommandParameter.ToString());
            if (index == 1) { }
            if (index == 2) { }
            if (index == 3) { }
            if (index == 4) { }
        }

        /// <summary>
        /// GPU选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GPUCheckEvent(object sender, RoutedEventArgs e)
        {
            var index = int.Parse((sender as ToggleButton).CommandParameter.ToString());
            if (index == 1) { }
            if (index == 2) { }
            if (index == 3) { }
            if (index == 4) { }
        }

        /// <summary>
        /// GPU未选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnGPUCheckEvent(object sender, RoutedEventArgs e)
        {
            var index = int.Parse((sender as ToggleButton).CommandParameter.ToString());
            if (index == 1) { }
            if (index == 2) { }
            if (index == 3) { }
            if (index == 4) { }
        }

        /// <summary>
        /// RAM选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RAMCheckEvent(object sender, RoutedEventArgs e)
        {
            var index = int.Parse((sender as ToggleButton).CommandParameter.ToString());
            if (index == 1) { }
            if (index == 2) { }
        }

        /// <summary>
        /// RAM未选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnRAMCheckEvent(object sender, RoutedEventArgs e)
        {
            var index = int.Parse((sender as ToggleButton).CommandParameter.ToString());
            if (index == 1) { }
            if (index == 2) { }
        }

        /// <summary>
        /// 切换开关 选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenEevnt(object sender, RoutedEventArgs e)
        {

        }
        /// <summary>
        /// 切换开关 未选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseEvent(object sender, RoutedEventArgs e)
        {

        }

        private void SettingEvent(object sender, MouseButtonEventArgs e)
        {

        }

        private void RepeatEvent(object sender, MouseButtonEventArgs e)
        {

        }
    }
}

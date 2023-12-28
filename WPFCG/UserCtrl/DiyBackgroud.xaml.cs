using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFCG.UserCtrl
{
    /// <summary>
    /// DiyBackgroud.xaml 的交互逻辑
    /// </summary>
    public partial class DiyBackgroud : UserControl
    {
        public DiyBackgroud()
        {
            InitializeComponent();
        }

        private void Handle(object sender, RoutedEventArgs e)
        {
            var index = int.Parse((sender as Button).CommandParameter.ToString());
            if (index == 1) //图片选取
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Filter = "图片|*.jpg;*.jpeg;*.png",
                    Multiselect = false
                };
                if (dialog.ShowDialog() == true)
                {
                    var ImgName = dialog.FileName;
                    Img.Source = new BitmapImage(new Uri(ImgName));
                }
            }
            if (index == 2) //保存设置
            {

            }
        }


     
    }
}

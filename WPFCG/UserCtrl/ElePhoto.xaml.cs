using HandyControl.Controls;
using Microsoft.Win32;
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

namespace WPFCG.UserCtrl
{
    /// <summary>
    /// ElePhoto.xaml 的交互逻辑
    /// </summary>
    public partial class ElePhoto : UserControl
    {
        public ElePhoto()
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
                    Img.Visibility= Visibility.Collapsed;
                    Img2.Visibility= Visibility.Visible;
                    Img2.Source = new BitmapImage(new Uri(ImgName));
                }
            }
            if (index == 2) //保存设置
            {

            }
        }

        private void EnterEvent(object sender, DragEventArgs e)
        {
            var ImgName = ((string[])e.Data.GetData(DataFormats.FileDrop, true)).FirstOrDefault();
            Img.Visibility = Visibility.Collapsed;
            Img2.Visibility = Visibility.Visible;
            Img2.Source = new BitmapImage(new Uri(ImgName));
            
        }

        private void ImageSelect(object sender, RoutedEventArgs e)
        {
            var ImgName = (sender as ImageSelector).ToolTip.ToString();
            Img.Visibility = Visibility.Collapsed;
            Img2.Visibility = Visibility.Visible;
            Img2.Source = new BitmapImage(new Uri(ImgName));
        }

        private void ImageSelected(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "图片|*.jpg;*.jpeg;*.png",
                Multiselect = false
            };
            if (dialog.ShowDialog() == true)
            {
                var ImgName = dialog.FileName;
                Img.Visibility = Visibility.Collapsed;
                Img2.Visibility = Visibility.Visible;
                Img2.Source = new BitmapImage(new Uri(ImgName));
            }
        }
    }
}

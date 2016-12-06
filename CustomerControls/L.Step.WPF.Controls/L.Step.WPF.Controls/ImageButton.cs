using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace L.Step.WPF.Controls
{
    public class ImageButton:Button
    {
        public ImageButton() : base()
        {
            ResourceDictionary redic=new ResourceDictionary();
            redic.Source=new Uri("/L.Step.WPF.Controls;component/Themes/ImageButtonStyle.xaml",UriKind.Relative);
            this.Resources.MergedDictionaries.Add(redic);
            //获取样式
            this.Style = this.FindResource("ImageButtonStyle") as Style;
        }

        public static readonly DependencyProperty NormalImageProperty = DependencyProperty.Register(
            "NormalImage", typeof (string), typeof (ImageButton), new PropertyMetadata(default(string)));

        public string NormalImage
        {
            get { return (string) GetValue(NormalImageProperty); }
            set { SetValue(NormalImageProperty, value); }
        }

        public static readonly DependencyProperty MouseOverImageProperty = DependencyProperty.Register(
            "MouseOverImage", typeof (string), typeof (ImageButton), new PropertyMetadata(default(string)));

        public string MouseOverImage
        {
            get { return (string) GetValue(MouseOverImageProperty); }
            set { SetValue(MouseOverImageProperty, value); }
        }

        public static readonly DependencyProperty MouseDownImageProperty = DependencyProperty.Register(
            "MouseDownImage", typeof (string), typeof (ImageButton), new PropertyMetadata(default(string)));

        public string MouseDownImage
        {
            get { return (string) GetValue(MouseDownImageProperty); }
            set { SetValue(MouseDownImageProperty, value); }
        }

        public static readonly DependencyProperty EnabledImageProperty = DependencyProperty.Register(
            "EnabledImage", typeof (string), typeof (ImageButton), new PropertyMetadata(default(string)));

        public string EnabledImage
        {
            get { return (string) GetValue(EnabledImageProperty); }
            set { SetValue(EnabledImageProperty, value); }
        }
    }
}

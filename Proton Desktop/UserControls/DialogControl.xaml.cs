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

namespace Proton_Desktop.UserControls
{
    public class RGB
    {
        public RGB(byte r, byte g, byte b)
        {
            this.R = r;

            this.G = g;

            this.B = b;
        }
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }
    }
    public partial class DialogControl : UserControl
    {
        public DialogControl()
        {
            InitializeComponent();
        }

        public RGB Photo
        {
            set => photo.Fill =
                new SolidColorBrush(
                Color.FromRgb(value.R, value.G, value.B)
                );
        }
        public string Username
        {
            get => username.Text;
            set => username.Text = value;
        }

        public string Message
        {
            get => message.Text;
            set => message.Text = value;
        }
    }
}

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

namespace Piłkarze
{
    /// <summary>
    /// Logika interakcji dla klasy UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public static Brush BrushForAll { get; set; } 
        public Brush TextBoxBorderBrush
        {
            get {return border.BorderBrush;}
            set {border.BorderBrush = value;}
        }
        public string Text
        {
            get
            {
                return textBox.Text;
            }
            set
            {
                textBox.Text = value;
            }
        }
        public UserControl1()
        {
            InitializeComponent();
            border.BorderBrush = BrushForAll;
        }

        public void SetError(string errortext)
        {
            blocktooltip.Text = errortext;
            if (errortext != "")
            {
                border.BorderThickness = new Thickness(1);
                toolTip.Visibility = Visibility.Visible;
            }
            else
            {
                border.BorderThickness = new Thickness(0);
                toolTip.Visibility = Visibility.Hidden;
            }
        }
    }
}

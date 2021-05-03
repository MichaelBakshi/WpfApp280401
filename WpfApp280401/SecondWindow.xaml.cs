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
using System.Windows.Shapes;

namespace WpfApp280401
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public double WidthChosen { get; set; }
        public double HeightChosen { get; set; }
        public string TextChosen { get; set; }
        public SecondWindow(double widthChosen, double heightChosen, string textChosen )
        {
            InitializeComponent();
            
            WidthChosen = widthChosen;
            HeightChosen = heightChosen;
            TextChosen = textChosen;
            this.DataContext = this;
        }
    }
}

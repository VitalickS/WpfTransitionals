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

namespace BasicTester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TransitionBox.Transition = new Transitionals.Transitions.FadeAndBlurTransition();

  
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(TransitionBox.Content is Ellipse el && el.Height==300)
                TransitionBox.Content = new Ellipse { Fill = new SolidColorBrush(Colors.Gray), Height = 200, Width = 200 };
            else
                TransitionBox.Content = new Ellipse { Fill = new SolidColorBrush(Colors.BlueViolet), Height = 300, Width = 300 };
        }
    }
}

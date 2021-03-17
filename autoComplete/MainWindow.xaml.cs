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

namespace autoComplete
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tb.FilterMode = AutoCompleteFilterMode.Contains;
            tb.ItemsSource = new string[] { "Kamal", "Saman", "Pansilu", "roshan" };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(tb.Text);
        }
    }
}

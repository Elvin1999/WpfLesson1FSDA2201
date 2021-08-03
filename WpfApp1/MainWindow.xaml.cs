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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public int Count { get; set; } = 0;
        private void Button_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
           
           btn.Content = Count++;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            //var result = MessageBox.Show("Salam Wpf", "C# Language and Xaml", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            //if (result == MessageBoxResult.OK)
            //{
            //    btn.Background = Brushes.LightCoral;
            //}
        }

        private void StackPanel_MouseMove(object sender, MouseEventArgs e)
        {
            btn.Content = Mouse.GetPosition(Application.Current.MainWindow).X;

        }
    }
}

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

using System.ComponentModel;

namespace WpfWelcomeApp
{
    class User
    {
        public string? Name { set; get; }
        public int Age { set; get; }
        public override string ToString()
        {
            return $"User: name {Name}, age {Age}";
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //btn.Background = (Brush)TypeDescriptor.GetConverter(typeof(Brush)).ConvertFromInvariantString("Yellow");
            //btn.Background = new SolidColorBrush(Colors.Yellow);

            //Button btn = new();
            //btn.Width = 300;
            //btn.Height = 200;
            //btn.Content = "Click me";
            //panel.Children.Add(btn);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(txtBox.Text != "")
                MessageBox.Show("Hello " + txtBox.Text);
            
        }
    }
}

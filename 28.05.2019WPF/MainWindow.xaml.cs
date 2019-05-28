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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _28._05._2019WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = progressButton.Width;
            animation.To = progressButton.Width + 400;
            animation.Duration = new Duration(TimeSpan.FromSeconds(3));
            animation.Completed += progressButtonCompleted;

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(animation);
            Storyboard.SetTargetName(animation, progressButton.Name);
            Storyboard.SetTargetProperty(animation, new PropertyPath(WidthProperty));

            storyboard.Begin(this);
        }

        private void progressButtonCompleted(object sender, EventArgs e)
        {
            MessageBox.Show("The end! Thank you for waiting)");
        }
    }
}

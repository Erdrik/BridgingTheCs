using ShowMeSomething.CPPWrapper;
using System.Diagnostics;
using System.Windows;

namespace ShowMeSomething
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var rectangle = new Rectangle();
            rectangle.SetPosition(5, 5);
            rectangle.SetDimensions(10, 10);

            var inside = rectangle.PointIsInside(6, 6);
            var outside = rectangle.PointIsInside(16, 16);

            Trace.WriteLine($"Is Inside[{inside}] Outside[{outside}]");
        }


    }
}

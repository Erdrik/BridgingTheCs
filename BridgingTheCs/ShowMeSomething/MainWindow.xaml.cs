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

            var exists = DoThatForMe.Exists();
            Trace.WriteLine($"Exists[{exists}]");
        }


    }
}

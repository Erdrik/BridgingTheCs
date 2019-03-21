using ShowMeSomething.CPPWrapper;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ShowMeSomething
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Rectangle rectangle = new Rectangle();

        private Marker marker = new Marker(200.0f, 150.0f);

        private float stepDistance = 10.0f;

        public MainWindow()
        {
            InitializeComponent();

            rectangle.SetDimensions((float)VisualRectangle.Width, (float)VisualRectangle.Height);

            this.KeyDown += new KeyEventHandler(MainWindow_KeyDown);

            RefreshVisuals();
        }

        void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Left:
                    marker.Move(-stepDistance, 0.0f);
                    break;
                case Key.Right:
                    marker.Move(stepDistance, 0.0f);
                    break;
                case Key.Up:
                    marker.Move(0.0f, -stepDistance);
                    break;
                case Key.Down:
                    marker.Move(0.0f, stepDistance);
                    break;
                default:
                    break;
            }

            RefreshVisuals();
        }

        private void RefreshVisuals()
        {
            rectangle.SetPosition((float)VisualRectangle.Margin.Left, (float)VisualRectangle.Margin.Top);
            VisualMarker.Margin = new Thickness(marker.X - VisualMarker.Width * 0.5f, marker.Y - VisualMarker.Height * 0.5f, 0.0f, 0.0f);

            // Use the C++ code to determine if we are inside the rectangle!
            if (rectangle.PointIsInside(marker.X, marker.Y))
            {
                VisualMarker.Fill = new SolidColorBrush(Colors.AliceBlue);
                Trace.WriteLine($"Marker[{marker.X}, {marker.Y}] is inside!");
            }
            else
            {
                VisualMarker.Fill = new SolidColorBrush(Colors.Orange);
                Trace.WriteLine($"Marker[{marker.X}, {marker.Y}] is outside!");
            }
        }
    }
}

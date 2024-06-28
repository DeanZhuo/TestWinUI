using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TestWinUI
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        PhysicalMonitorBrightnessController controller;

        public MainWindow()
        {
            this.InitializeComponent();

            controller = new();
            UpdateLevel();
        }

        void UpdateLevel()
        {
            level.Text = controller.Get().ToString();
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string key = button.Content as string;

            int value = controller.Get();

            if (key == "Up")
            {
                value++;
            }
            else
            {
                value--;
            }

            controller.Set((uint)value);
            UpdateLevel();
        }
    }
}

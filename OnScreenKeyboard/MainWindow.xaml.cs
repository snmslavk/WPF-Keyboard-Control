using System.Windows;

namespace OnScreenKeyboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            onScreenKeyboard.Enter_Click += new RoutedEventHandler(onScreenKeyboard_Enter_Click);
        }

        void onScreenKeyboard_Enter_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("EnterClick!");
        }
    }
}

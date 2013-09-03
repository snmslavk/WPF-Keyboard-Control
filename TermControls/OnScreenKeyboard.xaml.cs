using System.Windows;
using System.Windows.Controls;
using TermControls.Models;
using TermControls.Helpers;

namespace TermControls
{

    public partial class OnScreenKeyboard : UserControl
    {
        public OnScreenKeyboard()
        {
            InitializeComponent();
            _model = new KeyboardModelRuEng((ControlTemplate)MainGrid.Resources["SimpleBtn"], new RoutedEventHandler(OnScreenKeyboard_Click));
            KeyboardHelper.CreateButtons(MainGrid.Children, _model);
        }

        KeyboardModel _model;

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
           DependencyProperty.Register("Text", typeof(string), typeof(OnScreenKeyboard), new UIPropertyMetadata(null));

        void OnScreenKeyboard_Click(object sender, RoutedEventArgs e)
        {
            Text += (sender as Button).Content;
        }

        private void btnShift_Click(object sender, RoutedEventArgs e)
        {
            _model.isShift = !_model.isShift;
            KeyboardHelper.SetBtnContent(MainGrid.Children, _model);
        }

        private void btnChangeLang_Click(object sender, RoutedEventArgs e)
        {
            _model.isEngRus = !_model.isEngRus;
            KeyboardHelper.SetBtnContent(MainGrid.Children, _model);
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            if (Text.Length > 0)
                Text = Text.Remove(Text.Length-1);
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (Enter_Click != null)
                Enter_Click(this, e);
        }

        public event RoutedEventHandler Enter_Click;

    }
    
 
}

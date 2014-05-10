using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TermControls
{

    public partial class OnScreenKeyboard : UserControl
    {
        public OnScreenKeyboard()
        {
            InitializeComponent();
        }


        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
           DependencyProperty.Register("Text", typeof(string), typeof(OnScreenKeyboard), new UIPropertyMetadata(null));


        public static readonly DependencyProperty CommandProperty
      = DependencyProperty.Register("Command",
                                           typeof(ICommand), typeof(OnScreenKeyboard));
                
        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }



    }
    
 
}

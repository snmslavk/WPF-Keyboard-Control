// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OnScreenKeyboard.xaml.cs" company="MyCompanyName">
//   The MIT License (MIT)
//   Copyright(c) 2014 Viacheslav Avsenev
// </copyright>
// <summary>
//   The on screen keyboard.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TermControls
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;

    /// <summary>
    ///     The on screen keyboard.
    /// </summary>
    public partial class OnScreenKeyboard : UserControl
    {
        /// <summary>
        ///     The text property.
        /// </summary>
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
            "Text",
            typeof(string),
            typeof(OnScreenKeyboard),
            new UIPropertyMetadata(null));

        /// <summary>
        ///     The command property.
        /// </summary>
        public static readonly DependencyProperty CommandProperty = DependencyProperty.Register(
            "Command",
            typeof(ICommand),
            typeof(OnScreenKeyboard));

        /// <summary>
        /// Initializes a new instance of the <see cref="OnScreenKeyboard"/> class. 
        /// </summary>
        public OnScreenKeyboard()
        {
            this.InitializeComponent();
        }

        /// <summary>
        ///     Gets or sets the text.
        /// </summary>
        public string Text
        {
            get
            {
                return (string)this.GetValue(TextProperty);
            }

            set
            {
                this.SetValue(TextProperty, value);
            }
        }

        /// <summary>
        ///     Gets or sets the command.
        /// </summary>
        public ICommand Command
        {
            get
            {
                return (ICommand)this.GetValue(CommandProperty);
            }

            set
            {
                this.SetValue(CommandProperty, value);
            }
        }
    }
}

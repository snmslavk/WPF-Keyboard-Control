namespace TermControls.Models
{
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel;

    /// <summary>
    /// The keyboard model.
    /// </summary>
    public class KeyboardModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Gets or sets the content 1.
        /// </summary>
        protected string[] Content1 { get; set; }

        /// <summary>
        /// Gets or sets the content 1 shift.
        /// </summary>
        protected string[] Content1Shift { get; set; }

        /// <summary>
        /// Gets or sets the content 2.
        /// </summary>
        protected string[] Content2 { get; set; }

        /// <summary>
        /// Gets or sets the content 2 shift.
        /// </summary>
        protected string[] Content2Shift { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is shift.
        /// </summary>
        public bool IsShift { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is eng rus.
        /// </summary>
        public bool IsEngRus { get; set; }

        /// <summary>
        /// Gets the content.
        /// </summary>
        public string[] Content
        {
            get
            {
                if (!this.IsShift && this.IsEngRus) return this.Content1;
                if (this.IsShift && this.IsEngRus) return this.Content1Shift;
                if (!this.IsShift && !this.IsEngRus) return this.Content2;
                if (this.IsShift && !this.IsEngRus) return this.Content2Shift;
                return null;
            }
        }

        /// <summary>
        /// Gets the buttons raw 1.
        /// </summary>
        public ObservableCollection<ButtonModel> ButtonsRaw1 { get; private set; }

        /// <summary>
        /// Gets the buttons raw 2.
        /// </summary>
        public ObservableCollection<ButtonModel> ButtonsRaw2 { get; private set; }

        /// <summary>
        /// Gets the buttons raw 3.
        /// </summary>
        public ObservableCollection<ButtonModel> ButtonsRaw3 { get; private set; }

        /// <summary>
        /// Gets the buttons raw 4.
        /// </summary>
        public ObservableCollection<ButtonModel> ButtonsRaw4 { get; private set; }

        /// <summary>
        /// The text.
        /// </summary>
        private string text;

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        public string Text
        {
            get
            {
                return this.text;
            }
            set
            {
                this.text = value;
                this.OnPropertyChanged("Text");
            }
        }

        #region Methods

        /// <summary>
        /// The get button content.
        /// </summary>
        /// <param name="btnName">
        /// The btn name.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GetButtonContent(string btnName)
        {
            var raw = Convert.ToInt32(btnName[1].ToString()) - 1;
            var col = btnName.Length == 3
                          ? Convert.ToInt32(btnName[2].ToString()) - 1
                          : Convert.ToInt32(btnName[2] + btnName[3].ToString()) - 1;
            return this.Content[raw][col].ToString();
        }

        /// <summary>
        /// The change buttons content.
        /// </summary>
        public void ChangeButtonsContent()
        {
            this.ChangeButtonsContent(this.ButtonsRaw1, 0);
            this.ChangeButtonsContent(this.ButtonsRaw2, 1);
            this.ChangeButtonsContent(this.ButtonsRaw3, 2);
            this.ChangeButtonsContent(this.ButtonsRaw4, 3);
        }

        /// <summary>
        /// The create buttons.
        /// </summary>
        public void CreateButtons()
        {
            this.ButtonsRaw1 = this.CreateButtons(0);
            this.ButtonsRaw2 = this.CreateButtons(1);
            this.ButtonsRaw3 = this.CreateButtons(2);
            this.ButtonsRaw4 = this.CreateButtons(3);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyboardModel"/> class.
        /// </summary>
        public KeyboardModel()
        {
            this.IsShift = false;
            this.IsEngRus = false;
            this.InitContent();
        }

        /// <summary>
        /// The init content.
        /// </summary>
        public virtual void InitContent()
        {
        }

        /// <summary>
        /// The create buttons.
        /// </summary>
        /// <param name="raw">
        /// The _raw.
        /// </param>
        /// <returns>
        /// The <see cref="ObservableCollection"/>.
        /// </returns>
        private ObservableCollection<ButtonModel> CreateButtons(int raw)
        {
            var buttons = new ObservableCollection<ButtonModel>();
            for (var j = 1; j <= this.Content[raw].Length; j++)
            {
                var name = $"b{raw + 1}{j}";
                buttons.Add(new ButtonModel { Name = name, Column = j - 1, Content = this.GetButtonContent(name) });
            }
            return buttons;
        }

        /// <summary>
        /// The change buttons content.
        /// </summary>
        /// <param name="buttons">
        /// The _buttons.
        /// </param>
        /// <param name="_raw">
        /// The _raw.
        /// </param>
        private void ChangeButtonsContent(ObservableCollection<ButtonModel> buttons, int _raw)
        {
            for (var j = 1; j <= this.Content[_raw].Length; j++) buttons[j - 1].Content = this.GetButtonContent(buttons[j - 1].Name);
        }

        #endregion

        #region INotifyPropertyChanged Members

        /// <summary>
        /// The property changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The on property changed.
        /// </summary>
        /// <param name="propertyName">
        /// The property name.
        /// </param>
        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}

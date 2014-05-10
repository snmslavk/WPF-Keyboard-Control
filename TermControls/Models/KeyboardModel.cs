using System;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace TermControls.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class KeyboardModel : INotifyPropertyChanged
    {
        protected string[] Content1 { get; set; }
        protected string[] Content1Shift { get; set; }
        protected string[] Content2 { get; set; }
        protected string[] Content2Shift { get; set; }
        public bool isShift { get; set; }
        public bool isEngRus { get; set; }
        
        public string[] Content
        {
            get
            {
                if (!isShift && isEngRus)
                    return Content1;
                if (isShift && isEngRus)
                    return Content1Shift;
                if (!isShift && !isEngRus)
                    return Content2;
                if (isShift && !isEngRus)
                    return Content2Shift;
                return null;
            }
        }

        private ObservableCollection<ButtonModel> buttonsRaw1;

        public ObservableCollection<ButtonModel> ButtonsRaw1
        {
            get
            {
                return buttonsRaw1;
            }
        }

        private ObservableCollection<ButtonModel> buttonsRaw2;

        public ObservableCollection<ButtonModel> ButtonsRaw2
        {
            get
            {
                return buttonsRaw2;
            }
        }

        private ObservableCollection<ButtonModel> buttonsRaw3;

        public ObservableCollection<ButtonModel> ButtonsRaw3
        {
            get
            {
                return buttonsRaw3;
            }
        }

        private ObservableCollection<ButtonModel> buttonsRaw4;

        public ObservableCollection<ButtonModel> ButtonsRaw4
        {
            get
            {
                return buttonsRaw4;
            }
        }


        private string text;
        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                OnPropertyChanged("Text");
            }
        }

        #region Methods

        public string GetButtonContent(string btnName)
        {
            int raw = Convert.ToInt32(btnName[1].ToString()) - 1;
            int col = btnName.Length == 3 ? Convert.ToInt32(btnName[2].ToString()) - 1 : Convert.ToInt32(btnName[2].ToString() + btnName[3].ToString()) - 1;
            return Content[raw][col].ToString();
        }

        public void ChangeButtonsContent()
        {
            ChangeButtonsContent(buttonsRaw1, 0);
            ChangeButtonsContent(buttonsRaw2, 1);
            ChangeButtonsContent(buttonsRaw3, 2);
            ChangeButtonsContent(buttonsRaw4, 3);
        }

        public void CreateButtons()
        {
            buttonsRaw1 = CreateButtons(0);
            buttonsRaw2 = CreateButtons(1);
            buttonsRaw3 = CreateButtons(2);
            buttonsRaw4 = CreateButtons(3);
        }

        public KeyboardModel()
        {
            isShift = false;
            isEngRus = false;
            InitContent();
        }

        public virtual void InitContent()
        {
        }

        ObservableCollection<ButtonModel> CreateButtons(int _raw)
        {
            var _buttons = new ObservableCollection<ButtonModel>();
            for (int j = 1; j <= Content[_raw].Length; j++)
            {
                string _name = String.Format("b{0}{1}", _raw + 1, j);
                _buttons.Add(new ButtonModel() { Name = _name, Column = j - 1, Content = GetButtonContent(_name) });
            }
            return _buttons;
        }

        void ChangeButtonsContent(ObservableCollection<ButtonModel> _buttons, int _raw)
        {
            for (int j = 1; j <= Content[_raw].Length; j++)
                _buttons[j - 1].Content = GetButtonContent(_buttons[j - 1].Name);
        }

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion


    }

}

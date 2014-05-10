using System.ComponentModel;

namespace TermControls.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ButtonModel :  INotifyPropertyChanged
    {
        public ButtonModel()
        {

        }

        private string content;
        public string Content
        {
            get { return content; }
            set
            {
                content = value;
                OnPropertyChanged("Content");
            }
        }

        public string Name { get; set; }
        public int Column { get; set; }

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

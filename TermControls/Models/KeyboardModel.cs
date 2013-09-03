using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace TermControls.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class KeyboardModel : BaseModel
    {
        public Dictionary<string, ButtonModel> DictButtons = new Dictionary<string, ButtonModel>();

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_BtnTemplate"></param>
        /// <param name="_onScreenKeyboard_Click"></param>
        public KeyboardModel(ControlTemplate _BtnTemplate, RoutedEventHandler _onScreenKeyboard_Click)
        {
            isShift = false;
            isEngRus = false;
            FontSize = 20;
            Template = _BtnTemplate;
            _OnScreenKeyboard_Click = _onScreenKeyboard_Click;
            Content1 = Content2 = Content1Shift = Content2Shift = new string[4] { new string('*', 11), new string('*', 12), new string('*', 11), new string('*', 12) };
            Fill_DictButtons();
        }

        /// <summary>
        /// 
        /// </summary>
        void Fill_DictButtons()
        {
            for (int i = 1; i <= Content.Length; i++)
                for (int j = 1; j <= Content[i-1].Length; j++)
                {
                    ButtonModel _model = new ButtonModel(this) {Name = "b" + i.ToString() + j.ToString(), Column = j - 1};
                    DictButtons.Add(_model.Name, _model);
                }
        }


    }

}

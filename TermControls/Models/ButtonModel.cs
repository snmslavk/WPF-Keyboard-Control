using System.Windows;
using System.Windows.Controls;

namespace TermControls.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ButtonModel : BaseModel
    {
        public ButtonModel(BaseModel _model)
        {
            FontSize = _model.FontSize;
            Template = _model.Template;
            _OnScreenKeyboard_Click = _model._OnScreenKeyboard_Click;
        }
        public string Name { get; set; }
        public int Column { get; set; }
    }
}

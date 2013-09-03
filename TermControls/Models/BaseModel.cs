using System.Windows;
using System.Windows.Controls;

namespace TermControls.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseModel
    {
        public double FontSize { get; set; }
        public ControlTemplate Template { get; set; }
        public RoutedEventHandler _OnScreenKeyboard_Click { get; set; }
    }
}

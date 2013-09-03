using System.Windows;
using System.Windows.Controls;

namespace TermControls.Models
{
    public class KeyboardModelRuEng : KeyboardModel
    {
        public KeyboardModelRuEng(ControlTemplate _BtnTemplate, RoutedEventHandler _onScreenKeyboard_Click)
            : base(_BtnTemplate, _onScreenKeyboard_Click)
        {
            Content1 = new string[4] { "1234567890-", "йцукенгшщзхъ", "фывапролджэ", "ячсмитьбю,.?" };
            Content1Shift = new string[4] { "!\"№;%:?*()-", "ЙЦУКЕНГШЩЗХЪ", "ФЫВАПРОЛДЖЭ", "ЯЧСМИТЬБЮ0,.?" };
            Content2 = new string[4] { "1234567890-", "qwertyuiop[]", "asdfghjkl;'", "zxcvbnm<>,.?" };
            Content2Shift = new string[4] { "!@#$%^&*()-", "QWERTYUIOP{}", "ASDFGHJKL:\"", "ZXCVBNM<>,.?" };
        }

    }
}

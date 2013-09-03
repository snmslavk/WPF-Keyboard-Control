using System;
using System.Windows;
using System.Windows.Controls;
using TermControls.Models;

namespace TermControls.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    public static class KeyboardHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_mainGrid"></param>
        /// <param name="_model"></param>
        public static void SetBtnContent(UIElementCollection _children, KeyboardModel _model)
        {

            foreach (object o in _children)
                foreach (object btn in (o as Grid).Children)
                        if ((btn as Button).Content != null && (btn as Button).Name.Substring(0, 3) != "btn")
                            (btn as Button).Content = GetButtonContent((btn as Button).Name, _model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_mainGrid"></param>
        /// <param name="_model"></param>
        public static void CreateButtons(UIElementCollection _children, KeyboardModel _model)
        {
            for (int i = 0; i < _model.Content.Length; i++)
                for (int j = 1; j <= _model.Content[i].Length; j++)
                    (_children[i] as Grid).Children.Add(CreateButton(_model, String.Format("b{0}{1}", i + 1, j)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_model"></param>
        /// <param name="_btnName"></param>
        /// <returns></returns>
        static Button CreateButton(KeyboardModel _model,string _btnName)
        {
            Button btn = new Button() { FontSize = _model.DictButtons[_btnName].FontSize, Template = _model.DictButtons[_btnName].Template,
                Name = _btnName, Content = GetButtonContent(_btnName, _model)};
            btn.Click += _model._OnScreenKeyboard_Click;
            Grid.SetColumn(btn, _model.DictButtons[_btnName].Column);
            return btn;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="btnName"></param>
        /// <param name="_model"></param>
        /// <returns></returns>
        static string GetButtonContent(string btnName, KeyboardModel _model)
        {
            int raw = Convert.ToInt32(btnName[1].ToString()) - 1;
            int col = btnName.Length == 3 ? Convert.ToInt32(btnName[2].ToString()) - 1 : Convert.ToInt32(btnName[2].ToString() + btnName[3].ToString()) - 1;
            return _model.Content[raw][col].ToString();
        }

    }
}

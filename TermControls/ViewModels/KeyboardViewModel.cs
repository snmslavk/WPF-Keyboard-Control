using System;
using System.Windows.Input;
using TermControls.Commands;
using TermControls.Models;

namespace TermControls.ViewModels
{
    public class KeyboardViewModel
    {
        public KeyboardViewModel()
        {
            Model = new KeyboardModelRuEng();
            Model.CreateButtons();
        }

        public KeyboardModel Model { get; set; }

        public ICommand ChangeLangCommand
        {
            get { return new DelegateCommand(ChangeLangClick); }
        }


        public void ChangeLangClick(object param)
        {
            Model.isEngRus = !Model.isEngRus;
            Model.ChangeButtonsContent();
        }

        public ICommand ShiftCommand
        {
            get { return new DelegateCommand(ShiftClick); }
        }


        public void ShiftClick(object param)
        {
            Model.isShift = !Model.isShift;
            Model.ChangeButtonsContent();
        }

        public ICommand DeleteCommand
        {
            get { return new DelegateCommand(DeleteClick); }
        }


        public void DeleteClick(object param)
        {
            if (!String.IsNullOrEmpty(Model.Text))
                Model.Text = Model.Text.Remove(Model.Text.Length - 1);
        }

        public ICommand ButtonClickCommand
        {
            get { return new DelegateCommand(ButtonClick); }
        }


        public void ButtonClick(object param)
        {
            Model.Text += param.ToString();
        }

        public ICommand SpaceCommand
        {
            get { return new DelegateCommand(SpaceClick); }
        }


        public void SpaceClick(object param)
        {
            Model.Text += " ";
        }
    }
}

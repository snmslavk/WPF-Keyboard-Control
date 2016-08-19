namespace TermControls.ViewModels
{
    using System.Windows.Input;

    using TermControls.Commands;
    using TermControls.Models;

    public class KeyboardViewModel
    {
        public KeyboardViewModel()
        {
            this.Model = new KeyboardModelRuEng();
            this.Model.CreateButtons();
        }

        public KeyboardModel Model { get; set; }

        public ICommand ChangeLangCommand => new DelegateCommand(this.ChangeLangClick);

        public void ChangeLangClick(object param)
        {
            this.Model.IsEngRus = !this.Model.IsEngRus;
            this.Model.ChangeButtonsContent();
        }

        public ICommand ShiftCommand => new DelegateCommand(this.ShiftClick);

        public void ShiftClick(object param)
        {
            this.Model.IsShift = !this.Model.IsShift;
            this.Model.ChangeButtonsContent();
        }

        public ICommand DeleteCommand => new DelegateCommand(this.DeleteClick);

        public void DeleteClick(object param)
        {
            if (!string.IsNullOrEmpty(this.Model.Text)) this.Model.Text = this.Model.Text.Remove(this.Model.Text.Length - 1);
        }

        public ICommand ButtonClickCommand => new DelegateCommand(this.ButtonClick);

        public void ButtonClick(object param)
        {
            this.Model.Text += param.ToString();
        }

        public ICommand SpaceCommand => new DelegateCommand(this.SpaceClick);

        public void SpaceClick(object param)
        {
            this.Model.Text += " ";
        }
    }
}

## WPF on screen keyboard control

This is a component for WPF applications

It works under .Net Framework 4

### How to use
#### Getting started
Add namespace to your xaml application

      xmlns:TermControls="clr-namespace:TermControls;assembly=TermControls"
 
 Then use it like
 
      <TermControls:OnScreenKeyboard />

#### Binding      
Also you can bind textbox or others component to this control via standard binding

      <TextBox Text="{Binding Text, ElementName=onScreenKeyboard}" Name="textBox1" />

#### How to use handle EnterKeyPress

      <TermControls:OnScreenKeyboard x:Name="onScreenKeyboard" Command="{Binding ButtonClickCommand,ElementName=m}" />
      
where `m` is name of MainWindow

And now add

        public ICommand ButtonClickCommand
        {
            get { return new DelegateCommand(ButtonClick); }
        }


        private void ButtonClick(object param)
        {
            System.Windows.MessageBox.Show("EnterClick!");
        }


### How it looks like
![WPF Keyboard component](https://i.gyazo.com/3af2f77ebf46a8097c7c14bdf4c292ec.png)


### Contact information

contact me via email y_o_z(at)mail.ru



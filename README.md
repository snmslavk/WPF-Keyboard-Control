[![Build status](https://ci.appveyor.com/api/projects/status/py2u4lm82ud0m91q?svg=true)](https://ci.appveyor.com/project/snmslavk/wpf-on-screen-keyboard)

## WPF on screen keyboard control
![WPF Keyboard component](https://i.gyazo.com/7445eaf6a94b12b6c2a26677d6f1d8cb.gif)

This is a component for WPF applications

It works under .Net Framework 4

### How to use
#### Getting started
Use nuget console

      PM> Install-Package WPFTouchKeyboard

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






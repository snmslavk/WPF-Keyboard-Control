[![Build status](https://ci.appveyor.com/api/projects/status/py2u4lm82ud0m91q?svg=true)](https://ci.appveyor.com/project/snmslavk/wpf-on-screen-keyboard)
[![NuGet version](https://badge.fury.io/nu/WPFTouchKeyboard.svg)](https://badge.fury.io/nu/WPFTouchKeyboard)

## WPF Touch Keyboard Control
![WPF Keyboard component](https://viacheslavavsenev.gallerycdn.vsassets.io/extensions/viacheslavavsenev/wpfkeyboard/1.0/1482143221144/208491/1/68747470733a2f2f692e6779617a6f2e636f6d2f37343435656166366139346231326236633261323636373.gif)

This is a component for WPF applications

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


#### Can I help you?

Of course yes! Any pull-request will be considered.

You can take any issue with the label [Up for Grabs](https://github.com/snmslavk/WPF-Keyboard-Control/issues?q=is%3Aissue+is%3Aopen+label%3A%22Up+for+Grabs%22)

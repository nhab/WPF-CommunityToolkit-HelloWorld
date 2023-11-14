# A Hello,World! sampple app for WPF MVVM CommunityToolkit.

# Project structure 
- The application Main window is set In the **StartupUrl** property of **Application** tag of **App.xaml**
- In the **MainWindiw.xaml", we have grid tag to specify the location of elements.
- The Load Button funcionality is set in the command property :
```
 <Button  Command="{Binding ClickCommand}"  ... />
```
  The real impelementation of the Click command is in the **Click()** method of The **MainWindowViewModel** class in **MainWindowViewModel.cs** :
```
[RelayCommand(CanExecute = nameof(CanClick))]
private async Task Click()
```


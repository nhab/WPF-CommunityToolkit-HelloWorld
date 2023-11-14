# A Hello,World! sampple app for WPF MVVM CommunityToolkit.

# Project structure 
- To use **CommunityToolkit.Mvvm** in the project, its **nuget package** is added to the project
- The application Main window is set In the **StartupUrl** property of **Application** tag of **App.xaml**
- In the **MainWindiw.xaml", we have grid tag to specify the location of elements.
- The Load Button funcionality is set in the command property :
```
 <Button  Command="{Binding ClickCommand}"  ... />
```
  The real impelementation of the Click command is in **Click()** method > **MainWindowViewModel** class > **MainWindowViewModel.cs** :
```
[RelayCommand(CanExecute = nameof(CanClick))]
private async Task Click()
```


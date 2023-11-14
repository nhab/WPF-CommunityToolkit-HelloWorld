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
# ObservableObject
- MainWindowViewModel inherits form ObservableObject
- It makes notification when a property changed
- For example you define 
```
    [ObservableProperty]
    private DataView dataView1 = new DataView();
```
CommunityToolkit creates public DataView1 property which can be changed inside the code.for example inside the Click relay command:
```
 [RelayCommand(CanExecute = nameof(CanClick))]
 private async Task Click()
 {
     DataView1 = FolderService.Get(thePath).DefaultView;   
 }
```
This will be reflected to the anything which is binded to DataView1 in the Xaml file(MainWindow.xaml)
for Example:
```
<DataGrid
    x:Name="datagrid1"
    AutoGenerateColumns="True" 
    ItemsSource="{Binding Path=DataView1}"
 />
```




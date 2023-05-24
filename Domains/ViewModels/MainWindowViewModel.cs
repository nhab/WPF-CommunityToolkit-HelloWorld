using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        public MainWindowViewModel(string path)
        {
            thePath = path;
        }
        [ObservableProperty]
        private DataView dataView1 = new DataView();

        [ObservableProperty]
         string? thePath = @"C:\\";


        private bool CanClick() => true;

        [RelayCommand(CanExecute = nameof(CanClick))]
        private async Task Click()
        {
          
            DataView1 = FolderService.Get(thePath).DefaultView;
          
        }
    }
}

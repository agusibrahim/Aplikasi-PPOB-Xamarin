using App9test1.Interfaces;
using App9test1.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App9test1.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Title { get; set; }
        public ObservableCollection<string> datanama { get; set; } = new ObservableCollection<string>();
        public ICommand getDeviceInfo { get; set; }
        public MainViewModel() {
            Title = "Home";
            for(var i = 0; i < 10; i++) {
                datanama.Add("Agus Ibrahim " + i);
            }
            getDeviceInfo=new Command(() => {
                Title = "Hello from ";
                Debug.WriteLine("==== from Agus");
                //DependencyService.Get<NavigationInterface>().GetNavigation().Navigation.PushAsync(new Page1());
                //datanama.Insert(0,"agus "+DateTime.Now.Millisecond);
                App.globalpage.Navigation.PushAsync(new Page1());
            });
        }
    }
}

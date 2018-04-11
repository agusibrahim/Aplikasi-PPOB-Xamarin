using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using App9test1.Annotations;
using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;
using Xamarin.Forms;

namespace App9test1.ViewModel
{
    public class LoginViewModel: BaseViewModel {
        public Command LoginCommand { get; set; }
        bool _isbusy = false;

        public bool isBusy
        {
            get => _isbusy;
            set => SetProperty(ref _isbusy,value);
        }

        public Command LoginFpCommand { get; set; }
        public bool isFpSupported { get; set; } = false;

        public LoginViewModel()
        {
            isFpSupported = CrossFingerprint.Current.IsAvailableAsync(true).Result;
            LoginFpCommand=new Command(async() =>
            {
                var result = await CrossFingerprint.Current.AuthenticateAsync("Validate your fingerprint to Enter the App");
                if (result.Authenticated) {
                    EnterDashboard();
                } else if(result.Status == FingerprintAuthenticationResultStatus.Failed) {
                    isBusy = false;
                    await Application.Current.MainPage.DisplayAlert("Auth", "Authentication Error", "OK");
                    // not allowed to do secret stuff :(
                }
            });
            LoginCommand = new Command(async() => { EnterDashboard(); });
        }

        private void EnterDashboard()
        {
            isBusy = true;
            Device.StartTimer(TimeSpan.FromSeconds(3), () =>
            {
                Application.Current.MainPage.Navigation.InsertPageBefore(new TabbedPage1(),
                    App.main);
                Application.Current.MainPage.Navigation.PopAsync();
                isBusy = false;
                return false;
            });
        }
    }
}

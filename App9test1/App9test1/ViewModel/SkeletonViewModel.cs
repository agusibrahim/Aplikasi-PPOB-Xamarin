using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App9test1.ViewModel
{
    public class SkeletonViewModel:BaseViewModel
    {
        public Command showDialog { get; set; }

        public SkeletonViewModel()
        {
            showDialog=new Command(async () =>
            {
                // test ActionSheet
                var action = await Application.Current.MainPage.DisplayActionSheet("Are you sure want to delete this file?", "Cancel", "Delete", "Photo Roll", "Email");

            });
        }
    }
}

using App9test1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(NavigationService))]
namespace App9test1.Interfaces
{
    public class NavigationService : NavigationInterface {
        Page navigation;
        public Page GetNavigation() {
            return navigation;
        }

        public int getNumber() {
            return 123;
        }

        public void SetNavigation(Page nav) {
            navigation = nav;
        }
    }
}

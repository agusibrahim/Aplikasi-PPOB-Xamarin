using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App9test1.Interfaces
{
    public interface NavigationInterface
    {
        int getNumber();
        Page GetNavigation();
        void SetNavigation(Page navigation);
    }
}

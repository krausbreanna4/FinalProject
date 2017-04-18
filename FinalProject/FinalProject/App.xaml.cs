using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FinalProject
{
    public partial class App : Application
    {
        public static Page GetMainPage()
        {
            return new MainPage();
        }

    }
}

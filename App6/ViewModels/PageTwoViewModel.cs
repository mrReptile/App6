using App6.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App6.ViewModels
{
    class PageTwoViewModel : BaseModel
    {

        Command goRoot;
        Command goPageThree;

        public PageTwoViewModel(INavigation navigation) : base(navigation)
        {

        }

        public Command GoRoot
        {
            get => goRoot ?? (goRoot = new Command(GoRootAction));
        }

        public void GoRootAction() {
            Navigation.PopToRootAsync();
        }

        public Command GoPageThree {
            get => goPageThree ?? (goPageThree = new Command(GoPageThreeAction));
        }

        public void GoPageThreeAction() {
            Navigation.PushAsync(new NavigationPage(new PageThree() ));
        }



    }
}

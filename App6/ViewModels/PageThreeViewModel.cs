using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App6.ViewModels
{
    class PageThreeViewModel : BaseModel
    {
        Command goRoot;
        public PageThreeViewModel(INavigation navigation) : base(navigation) {

        }

        public Command GoRoot {
            get => goRoot ?? (goRoot = new Command(GoRootAction));
        }

        public void GoRootAction() {
            Navigation.PopToRootAsync();
        }
    }
}

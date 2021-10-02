using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App6.ViewModels
{
    class MainViewModel : BaseModel
    {

        Command goViewTwo;
        private string nombre;
        private string contra;
        private bool isError;

        public MainViewModel(INavigation navigation) : base(navigation)
        {
            Navigation = navigation;
        }

        public string Nombre
        {
            get => nombre;
            set
            {
                nombre = value;
                OnPropertyChanged();
            }
        }

        public string Contra {
            get => contra;
            set {
                contra = value;
                OnPropertyChanged();
            }
        }

        public bool IsErrorLogIn
        {
            get => isError;
            set
            {
                isError = value;
                OnPropertyChanged();
            }
        }


        public Command GoViewTwo
        {
            get => goViewTwo ?? (goViewTwo = new Command(GoViewTwoAction));
        }

        public void GoViewTwoAction()
        {
            IsErrorLogIn = !(Nombre == "Hola" && Contra == "nada");

            if (!IsErrorLogIn)
            {
                Nombre = String.Empty;
                Contra = String.Empty;

                Navigation.PushAsync(new NavigationPage(new PageTwo()));
            }
        }


    }
}

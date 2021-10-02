using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using System.Runtime.CompilerServices;

namespace App6.ViewModels
{
    class BaseModel : INotifyPropertyChanged
    {

        public BaseModel(INavigation navigation)
        {
            Navigation = navigation ?? App.Navigation;
        }

        public INavigation Navigation { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void  OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

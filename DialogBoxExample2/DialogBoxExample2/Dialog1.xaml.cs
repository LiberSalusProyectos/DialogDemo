using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DialogBoxExample2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dialog1 : ContentPage
    {
        public Dialog1ViewModel vm;

        protected override Boolean OnBackButtonPressed()
        {
            return true;
        }
        public Dialog1()
        {
            InitializeComponent();
            vm = new Dialog1ViewModel();
            BindingContext = vm;

            btnOpcion1.Clicked +=async (e, a) =>
              {
                  vm.NumOpcionSeleccionada = 1;
                  await Navigation.PopModalAsync();
              };

            btnOpcion2.Clicked += async (e, a) =>
            {
                vm.NumOpcionSeleccionada = 2;
                await Navigation.PopModalAsync();
            };

            btnOpcion3.Clicked += async (e, a) =>
            {
                vm.NumOpcionSeleccionada = 3;
                await Navigation.PopModalAsync();
            };

       

    }
    }

    public class Dialog1ViewModel
    {
        public EventHandler<Int32> OpcionSeleccionada;
        private Int32 numOpcionSeleccionada;
        public Int32 NumOpcionSeleccionada
        {
            get { return numOpcionSeleccionada;  }
            set
            {
                numOpcionSeleccionada = value;
                EventHandler<Int32> handler = OpcionSeleccionada;
                if (handler != null)
                {
                    handler(this, numOpcionSeleccionada);
                }
            }
        }

        public Dialog1ViewModel()
        {
            numOpcionSeleccionada = 0;
        }

     
    }
}
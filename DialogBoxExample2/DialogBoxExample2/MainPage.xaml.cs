using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DialogBoxExample2
{
    public partial class MainPage : ContentPage
    {
         
        public MainPage()
        {
            InitializeComponent();

       
            this.btnMain.Clicked +=async (e, a) =>
            {
                Dialog1 dlg = new Dialog1();
                dlg.vm.OpcionSeleccionada += (s, p) =>
                {
                    this.lblResultado.Text = "La opción seleccionada fue la " +  p.ToString();
                };

                await Navigation.PushModalAsync(dlg);

     
                
            };
        }

     
    }
}

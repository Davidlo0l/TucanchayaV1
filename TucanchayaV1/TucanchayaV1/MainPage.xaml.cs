using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TucanchayaV1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
      
           
			InitializeComponent();
            Btningresar.Clicked += Btningresar_Clicked;
        }

        private  async void Btningresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Menu ());
        }
    }
}

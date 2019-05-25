using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DropPlus.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DropPlus.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PopularResortsPage : ContentPage
	{
		public PopularResortsPage()
		{
			InitializeComponent ();

            BindingContext = new PopularResortsViewModel();
        }
    }
}
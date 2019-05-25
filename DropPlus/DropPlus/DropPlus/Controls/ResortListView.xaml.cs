using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DropPlus.Models;
using DropPlus.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DropPlus.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResortListView : ContentView
	{
        public ResortListView ()
		{
			InitializeComponent ();
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                ((ListView) sender).SelectedItem = null;
                Navigation.PushAsync(new ResortDetailsPage() { BindingContext = e.SelectedItem });
            }
        }
    }
}
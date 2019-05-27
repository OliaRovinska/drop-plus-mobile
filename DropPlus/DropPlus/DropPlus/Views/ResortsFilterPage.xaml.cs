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
	public partial class ResortsFilterPage : ContentPage
	{
        public delegate void ApplyFilterEventHandler(ResortsFilterViewModel filter);
        public event ApplyFilterEventHandler OnApplyFilter;

        public ResortsFilterPage ()
		{
			InitializeComponent ();
		}

        private void OnApplyFilterClick(object sender, EventArgs e)
        {
            var filter = (ResortsFilterViewModel)BindingContext;
            OnApplyFilter?.Invoke(filter);
            Navigation.PopAsync();
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                ((ListView)sender).SelectedItem = null;
            }
        }
    }
}
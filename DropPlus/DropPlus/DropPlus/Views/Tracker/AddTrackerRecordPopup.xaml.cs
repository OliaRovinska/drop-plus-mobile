using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DropPlus.Models;
using DropPlus.Services;
using DropPlus.ViewModels;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DropPlus.Views.Tracker
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddTrackerRecordPopup : PopupPage
	{
        public delegate void AddRecordEventHandler(TrackedDayRecordViewModel record);
        public event AddRecordEventHandler OnAddRecord;

        public AddTrackerRecordPopup ()
		{
			InitializeComponent ();

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += OnClose;
            CloseImage.GestureRecognizers.Add(tapGestureRecognizer);
        }

        private void OnClose(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();
        }

        private void OnAddRecordClick(object sender, EventArgs e)
        {
            var record = (TrackedDayRecordViewModel)BindingContext;
            OnAddRecord?.Invoke(record);
            PopupNavigation.Instance.PopAsync();
        }
    }
}
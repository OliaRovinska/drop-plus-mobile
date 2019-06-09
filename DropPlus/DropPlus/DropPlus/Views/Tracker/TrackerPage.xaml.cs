using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AutoMapper;
using DropPlus.Models;
using DropPlus.Services;
using DropPlus.ViewModels;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DropPlus.Views.Tracker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrackerPage : ContentPage
    {
        public TrackerPage()
        {
            InitializeComponent();

            BindingContext = Mapper.Map<UserViewModel>(App.User);
        }
        private void OnHistoryPage(object sender, EventArgs e)
        {
            var page = new HistoryPage() { BindingContext = BindingContext };
            Navigation.PushAsync(page);
        }

        protected override void OnAppearing()
        {
            BindingContext = Mapper.Map<UserViewModel>(App.User);
        }

        private void OnAddRecordClick(object sender, EventArgs e)
        {
            var popup = new AddTrackerRecordPopup() {BindingContext = new TrackedDayRecordViewModel()};
            popup.OnAddRecord += OnAddRecord;
            PopupNavigation.Instance.PushAsync(popup);
        }

        private void OnAddRecord(TrackedDayRecordViewModel recordViewModel)
        {
            TrackerService.AddRecordToday(Mapper.Map<TrackedDayRecordModel>(recordViewModel));
            // add to view model
            var user = (UserViewModel)BindingContext;
            var trackedToday = user.TrackedToday();
            trackedToday.Records.Add(recordViewModel);

            BindingContext = Mapper.Map<UserViewModel>(App.User);
        }
    }
}
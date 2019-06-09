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
	public partial class HistoryPage : ContentPage
	{
		public HistoryPage ()
		{
			InitializeComponent ();

            RemoveRecordCommand = new Command<int>(RemoveRecord);
            EditRecordCommand = new Command<int>(EditRecord);
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                ((ListView)sender).SelectedItem = null;
            }
        }

        private void OnAddRecordClick(object sender, EventArgs e)
        {
            var popup = new AddTrackerRecordPopup() { BindingContext = new TrackedDayRecordViewModel() };
            popup.OnAddRecord += OnAddRecord;
            PopupNavigation.Instance.PushAsync(popup);
        }

        private void OnAddRecord(TrackedDayRecordViewModel recordViewModel)
        {
            var context = (UserViewModel) BindingContext;
            TrackerService.AddRecord(Mapper.Map<TrackedDayRecordModel>(recordViewModel), context.SelectedDate);
            var newContext = Mapper.Map<UserViewModel>(App.User);
            newContext.SelectedDate = context.SelectedDate;
            BindingContext = newContext;
        }

        public ICommand EditRecordCommand { get; }
        private void EditRecord(int id)
        {
            var context = (UserViewModel)BindingContext;
            var record = Mapper.Map<TrackedDayRecordViewModel>(TrackerService.GetRecord(id, context.SelectedDate));
            record.DrinkType = record.DrinkTypes.First(drinkType => drinkType.Name == record.DrinkType.Name);
            var popup = new AddTrackerRecordPopup() { BindingContext = record };
            popup.OnAddRecord += OnEditRecord;
            PopupNavigation.Instance.PushAsync(popup);
        }

        private void OnEditRecord(TrackedDayRecordViewModel recordViewModel)
        {
            var context = (UserViewModel)BindingContext;
            TrackerService.EditRecord(Mapper.Map<TrackedDayRecordModel>(recordViewModel), context.SelectedDate);
            var newContext = Mapper.Map<UserViewModel>(App.User);
            newContext.SelectedDate = context.SelectedDate;
            BindingContext = newContext;
        }

        public ICommand RemoveRecordCommand { get; }
        private void RemoveRecord(int id)
        {
            var context = (UserViewModel)BindingContext;
            TrackerService.RemoveRecord(id, context.SelectedDate);
            var newContext = Mapper.Map<UserViewModel>(App.User);
            newContext.SelectedDate = context.SelectedDate;
            BindingContext = newContext;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DropPlus.ViewModels;
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

        protected override void OnAppearing()
        {
            BindingContext = Mapper.Map<UserViewModel>(App.User);
        }
    }
}
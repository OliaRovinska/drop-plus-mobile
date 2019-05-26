using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DropPlus.Models;
using DropPlus.Services;
using DropPlus.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DropPlus.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResortDetailsPage : ContentPage
	{
		public ResortDetailsPage()
		{
			InitializeComponent ();

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += OnAddReviewPage;
            addReviewImage.GestureRecognizers.Add(tapGestureRecognizer);
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                ((ListView)sender).SelectedItem = null;
            }
        }

        private void OnAddReviewPage(object sender, EventArgs e)
        {
            var addReviewPage = new AddReviewPage() {BindingContext = new ReviewViewModel()};
            addReviewPage.OnAddReview += OnAddReview;
            Navigation.PushAsync(addReviewPage);
        }

        private void OnAddReview(ReviewViewModel reviewViewModel)
        {
            // add to view model
            var resortViewModel = (ResortViewModel) BindingContext;
            resortViewModel.Reviews.Add(reviewViewModel);

            // add to review
            var review = Mapper.Map<ReviewModel>(reviewViewModel);
            var resort = ResortsService.Get(resortViewModel.Id);
            resort.Reviews.Add(review);
            
        }
    }
}
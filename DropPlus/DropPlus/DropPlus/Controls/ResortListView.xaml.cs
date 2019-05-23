using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DropPlus.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DropPlus.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResortListView : ContentView
	{
        public static readonly BindableProperty ResortsProperty = BindableProperty.Create(
            propertyName: "Resorts",
            returnType: typeof(List<ResortModel>),
            declaringType: typeof(ResortListView));

        public List<ResortModel> Resorts
        {
            get => (List<ResortModel>)GetValue(ResortsProperty);
            set => SetValue(ResortsProperty, value);
        }

        public ResortListView ()
		{
			InitializeComponent ();
        }
    }
}
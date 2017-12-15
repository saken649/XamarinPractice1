using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OPRegi_DisplayOnly
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserHistories : ContentPage
	{
		public UserHistories ()
		{
			InitializeComponent ();
		}

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            (sender as ListView).SelectedItem = null;

            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new HistoryList((Shop)e.SelectedItem));
            }
        }
    }
}
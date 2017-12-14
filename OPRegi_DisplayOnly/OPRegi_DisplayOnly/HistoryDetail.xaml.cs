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
	public partial class HistoryDetail : ContentPage
	{
        private HistoryDetailViewModel historyDetailViewModel;

        public HistoryDetail (UserHistory selected)
		{
			InitializeComponent ();
            this.historyDetailViewModel = new HistoryDetailViewModel();
            historyDetailViewModel.ShopName = selected.ShopName;
            this.BindingContext = historyDetailViewModel;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}
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
        //private HistoryDetailViewModel historyDetailViewModel;

        public HistoryDetail (OrderList Selected)
		{
			InitializeComponent ();
        }
    }
}
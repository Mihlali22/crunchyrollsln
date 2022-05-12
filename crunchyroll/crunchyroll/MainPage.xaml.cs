using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace crunchyroll
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Premuim());

         /*   WebView _browser = new WebView
            {
                Source = "https://www.crunchyroll.com/offer-nextlevel?utm_source=paid_cr&utm_medium=google-search&utm_campaign=conversion&utm_term=crunchyroll&referrer=paid_cr_google-search_conversion&gclid=EAIaIQobChMIlsWk1cTX9wIVC7DtCh1wxwwZEAAYASAAEgI6svD_BwE"
            };
         */
        }
    }
}

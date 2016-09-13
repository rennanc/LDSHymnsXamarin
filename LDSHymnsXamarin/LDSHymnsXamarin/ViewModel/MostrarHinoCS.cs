using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace LDSHymnsXamarin.ViewModel
{
    public class MostrarHinoCS : ContentPage
    {
        public MostrarHinoCS()
        {

            Padding = new Thickness(0, 20, 0, 0);
            Content = new StackLayout
            {
                Children = {
                    new CustomWebView {
                        Uri = "Tamarin.pdf",
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.FillAndExpand
                    }
                }
            };
        }
    }
}

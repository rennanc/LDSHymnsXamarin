using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LDSHymnsXamarin.ViewModel;
using Xamarin.Forms;

namespace LDSHymnsXamarin.View
{
    public partial class MostrarHino : ContentPage
    {
        public MostrarHino()
        {
            MostrarHinoViewModel viewModel = new MostrarHinoViewModel(this);
            BindingContext = viewModel;
            InitializeComponent();
        }
    }
}

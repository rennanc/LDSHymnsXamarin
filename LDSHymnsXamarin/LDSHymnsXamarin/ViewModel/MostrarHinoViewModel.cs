using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace LDSHymnsXamarin.ViewModel
{
    public class MostrarHinoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ContentPage page;

        public MostrarHinoViewModel(ContentPage page)
        {
            this.page = page;

            //criando espaçamento de status do celular
            this.page.Padding = new Thickness(0, 20, 0, 0);

            //configurando conteudo da view
            this.page.Content = new StackLayout
            {
                Children = {
                    new CustomWebView {
                        Uri = "Tamarin.pdf",
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.FillAndExpand
                    }
                }
            };

            //mensagem de teste
            string msg = "Pagina de teste para leitura de pdf do hino";
            this.page.DisplayAlert("Salvar Refeição", msg, "OK");

        }

        private void OnPropertyChanged(string nome)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(nome));
        }


    }
}

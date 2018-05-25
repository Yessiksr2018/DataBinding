using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBinding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage1 : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        [XamlCompilation(XamlCompilationOptions.Compile)]
        public partial class ListPage1 : ContentPage
        {
            public List<Page> Paginas { get; set; }
            public ListPage1()
            {
                InitializeComponent();
                Paginas = new List<Page>()
            {
                new BindingList(),
                new MainPage()
            };
                this.BindingContext = this;
                listaVista.ItemSelected += ListaVista_ItemSelected;
            }

            private void ListaVista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
            {
                if (e.SelectedItem != null)
                {
                    this.Navigation.PushAsync((Page)e.SelectedItem);
                }
                listaVista.SelectedItem = null;
            }
        }
    }

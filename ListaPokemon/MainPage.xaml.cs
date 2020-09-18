using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace ListaPokemon
{
    public partial class MainPage : ContentPage
    {
        internal ObservableCollection<Pokemon> Pokemons = new ObservableCollection<Pokemon>
        {
            new Pokemon
            {
                Imagem = "abra.png",
                Nome="Abra",
                Tipo="Psi"
            },
            new Pokemon
            {
                Imagem="alakazam",
                Nome="alalazam",
                Tipo="Psi"
            },
            new Pokemon
            {
                Imagem="charmander.png",
                Nome="Charmander",
                Tipo="Fogo"
            },
        };
        public MainPage()
        {
            InitializeComponent();
            lstPokemon.ItemsSource = Pokemons;
        }

        private void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {

            if(e.SelectedItem == null)
            {
                return;
            }
            DisplayAlert("Items Selecionado: ", ((Pokemon)e.SelectedItem).Nome, "ok");
            lstPokemon.SelectedItem = null;
        }
    }
}

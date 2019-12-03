
using PokemonMVVM.DAL;
using PokemonMVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMVVM.ViewModels
{
    public class PokemonViewModel : INotifyPropertyChanged
    {
        public PokemonViewModel()
        {
            LoadCharacters();
        }

        public async void LoadCharacters()
        {
            Pokemons = await PokemonAPIDAL.LoadCharacters();
        }


        private List<Pokemon> pokemons;

        public List<Pokemon> Pokemons
        {
            get
            {
                return pokemons;
            }
            set
            {
                pokemons = value;
                OnPropertyChange("Pokemons");
            }
        }

        private Pokemon selectedPokemon;

        public Pokemon SelectedPokemon
        {
            get
            {
                return selectedPokemon;
            }
            set
            {
                selectedPokemon = value;
                OnPropertyChange("SelectedPokemon");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
using System.Collections.ObjectModel;
using PokemonLike.Models;
using PokemonLike.Services;

namespace PokemonLike.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Monster> Monsters { get; set; }
        public Monster SelectedMonster { get; set; }

        public MainViewModel()
        {
            LoadMonsters();
        }

        private void LoadMonsters()
        {
            Monsters = new ObservableCollection<Monster>(JsonService.LoadMonsters());
        }
    }
}

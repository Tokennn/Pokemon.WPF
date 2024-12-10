using System.Collections.ObjectModel;
using PokemonLike.Models;

namespace PokemonLike.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public ObservableCollection<Login> Users { get; set; }

        public UserViewModel()
        {
            Users = new ObservableCollection<Login>();
        }

        public void AddUser(string username, string passwordHash)
        {
            Users.Add(new Login { Username = username, PasswordHash = passwordHash });
        }
    }
}

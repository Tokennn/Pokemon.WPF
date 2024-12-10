using System.Windows;
using PokemonLike.Models;

namespace PokemonLike.Views
{
    public partial class SpellView : Window
    {
        public SpellView(Spell spell)
        {
            InitializeComponent();

            // Afficher les d�tails du sort
            SpellName.Text = spell.Name;
            SpellDamage.Text = spell.Damage.ToString(); ;
            SpellDescription.Text = spell.Description;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();  // Fermer la fen�tre popup
        }
    }
}

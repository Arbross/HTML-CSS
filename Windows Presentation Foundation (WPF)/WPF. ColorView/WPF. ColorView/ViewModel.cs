using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPF._ColorView
{
    public class ViewModel
    {
        public Color SelectedItemInList { get; set; }
        public ObservableCollection<Color> Colors { get; set; } = new ObservableCollection<Color>();
        public Color CurrentColor { get; set; } = new Color();
        public RelayCommand AddCommand { get; set; }
        public RelayCommand RemoveCommand { get; set; }
        public ViewModel()
        {
            AddCommand = new RelayCommand(
                (o) => Colors.Add(CurrentColor)
                );
            RemoveCommand = new RelayCommand(
                (o) => Colors.Remove(SelectedItemInList),
                (o) => SelectedItemInList != null
                );
        }
    }
}

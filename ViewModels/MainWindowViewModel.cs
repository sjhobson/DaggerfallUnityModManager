using System.Collections.Generic;
using System.Collections.ObjectModel;
using DynamicData;

namespace DaggerfallUnityModManager.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting { get; } = "Welcome to Avalonia!";

        public ObservableCollection<ModEntry> Mods { get; set; }

        public MainWindowViewModel()
        {
            var exampleMods = new List<ModEntry>
            {
                new("ex1", "ex1", false, 0),
                new("ex2", "asfd", true, 1),
                new("ex3", "qwerty", false, 2),
            };

            Mods = new ObservableCollection<ModEntry>(exampleMods);
        }
    }
}

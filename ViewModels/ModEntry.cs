using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaggerfallUnityModManager.ViewModels
{
    public class ModEntry
    {
        public String Name { get; }
        public String Filename { get; }
        public Boolean IsEnabled { get; set; }
        public int LoadPriority {  get; set; }

        public ModEntry(String name, String filename, Boolean isEnabled, int loadPriority)
        {
            Name = name;
            Filename = filename;
            IsEnabled = isEnabled;
            LoadPriority = loadPriority;
        }
    }
}

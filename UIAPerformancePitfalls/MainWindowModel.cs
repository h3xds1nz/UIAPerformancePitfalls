//Created on 30th May 2024
//by h3xds1nz

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace UIAPerformancePitfalls
{
    public class MainWindowModel : INotifyPropertyChanged
    {
        public RoutedCommand CommandMe { get; set; } = new();

        public static ObservableCollection<CreateEnoughToLag> TestCollection { get; set; } = [];

        public event PropertyChangedEventHandler? PropertyChanged;
    }

    public class CreateEnoughToLag(int id, string name, string description)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
    }
}

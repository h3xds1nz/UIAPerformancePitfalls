//Created on 30th May 2024
//by h3xds1nz

using System.Windows.Input;
using System.Windows;
using System.Linq;
using System;

namespace UIAPerformancePitfalls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly Random random = new();
        public MainWindowModel Model { get; set; } = new();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHI\rJKLMNOPQRS\rTUVW\nXYZ0123\n456789";
            return new string(Enumerable.Range(1, length).Select(_ => chars[random.Next(chars.Length)]).ToArray());
        }

        public MainWindow()
        {
            InitializeComponent();

            this.CommandBindings.Add(new(Model.CommandMe, CommandMe_Executed, CommandMe_CanExecute));
        }

        private void CommandMe_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;

        private void CommandMe_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (MainWindowModel.TestCollection.Count > 0)
                MainWindowModel.TestCollection.Clear();
            else
            {
                for (int i = 0; i < 2000; i++)
                    MainWindowModel.TestCollection.Add(new(i, RandomString(5), RandomString(10)));
            }
        }
    }
}
using System.Collections.ObjectModel;

namespace AvaloniaApplication2.ViewModels
{
    public class WordRow
    {
        public ObservableCollection<char> Letters { get; set; } = new();
        
        public WordRow(params char[] letters)
        {
            foreach (var letter in letters)
            {
                Letters.Add(letter);
            }
        }
    }

    public partial class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<WordRow> Attempts { get; } = new()
        {
            new WordRow('R', ' ', ' ', ' ', ' '),
            new WordRow(' ', ' ', ' ', ' ', ' '),
            new WordRow(' ', ' ', ' ', ' ', ' '),
            new WordRow(' ', ' ', ' ', ' ', ' '),
            new WordRow(' ', ' ', ' ', ' ', ' ')
        };
    }
}

using System.Collections.ObjectModel;

namespace AvaloniaApplication2.ViewModels
{
    public class WordRow
    {
        public ObservableCollection<char> Letters { get; set; } = [];
        
        public WordRow(params char[] letters)
        {
            foreach (var letter in letters)
            {
                Letters.Add(letter);
            }
        }
    }

    public class KeyboardRow
    {
        public ObservableCollection<string> Letters { get; set; } = [];

        public KeyboardRow(params string[] letters)
        {
            foreach (var letter in letters)
            {
                Letters.Add(letter);
            }
        }
    }

    public partial class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<WordRow> Attempts { get; } =
        [
            new WordRow(' ', ' ', ' ', ' ', ' '),
            new WordRow(' ', ' ', ' ', ' ', ' '),
            new WordRow(' ', ' ', ' ', ' ', ' '),
            new WordRow(' ', ' ', ' ', ' ', ' '),
            new WordRow(' ', ' ', ' ', ' ', ' ')
        ];

        public ObservableCollection<KeyboardRow> KeyboardLetters { get; } =
        [
            new KeyboardRow("Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P"),
            new KeyboardRow("A", "S", "D", "F", "G", "H", "J", "K", "L"),
            new KeyboardRow("ENTER", "Z", "X", "C", "V", "B", "N", "M", "RM")
        ];
    }
}

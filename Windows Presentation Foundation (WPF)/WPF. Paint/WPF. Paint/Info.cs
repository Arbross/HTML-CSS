using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPF._Paint
{
    public class Info : INotifyPropertyChanged
    {
        private int difficulty;
        private int fails;
        private int speed;
        private bool caseSensitive = false;
        private string words;
        private string clearWords;
        public event PropertyChangedEventHandler PropertyChanged;
        public int Difficulty
        {
            get => difficulty;
            set
            {
                difficulty = value;
                Update();
            }
        }
        public int Fails
        {
            get => fails;
            set
            {
                fails = value;
                Update();
            }
        }
        public string ClearWords
        {
            get => clearWords;
            set
            {
                clearWords = value;
                Update();
            }
        }
        public int Speed
        {
            get => speed;
            set
            {
                speed = value;
                Update();
            }
        }
        public bool CaseSensitive
        {
            get => caseSensitive;
            set
            {
                caseSensitive = value;
                Update();
            }
        }
        public string Words
        {
            get => words;
            set
            {
                words = value;
                Update();
            }
        }
        public Info(int difficulty, int fails, int speed, bool caseSensitive, string words, string clearWords)
        {
            Difficulty = difficulty;
            Fails = fails;
            Speed = speed;
            CaseSensitive = caseSensitive;
            Words = words;
            ClearWords = clearWords;
        }
        private void Update()
        {
            NotifyPropertyChanged(nameof(Difficulty));
            NotifyPropertyChanged(nameof(Fails));
            NotifyPropertyChanged(nameof(Speed));
            NotifyPropertyChanged(nameof(CaseSensitive));
            NotifyPropertyChanged(nameof(Words));
            NotifyPropertyChanged(nameof(ClearWords));
        }
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

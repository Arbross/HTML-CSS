using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPF._ColorView
{
    public class Color : INotifyPropertyChanged
    {
        private byte alpha;
        private byte red;
        private byte green;
        private byte blue;
        public byte Alpha
        {
            get => alpha;
            set
            {
                alpha = value;
                OnPropertyChanged(nameof(Alpha));
                OnPropertyChanged(nameof(GetColor));
            }
        }
        public byte Red
        {
            get => red;
            set
            {
                red = value;
                OnPropertyChanged(nameof(Red));
                OnPropertyChanged(nameof(GetColor));
            }
        }
        public byte Green
        {
            get => green;
            set
            {
                green = value;
                OnPropertyChanged(nameof(Green));
                OnPropertyChanged(nameof(GetColor));
            }
        }
        public byte Blue
        {
            get => blue;
            set
            {
                blue = value;
                OnPropertyChanged(nameof(Blue));
                OnPropertyChanged(nameof(GetColor));
            }
        }
        public Color(System.Windows.Media.Color color)
        {
            Alpha = color.A;
            Red = color.R;
            Green = color.G;
            Blue = color.B;
        }
        public Color(byte alpha, byte red, byte green, byte blue)
        {
            Alpha = alpha;
            Red = red;
            Green = green;
            Blue = blue;
        }
        public override string ToString()
        {
            return $"{GetColor}";
        }
        public string Code
        {
            get => this.ToString();
        }
        public System.Windows.Media.Color GetColor
        {
            get => System.Windows.Media.Color.FromArgb(Alpha, Red, Green, Blue);
        }
        public Color() : this(0, 0, 0, 0) { }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

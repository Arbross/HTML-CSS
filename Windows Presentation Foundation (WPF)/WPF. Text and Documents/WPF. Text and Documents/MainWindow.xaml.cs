using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF._Text_and_Documents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<System.Drawing.Color> colors;
        public ObservableCollection<int> sizes;
        public MainWindow()
        {
            InitializeComponent();
            colors = new ObservableCollection<System.Drawing.Color>();
            sizes = new ObservableCollection<int>();
            foreach (KnownColor color in Enum.GetValues(typeof(KnownColor)))
            {
                System.Drawing.Color col = System.Drawing.Color.FromKnownColor(color);
                colors.Add(col);
            }
            Colors.ItemsSource = colors;
            for (int i = 0; i < 72; i++)
            {
                sizes.Add(i);
            }
        }
        private void Bold_Click(object sender, RoutedEventArgs e)
        {
            rtbText.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
        }

        private void Italic_Click(object sender, RoutedEventArgs e)
        {
            rtbText.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Italic);
        }

        private void Underline_Click(object sender, RoutedEventArgs e)
        {
            rtbText.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Underline);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rtbText.SelectAll();
            rtbText.Selection.ClearAllProperties();
        }

        private void Colors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //rtbText.SelectionBrush = (System.Drawing.Color)Colors.SelectedValue;
            rtbText.IsInactiveSelectionHighlightEnabled = true;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TextRange tmp = new TextRange(rtbText.Selection.Start, rtbText.Selection.End);
            tmp.ApplyPropertyValue(TextElement.FontSizeProperty, Size.SelectedValue);
        }
    }
}

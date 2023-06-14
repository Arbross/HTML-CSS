using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPF._Paint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Info info = new Info(0, 0, 0, false, null, null);
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = info;
            stop.IsEnabled = false;
            SetUnvisible();
        }
        private int counter;
        private int fails;
        private void q_Click(object sender, RoutedEventArgs e)
        {
            if (start.IsEnabled == false)
            {
                Button tmp = sender as Button;
                fillLbl.Content += (string)tmp.Content;
                string str = (string)tmp.Content;
                if ((string)fillLbl.Content == info.ClearWords)
                {
                    MessageBox.Show("You won!");
                }
                if (str[str.Length - 1] != info.ClearWords[counter])
                {
                    if (counter == info.ClearWords.Length - 1)
                    {
                        stop_Click(null, null);
                        MessageBox.Show("You lose!");
                        return;
                    }
                    ++fails;
                    Fails.Content = Convert.ToString(fails);
                }
                ++counter;
            }
        }
        private void Generate()
        {
            const int num_letters = 5;
            char[] letters;
            if (info.CaseSensitive == true)
            {
                letters = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!@#$%^&*()-=_+`:?><{},./[];'~".ToCharArray();
            }
            else 
            {
                letters = "1234567890abcdefghijklmnopqrstuvwxyz!@#$%^&*()-=_+`:?><{},./[];'~".ToCharArray();
            }
            Random rand = new Random();

            for (int i = 1; i <= info.Difficulty; i++)
            {
                string word = "";
                for (int j = 1; j <= num_letters; j++)
                {
                    int letter_num = rand.Next(0, letters.Length - 1);
                    word += letters[letter_num];
                }
                info.Words += "     " + word;
                info.ClearWords += word;
            }
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblDifficulty.Content = Convert.ToString((int)e.NewValue);
            info.Difficulty = (int)e.NewValue;
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            if (info.Difficulty == 0)
            {
                MessageBox.Show("Please select difficulty.");
                return;
            }
            stop.IsEnabled = true;
            isUpOrDown.IsEnabled = false;
            difficulty.IsEnabled = false;
            start.IsEnabled = false;
            Generate();
        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            stop.IsEnabled = false;
            isUpOrDown.IsEnabled = true;
            difficulty.IsEnabled = true;
            start.IsEnabled = true;
            autoFillLbl.Content = String.Empty;
            fillLbl.Content = String.Empty;
            info = new Info(0, 0, 0, false, null, null);
            counter = 0;
            fails = 0;
            difficulty.Value = 0;
            Fails.Content = "0";
        }

        private void isUpOrDown_Unchecked(object sender, RoutedEventArgs e)
        {
            info.CaseSensitive = false;
        }

        private void isUpOrDown_Checked_1(object sender, RoutedEventArgs e)
        {
            info.CaseSensitive = true;
        }
        private void SetUnvisible()
        {
            PP.Visibility = Visibility.Hidden;
            QQ.Visibility = Visibility.Hidden;
            WW.Visibility = Visibility.Hidden;
            EE.Visibility = Visibility.Hidden;
            RR.Visibility = Visibility.Hidden;
            TT.Visibility = Visibility.Hidden;
            YY.Visibility = Visibility.Hidden;
            UU.Visibility = Visibility.Hidden;
            II.Visibility = Visibility.Hidden;
            OO.Visibility = Visibility.Hidden;
            AA.Visibility = Visibility.Hidden;
            SS.Visibility = Visibility.Hidden;
            DD.Visibility = Visibility.Hidden;
            FF.Visibility = Visibility.Hidden;
            GG.Visibility = Visibility.Hidden;
            HH.Visibility = Visibility.Hidden;
            JJ.Visibility = Visibility.Hidden;
            KK.Visibility = Visibility.Hidden;
            LL.Visibility = Visibility.Hidden;
            ZZ.Visibility = Visibility.Hidden;
            XX.Visibility = Visibility.Hidden;
            CC.Visibility = Visibility.Hidden;
            VV.Visibility = Visibility.Hidden;
            BB.Visibility = Visibility.Hidden;
            NN.Visibility = Visibility.Hidden;
            MM.Visibility = Visibility.Hidden;
            QQQQ.Visibility = Visibility.Hidden;
            ONEE.Visibility = Visibility.Hidden;
            TWOO.Visibility = Visibility.Hidden;
            THREEE.Visibility = Visibility.Hidden;
            FOURR.Visibility = Visibility.Hidden;
            FIVEE.Visibility = Visibility.Hidden;
            SIXX.Visibility = Visibility.Hidden;
            SEVENN.Visibility = Visibility.Hidden;
            EIGHTT.Visibility = Visibility.Hidden;
            NINEE.Visibility = Visibility.Hidden;
            ZEROO.Visibility = Visibility.Hidden;
            TIREE.Visibility = Visibility.Hidden;
            SLASHH.Visibility = Visibility.Hidden;
            UNSLASHH.Visibility = Visibility.Hidden;
            EQUEALL.Visibility = Visibility.Hidden;
            REQRIGHTT.Visibility = Visibility.Hidden;
            REQLEFTT.Visibility = Visibility.Hidden;
            COMAA.Visibility = Visibility.Hidden;
            DOTCOMAA.Visibility = Visibility.Hidden;
            UPCOMAA.Visibility = Visibility.Hidden;
            DOTT.Visibility = Visibility.Hidden;
        }
        private void SetVisible()
        {
            PP.Visibility = Visibility.Visible;
            QQ.Visibility = Visibility.Visible;
            WW.Visibility = Visibility.Visible;
            EE.Visibility = Visibility.Visible;
            RR.Visibility = Visibility.Visible;
            TT.Visibility = Visibility.Visible;
            YY.Visibility = Visibility.Visible;
            UU.Visibility = Visibility.Visible;
            II.Visibility = Visibility.Visible;
            OO.Visibility = Visibility.Visible;
            AA.Visibility = Visibility.Visible;
            SS.Visibility = Visibility.Visible;
            DD.Visibility = Visibility.Visible;
            FF.Visibility = Visibility.Visible;
            GG.Visibility = Visibility.Visible;
            HH.Visibility = Visibility.Visible;
            JJ.Visibility = Visibility.Visible;
            KK.Visibility = Visibility.Visible;
            LL.Visibility = Visibility.Visible;
            ZZ.Visibility = Visibility.Visible;
            XX.Visibility = Visibility.Visible;
            CC.Visibility = Visibility.Visible;
            VV.Visibility = Visibility.Visible;
            BB.Visibility = Visibility.Visible;
            NN.Visibility = Visibility.Visible;
            MM.Visibility = Visibility.Visible;
            QQQQ.Visibility = Visibility.Visible;
            ONEE.Visibility = Visibility.Visible;
            TWOO.Visibility = Visibility.Visible;
            THREEE.Visibility = Visibility.Visible;
            FOURR.Visibility = Visibility.Visible;
            FIVEE.Visibility = Visibility.Visible;
            SIXX.Visibility = Visibility.Visible;
            SEVENN.Visibility = Visibility.Visible;
            EIGHTT.Visibility = Visibility.Visible;
            NINEE.Visibility = Visibility.Visible;
            ZEROO.Visibility = Visibility.Visible;
            TIREE.Visibility = Visibility.Visible;
            SLASHH.Visibility = Visibility.Visible;
            UNSLASHH.Visibility = Visibility.Visible;
            EQUEALL.Visibility = Visibility.Visible;
            REQRIGHTT.Visibility = Visibility.Visible;
            REQLEFTT.Visibility = Visibility.Visible;
            COMAA.Visibility = Visibility.Visible;
            DOTCOMAA.Visibility = Visibility.Visible;
            UPCOMAA.Visibility = Visibility.Visible;
            DOTT.Visibility = Visibility.Visible;
        }
        private bool isShiftEnable = false;
        private void lshift_Click(object sender, RoutedEventArgs e)
        {
            if (isShiftEnable == false)
            {
                isShiftEnable = true;
                lshift.Background = Brushes.Gray;
                rightshift.Background = Brushes.Gray;
                SetVisible();
            }
            else
            {
                isShiftEnable = false;
                lshift.Background = Brushes.LightGray;
                rightshift.Background = Brushes.LightGray;
                SetUnvisible();
            }
        }
    }
}

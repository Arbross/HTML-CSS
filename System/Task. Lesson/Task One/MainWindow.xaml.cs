using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.IO;

namespace Task_One
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Task<int> sentence = null;
        private Task<int> symbols = null;
        private Task<int> words = null;
        private Task<int> questionSymbols = null;
        private Task<int> exclamationMark = null;

        private bool IsLoadType = false;

        public MainWindow()
        {
            InitializeComponent();
            btnEnter.IsEnabled = false;
        }

        private static int SentenceCount(string text)
        {
            int count = 0;
            foreach (char item in text)
            {
                if (item == '\n')
                {
                    count++;
                }
            }
            return count;
        }

        private static int SymbolsCount(string text)
        {
            return text.Length;
        }

        private static int WordsCount(string text)
        {
            int count = 0;
            char letter = ' ';
            foreach (char item in text)
            {
                if (item == ' ' && char.IsLetter(letter))
                {
                    count++;
                }
                else
                {
                    letter = item;
                }
            }

            return count;
        }

        private static int QuestionCount(string text)
        {
            int count = 0;
            foreach (char item in text)
            {
                if (item == (char)63)
                {
                    count++;
                }
            }
            return count;
        }

        private static int ExclamationMarkCount(string text)
        {
            int count = 0;
            foreach (char item in text)
            {
                if (item == (char)33)
                {
                    count++;
                }
            }
            return count;
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (txtbText.Text == string.Empty)
            {
                MessageBox.Show("Error of empty line.");
                return;
            }

            sentence = Task.Factory.StartNew(() => SentenceCount(txtbText.Text), CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
            symbols = Task.Factory.StartNew(() => SymbolsCount(txtbText.Text), CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
            words = Task.Factory.StartNew(() => WordsCount(txtbText.Text), CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
            questionSymbols = Task.Factory.StartNew(() => QuestionCount(txtbText.Text), CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
            exclamationMark = Task.Factory.StartNew(() => ExclamationMarkCount(txtbText.Text), CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
            

            Task.WaitAll(sentence, symbols, words, questionSymbols, exclamationMark);

            if (IsLoadType == false)
            {
                lblShow.Content = $"Sentence count : {sentence.Result}\nSymbols count : {symbols.Result}\nWords count : {words.Result}\nQuestion count : {questionSymbols.Result}\nExclamation mark : {exclamationMark.Result}";
            }
            else
            {
                File.WriteAllText("file.txt", $"Sentence count : {sentence.Result}\nSymbols count : {symbols.Result}\nWords count : {words.Result}\nQuestion count : {questionSymbols.Result}\nExclamation mark : {exclamationMark.Result}");
            }
        }

        private void btnScreen_Click(object sender, RoutedEventArgs e)
        {
            btnLogs.IsEnabled = false;
            btnScreen.IsEnabled = false;

            btnEnter.IsEnabled = true;

            IsLoadType = false;
        }

        private void btnLogs_Click(object sender, RoutedEventArgs e)
        {
            btnLogs.IsEnabled = false;
            btnScreen.IsEnabled = false;

            btnEnter.IsEnabled = true;

            IsLoadType = true;
        }
    }
}

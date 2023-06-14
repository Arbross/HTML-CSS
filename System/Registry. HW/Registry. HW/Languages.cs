using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registry.HW
{
    public class Languages
    {
        public Themes themes { get; private set; } = new Themes();
        public string lnEnMainWindow { get; private set; } = "MainWindow";
        public string lnEnBtnFontSize { get; private set; } = "FontSize";
        public string lnEnBtnEn { get; private set; } = "En";
        public string lnEnBtnUa { get; private set; } = "Ua";
        public string lnEnTbText { get; private set; } = "Size";

        public string lnUaMainWindow { get; private set; } = "Головне вікно";
        public string lnUaBtnFontSize { get; private set; } = "Шрифтовий розмір";
        public string lnUaBtnEn { get; private set; } = "Ан";
        public string lnUaBtnUa { get; private set; } = "Ук";
        public string lnUaTbText { get; private set; } = "Розмір";

        public void MoveToEn()
        {
            MainWindow.main.Title = lnEnMainWindow;
            MainWindow.main.btnFontSize.Content = lnEnBtnFontSize;
            MainWindow.main.btnEn.Content = lnEnBtnEn;
            MainWindow.main.btnUa.Content = lnEnBtnUa;
            MainWindow.main.tbFontSize.Text = lnEnTbText;
            MainWindow.main.cbLightDarkStandard.ItemsSource = themes.listEn;
        }

        public void MoveToUa()
        {
            MainWindow.main.Title = lnUaMainWindow;
            MainWindow.main.btnFontSize.Content = lnUaBtnFontSize;
            MainWindow.main.btnEn.Content = lnUaBtnEn;
            MainWindow.main.btnUa.Content = lnUaBtnUa;
            MainWindow.main.tbFontSize.Text = lnUaTbText;
            MainWindow.main.cbLightDarkStandard.ItemsSource = themes.listUa;
        }
    }
}

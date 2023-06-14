using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF._Calculator
{
    public class CalculatorController
    {
        private string first;
        private string second;
        private bool changeState;
        private bool changeStatePoint;
        private char symbol;
        public string First
        {
            get => first;
            set => first = value;
        }
        public string Second
        {
            get => second;
            set => second = value;
        }
        public bool ChangeState
        {
            get => changeState;
            set => changeState = value;
        }
        public bool ChangeStatePoint
        {
            get => changeStatePoint;
            set => changeStatePoint = value;
        }
        public char Symbol
        {
            get => symbol;
            set => symbol = value;
        }
        public CalculatorController(string first, string second)
        {
            First = first;
            Second = second;
            ChangeState = true;
        }
        public CalculatorController() : this(null, null) { }
    }
}

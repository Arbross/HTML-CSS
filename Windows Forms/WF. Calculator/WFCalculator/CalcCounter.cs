using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCalculator
{
    public class CalcCounter
    {
        private decimal first;
        private decimal second;
        private bool changeState;
        private bool stateChangeDegreesRadians;
        private char symbol;
        public decimal First
        {
            get => first;
            set => first = value;
        }
        public decimal Second
        {
            get => second;
            set => second = value;
        }
        public bool ChangeState
        {
            get => changeState;
            set => changeState = value;
        }
        public char Symbol
        {
            get => symbol;
            set => symbol = value;
        }
        public bool StateChangeDegreesRadians
        {
            get => stateChangeDegreesRadians;
            set => stateChangeDegreesRadians = value;
        }
        public CalcCounter(int first, int second)
        {
            First = first;
            Second = second;
        }
        public CalcCounter() : this(0, 0) { }
    }
}

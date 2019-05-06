using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace UCalc
{
    public  class RPN
    {
         float _answer = 0;
         List<float> _rpnOperands = new List<float>();

        public float Operate(char operation)
        {
            _answer = 0;
            switch (operation)
            {
                case '+':
                    _answer = _rpnOperands[0] + _rpnOperands[1];
                    break;
                case '-':
                    _answer = _rpnOperands[0] - _rpnOperands[1];
                    break;
                case '*':
                    _answer = _rpnOperands[0] * _rpnOperands[1];
                    break;
                case '/':
                    _answer = _rpnOperands[0] / _rpnOperands[1];
                    break;
            }
            return _answer;
        }

        public bool Add(string value)
        {
            float newValue;
            bool success = float.TryParse(value, out newValue);

            if (success)
            {
                _rpnOperands.Add(newValue);
            }
            else
                MessageBox.Show($"Unable to convert {value} to a float.");

            return success;
        }
     
        public List<float> Operands
        {
            get { return _rpnOperands; }
            set { _rpnOperands = value; }
        }

    }
}

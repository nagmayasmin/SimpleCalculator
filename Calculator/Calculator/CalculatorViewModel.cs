using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Calculator
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

       public static CalculatorModel calculatorModel { get; set; } 

        public CalculatorViewModel() 
        {
           calculatorModel = new CalculatorModel();

            this.Operand1 =  string.Empty;
            this.Operand2 = string.Empty;
            this.Operation = string.Empty;
            this.IsBackSpaceButtonEnabled = false;
            this.Result = 0;
           
        }

    
        #region Public properties

        public string Operand1
        {
            get { return calculatorModel.Operand1; }
            set { calculatorModel.Operand1 = value; }
        }

        public string Operand2
        {
            get { return calculatorModel.Operand2; }
            set { calculatorModel.Operand2 = value; }
        }

        public string Operation
        {
            get { return calculatorModel.Operation; }
            set { calculatorModel.Operation = value; }
        }

        public string Display
        {
            get { return calculatorModel.Display; }
            set
            {
                calculatorModel.Display = value;
                OnPropertyChanged("Display");
            }
        }

        public double Result
        {
            get { return calculatorModel.CalculateResult(); }
            set
            {
                calculatorModel.Result= value;
                OnPropertyChanged("Result");
            }
        }

        public bool IsBackSpaceButtonEnabled
        {
            get { return calculatorModel.IsBackSpaceButtonEnabled; }
            set
            {
                calculatorModel.IsBackSpaceButtonEnabled = value;
                OnPropertyChanged("IsBackSpaceButtonEnabled");

            }
        }

        #endregion


    }

   
}

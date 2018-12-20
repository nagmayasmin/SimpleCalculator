using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calculator
{
   public class CalculatorCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
               
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameters)
        {
            App.calculatorViewModel.Display += Convert.ToString(parameters);
            App.calculatorViewModel.IsBackSpaceButtonEnabled = App.calculatorViewModel.Display.Length > 0 && App.calculatorViewModel.Display != null;
        }
    }

    public class ResultCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
           App.calculatorViewModel.Display= Result().ToString();
        }
        public double Result()
        {  
            return App.calculatorViewModel.Result;
        }
    }

    public class BackSpaceCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            App.calculatorViewModel.Display = App.calculatorViewModel.Display.Substring(0, App.calculatorViewModel.Display.Length - 1);
            if(App.calculatorViewModel.Display == "")
             App.calculatorViewModel.IsBackSpaceButtonEnabled = false;
          
        }
    }
}

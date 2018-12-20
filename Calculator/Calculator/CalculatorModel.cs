using System;


namespace Calculator
{
    public class CalculatorModel
    {
        private string _operand1;
        private string _operand2;
        private string _operation;
        private string _display;
        private double _result;
        private bool _isBackSpaceButtonEnabled;
       

        public CalculatorModel()
        {
            ValidateOperand(_operand1);
            ValidateOperand(_operand2);
            CalculateResult();
        }

              
        public string Operand1
        {
            get
            {
                return _operand1;
            }
            set
            {
                _operand1 = value;
            }
        }

        public string Operand2
        {
            get
            {
                return _operand2; }
            set
            {
                _operand2 = value;
            }
        }

        public double Result
        {
            get
            {
                return _result ;
            }
            set
            {
                _result = value;
            }
            
        }

        public string Operation
        {
            get
            {
                return _operation;
            }
            set
            {
                _operation = value;
            }
        }

        public string Display
        {
            get
            {
                return _display;
            }
            set
            {
                _display = value;
            }
        }

        public bool IsBackSpaceButtonEnabled
        {
            get
            {
                return _isBackSpaceButtonEnabled ;
            }
            set
            {
                _isBackSpaceButtonEnabled = value ;
            }
        }



        public int ValidateOperand(string operand)
        {
            try
            {
                return Convert.ToInt32(operand);
            }

            catch(Exception)
            {
                return 0;
            }
        }

        public double CalculateResult()
        {
            string s = Display;

            if (s != null)
            {
                string[] arr = s.Split('+', '-', '*', '/');

                Operand1 = arr[0];
                Operand2 = arr[1];

                if (s.Contains("+"))
                    Operation = "+";
                if (s.Contains("-"))
                    Operation = "-";
                if (s.Contains("*"))
                    Operation = "*";
                if (s.Contains("/"))
                    Operation = "/";
            }
                
                switch (Operation)
                {
                    case "+":
                       return  _result = ValidateOperand(Operand1) + ValidateOperand(Operand2);
                                            
                    case "-":
                        return _result = ValidateOperand(Operand1) - ValidateOperand(Operand2);
                                          
                    case "*":
                        return _result = ValidateOperand(Operand1) * ValidateOperand(Operand2);
                       
                    case "/":
                        return _result = ValidateOperand(Operand1) / ValidateOperand(Operand2);
                }

                return Result = _result;

              
            }

          
        }
           
    }

    


using System;
using CalcJun.Classes;




namespace CalcJun.Interfaces
{ 
	public class Calculator : ICalculator
    {
		public Calculator()
		{
		}

        public float ExecuteOperation(string operation, float a, float b)
        {
            float res = 0;
            if(operation == "-")
            {
                Minus minus = new Minus();

               res = minus.Execute(a, b);
            }
            else if (operation == "+")
            {
                Plus plus = new Plus();

                res = plus.Execute(a, b);
            }
            else if (operation == "/")
            {
                Division division = new Division();

                res = division.Execute(a, b);
            }
            else if (operation == "*")
            {
                Multyplication multyplication = new Multyplication();

                res = multyplication.Execute(a, b);
            }

            return res;

        }

        public void InputAndCalculate()
        {
           
            string math = Console.ReadLine();  // 2 + 3
            string[] ar = math.Split();

            string operation = ar[1];
            float a = float.Parse(ar[0]);
            float b = float.Parse(ar[2]);

            float result = ExecuteOperation(operation, a, b);

            Console.WriteLine(result);
        }
    }
}


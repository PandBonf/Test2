using System;
using System.Globalization;

namespace Test2
{
    class Program
    {
     
			static readonly IFormatProvider _ifp = CultureInfo.InvariantCulture;

	class Number
		{
			readonly int _number;
			readonly int _number2;


            public Number(int number, int number2)
            {
                _number = number;
				_number2 = number2;
            }

            public string Sum()
			{
				int sum = _number + _number2;
				return sum.ToString(_ifp);
			}
		}

		static void Main(string[] args)
		{

			int someValue1;
			int someValue2;

			bool isInt1 = int.TryParse(Console.ReadLine(), out someValue1);
			bool isInt2 = int.TryParse(Console.ReadLine(), out someValue2);

			if (isInt1 && isInt2)
            {
				string result = new Number(someValue1, someValue2).Sum();
				Console.WriteLine(result);
			}
            else
            {
				Console.WriteLine("Введите значение типа int");
			}
			
			Console.ReadKey();
		}
	}

}

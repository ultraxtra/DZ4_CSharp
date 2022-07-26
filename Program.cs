using System;
using static System.Console;

namespace DZ4_CSHARP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Program1();
			//Program2();
			Program3();
			//Program4();
			ReadKey(true);

		}




		static void Program1()
		{
			var testhuman = new Human("Oleg", "Nechiporenko", 33, "Man");
			testhuman.Print();

			WriteLine();

			var testbuilder = new Builder("Oleg", "Nechiporenko", 33, "Man", "Rapper");
			testbuilder.Print();

            WriteLine();

			var testsailor = new Sailor("Oleg", "Nechiporenko", 33, "Man", "Sailor");
			testsailor.Print();

			WriteLine();

			var testpilot = new Pilot("Oleg", "Nechiporenko", 33, "Man", "Pilot");
			testpilot.Print();

        }

		static void Program2()
        {
			var testpass = new Passport("Poroshenko", "Petro", "Oleksiyovitch", "Shevchenka228", "06.06.66");
			testpass.OutInfo();

			WriteLine();

			var testforeignpass = new ForeignPassport("Poroshenko", "Petro", "Oleksiyovitch", "Shevchenka228", "06.06.66", "Poland", 1337228);
			testforeignpass.OutInfo();
        }

		static void Program3()
        {
			var testanimal = new Animal();
			testanimal.OutInfo();

			WriteLine();

			var testtiger = new Tiger();
			testtiger.OutInfo();

			WriteLine();

			var testcroco = new Crocodile();
			testcroco.OutInfo();

			WriteLine();

			var testkangoo = new Kangaroo();
			testkangoo.OutInfo();
        }

		static void Program4()
        {
			var testrectangle = new Rectangle(8, 7);
			testrectangle.CalculateArea();

			WriteLine();

			var testcircle = new Circle(6, 3.14);
			testcircle.CalculateArea();

			WriteLine();

			var testrghttrngl = new RightTriangle(5, 9);
			testrghttrngl.CalculateArea();

			WriteLine();

			var testtrapeze = new Trapeze(6, 7, 9);
			testtrapeze.CalculateArea();
        }

    }
}
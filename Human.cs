using static System.Console;
namespace DZ4_CSHARP
{
    public class Human
    {
        protected string firstName;
        protected string lastName;
        protected int age;
        protected string gender;

        public Human(string fName, string lName, int Age, string Gender){
            firstName = fName;
            lastName = lName;
            age = Age;
            gender = Gender;
    }
        public void Print()
        {
            WriteLine($"Name:{firstName}\n Surname:{lastName}\n Age:{age}\n Gender:{gender}\n");
        }

    }

    public class Builder : Human
    {
        string profession;
        public Builder(string fName, string lName,
                        int Age, string Gender, string professionn) : base( fName,  lName, Age, Gender)
        {                                                           
            
            profession = professionn;

        }

        public void Print()
        {
            WriteLine($"Name:{firstName}\n Surname:{lastName}\n Age:{age}\n Gender:{gender}\n Builder:{profession}\n ");
        }
    }
    public class Pilot : Builder
    {
        string pilot;

        public Pilot(string fName, string lName, int Age, string Gender, string pilott) : base(fName, lName, Age, Gender, pilott)
        {

            pilot = pilott;

        }

        public void Print()
        {
            WriteLine($"Name:{firstName}\n Surname:{lastName}\n Age:{age}\n Gender:{gender}\n Pilot:{pilot}\n ");
        }

    }

    public class Sailor : Pilot
    {
        string sailor;
        public Sailor(string fName, string lName,
                        int Age, string Gender, string sailorr) : base(fName, lName, Age, Gender, sailorr)
        {
            sailor = sailorr;
        }
        public void Print()
        {
            WriteLine($"Name:{firstName}\n Surname:{lastName}\n Age:{age}\n Gender:{gender}\n Sailor:{sailor}\n ");
        }

    }
}
    
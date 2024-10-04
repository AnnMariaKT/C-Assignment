//Lab 1: Hello, World! and Basic Input/output

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World");
//            Console.WriteLine("Enter username:");
//            string userName = Console.ReadLine();
//            Console.WriteLine("Hello, " + userName);

//            Console.ReadLine();

//        }
//    }
//}


//Lab 2: Input / output with Strings


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter name:");
//            string Name = Console.ReadLine();
//            Console.WriteLine("ENter Age :");
//            int age = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter favourite color:");
//            string color = Console.ReadLine();


//            Console.WriteLine($"Hello { Name} ! You are {age} years old your favourite color is {color}");

//            Console.ReadLine();

//        }
//    }
//}

//Lab 3: Input/output with Arithmetic Operations

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the numbers :");
//            int a = Convert.ToInt32(Console.ReadLine());
//            int b = Convert.ToInt32(Console.ReadLine());

//            int sum = a + b;
//            Console.WriteLine($"Sum: {a}+{b} = {sum}");
//            int difference = a - b;
//            Console.WriteLine($"Difference: {a}-{b} = {difference}");
//            int mul = a * b;
//            Console.WriteLine($"Multiplication: {a}*{b} = {mul}");

//            if ((a == 0) || (b == 0))
//            {
//                Console.WriteLine("Division by zero attempted");
//            }
//            else
//            {
//                int div = a / b;
//                Console.WriteLine($"Division : {a}/{b} = {div}");
//            }
//            Console.ReadLine();
//        }
//    }
//}




//Lab 4: Temperature Conversion


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the temperature in celcius");
//            double celcius = Convert.ToDouble32(Console.ReadLine());
//            double faren = (celcius * 9 / 5) + 32;
//            Console.WriteLine($"celcius = {celcius}");
//            Console.WriteLine($"Farenheight = {faren}");
//            Console.ReadLine();
//        }
//    }
//}




//Lab 5: Simple Interest Calculation

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {


//            Console.WriteLine("Enter the values: ");
//            double P = Convert.ToDouble(Console.ReadLine());
//            double R = Convert.ToDouble(Console.ReadLine());
//            double T = Convert.ToDouble(Console.ReadLine());

//            double SI = (P * R * T) / 100;
//            Console.WriteLine($"The Simple Interest is : {SI}");
//            Console.ReadLine();
//        }
//    }
//}





//Lab 6: Calculating the Area of a Circle


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("Enter radius:");
//            double R = Convert.ToDouble(Console.ReadLine());
//            double Area = 3.14 * R * R;
//            Console.WriteLine($"Area of the circle is: {Area}");
//            Console.ReadLine();


//        }
//    }
//}



//Lab 7: Input / output with Time Calculation

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the seconds: ");
//            int sec = Convert.ToInt32(Console.ReadLine());
//            int hour = sec / 3600;
//            int min = (sec % 3600) / 60;
//            int Sec = sec % 60;
//            Console.WriteLine($"In seconds : {sec}");
//            Console.WriteLine($"In minutes : {min}");
//            Console.WriteLine($"In Hours : {hour}");

//            Console.ReadLine();

//        }
//    }
//}




//Lab 8: String Length and Character Count

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//Console.WriteLine("Enter the string: ");
//string A = Console.ReadLine();
//int chara = A.Replace(" ","").Length;
//Console.WriteLine($"CHaracter Length is {char}");
//Console.ReadLine();


//        }
//    }
//}





//Lab 9: Body Mass Index (BMI) Calculator

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the values:");
//            double W = double.Parse(Console.ReadLine());
//            double H = double.Parse(Console.ReadLine());

//            double BMI = W / (H * H);
//            Console.WriteLine($"The BMI is {BMI}");
//            Console.ReadLine();


//        }
//    }
//}





//Lab 10: Variables and Constants

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine();
//            int a = 10;
//            float b = 3.11111f;
//            double c = 10.35;
//            char d = 'a';
//            string e = "Hello";
//            bool f = true;

//            Console.WriteLine($"Integer : {a}");
//            Console.WriteLine($"Float : {b}");
//            Console.WriteLine($"Double : {c}");
//            Console.WriteLine($"Character : {d}");
//            Console.WriteLine($"String : {e}");
//            Console.WriteLine($"Bool : {f}");
//            Console.ReadLine(); 
//        }
//    }
//}



//Lab 11: Variables and Constants


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("enter the Radius, length and breadth: ");
//    double R = Convert.ToDouble(Console.ReadLine());
//            double L = Convert.ToDouble(Console.ReadLine());
//            double B = Convert.ToDouble(Console.ReadLine());

//            double circle = 3.14 * R * R;
//            double rect = L * B;
//            Console.WriteLine($"Area of circlr = {circle}");
//            Console.WriteLine($"Area of rectangle = {rect}");
//            Console.ReadLine();
//        }
//    }
//}







// Lab 12: Using Constants


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("enter the radius: ");
//            int radius = Convert.ToInt32(Console.ReadLine());
//            const double PI = 3.14159;
//            const int DAYS_IN_WEEK = 7;
//            double area = 2 * PI * radius;
//            Console.WriteLine($"Area of the circle = {area}");
//            Console.WriteLine($"Number of Days in a week = {DAYS_IN_WEEK}");

//            Console.ReadLine();
//        }
//    }
//}



//Lab 13: Calculating Area of Rectangle

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the width and height: ");
//            double W = Convert.ToDouble(Console.ReadLine());
//            double H = Convert.ToDouble(Console.ReadLine());
//            double areaCM = W * H;
//            double areaIN = areaCM / (2.54*2.54);
//            Console.WriteLine($"area in square centimeters = {areaCM}");
//            Console.WriteLine($"area in square centimeters = {areaIN}");



//            Console.ReadLine();
//        }
//    }
//}






//Lab 14: C# Coding Standards



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the employee name, age and salary: ");
//            string Name = Console.ReadLine();
//            int age = int.Parse(Console.ReadLine());
//            double salary = double.Parse(Console.ReadLine());

//            Console.WriteLine($"Name of employee : {Name}");
//            Console.WriteLine($"Age of Employee : {age}");
//            Console.WriteLine($"Salary of employee : {salary}");

//            Console.ReadLine();
//        }
//    }
//}








//Lab 15: C# Coding Standards


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int num1 = 5;
//            int num2 = 3;
//            int sum = num1+num2;
//            Console.WriteLine($"The sum of {num1} and {num2} = {sum}");
//            Console.ReadLine();
//        }
//    }
//}






//Lab 16: Assignment Operator


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int a = 25; int b = 30;
//            Console.WriteLine($"a = {a} and b = {b}");
//            Console.ReadLine();
//        }
//    }
//}






//Lab 17: Find the Power of a Number


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the base and power: ");
//            double exp = double.Parse(Console.ReadLine());
//            double Base = double.Parse(Console.ReadLine());
//            double power = Math.Pow(Base, exp);
//            Console.WriteLine($" the value of {Base}^{exp} = {power}");

//            Console.ReadLine();
//        }
//    }
//}



//Lab 18: Check Voting Eligibility


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {


//            Console.WriteLine("ENter the age and citizenship : ");
//            int age = int.Parse(Console.ReadLine());
//            string citizen = Console.ReadLine();

//            if ((age > 18) && (citizen.ToLower() == "indian"))
//            {
//                Console.WriteLine("ELigible for voting");
//            }
//            else
//            {
//                Console.WriteLine("Not eligible for voting");
//            }



//            Console.ReadLine();
//        }
//    }
//}




//Lab 19: Determine if a Person is Eligible for a Loan


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("ENter the age,salary and does the person hhave any outstanding loans: ");
//            int age = int.Parse(Console.ReadLine());
//            int salary = int.Parse(Console.ReadLine());
//            string loan = Console.ReadLine();

//            if ((age > 21) && (salary > 30000) && (loan.ToLower() == "no"))
//            {
//                Console.WriteLine("ELigible for Loan");
//            }

//            else
//            {
//                Console.WriteLine("Not eligible for Loan");
//            }



//            Console.ReadLine();
//        }
//    }
//}






//Lab 20: Eligibility Check

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the age,experience and if the person has adegree: ");
//            int age = int.Parse(Console.ReadLine());
//            int experience = int.Parse(Console.ReadLine());
//            string degree = Console.ReadLine();

//            if ((age > 18 && age<35) && (experience> 2)  && ((degree.ToLower() == "yes") || (experience>=5)))
//            {
//                Console.WriteLine("ELigible for Job");
//            }

//            else
//            {
//                Console.WriteLine("Not eligible for Job");
//            }

//            Console.ReadLine();
//        }
//    }
//}





//Lab 21: Check if a Character is a Vowel or Consonant


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the alphabet");
//            char alphabet = char.Parse(Console.ReadLine());

//            if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u')
//            {
//                Console.WriteLine("The alphabet is a vowel");
//            }
//            else
//            {
//                Console.WriteLine("the alphabet is a consonant");
//            }
//                Console.ReadLine();
//        }
//    }
//}

//Lab 22: Check If a Number is Positive, Negative, or Zero 


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number : ");
//            int a = Convert.ToInt32(Console.ReadLine());
//            if (a == 0)
//            {
//                Console.WriteLine("the number is zero ");
//            }
//            else if (a > 0)
//            {
//                Console.WriteLine("the number is positive");
//            }
//            else
//            {
//                Console.WriteLine("the number is negative");
//            }
//            Console.ReadLine();
//        }
//    }
//}




//Lab 23: Check if a Number is Divisible by 5 and 11 



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("enter the number :");
//            int a = int.Parse(Console.ReadLine());
//            if ((a % 11 == 0) && (a % 5 == 0))
//                {
//                    Console.WriteLine("the number is  divisible by 5 and 11 ");
//                }
            
//            else
//            {
//                Console.WriteLine("the number is not divisible by both 5 and 11");
//            }

//            Console.ReadLine();
//        }
//    }
//}



















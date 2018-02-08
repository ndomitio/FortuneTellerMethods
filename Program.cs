using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerMethods
{
    class FortuneTellMethods
    {
        static void Main(string[] args)

        {
            //string userNameFirst = " ";
            //string userNameLast = " ";
            //string userResponse = " ";
            //int userAge = 0;
            //int userBirthMonth;
            //int workYears;
            //int userSiblings;
            //string userColor = " ";


            //while (FortuneTellMethods.Exit() != "exit") 
            //{
            //    FortuneTellMethods.FortuneTeller();
            //}

            string userNameFirst;
            string userNameLast;
            //string userResponse = " ";
            int userAge = 0;
            int userBirthMonth;
            int workYears;
            int userSiblings;
            string userColor;
            //string returnResponse;


            Console.WriteLine("Welcome to Fortune Teller! Press EXIT to escape at any time, or enter RESTART to restart.  What is your first name?");
            userNameFirst = Console.ReadLine().ToLower();
            //returnResponse = userNameFirst;
            //FortuneTellMethods.Exit(userNameFirst);
            FortuneTellMethods.Exit(userNameFirst);
            //Console.WriteLine(returnResponse);
            Console.WriteLine("Hello " + userNameFirst + ", what is your last name?");
            userNameLast = Console.ReadLine().ToLower();
            FortuneTellMethods.Exit(userNameLast);
            Console.WriteLine(FortuneTellMethods.Greeting(userNameFirst, userNameLast));

            Console.WriteLine("Please enter your current age. Enter 999 to restart, or 888 to quit");
            userAge = int.Parse(Console.ReadLine());

            FortuneTellMethods.Retirement(userAge);

            workYears = FortuneTellMethods.Retirement(userAge);

            Console.WriteLine("How many siblings do you have?  Enter 999 to restart, or 888 to quit");
            userSiblings = int.Parse(Console.ReadLine());

            string vacationLocation = FortuneTellMethods.VacationHome(userSiblings);

            Console.WriteLine("From the ROYGBIV sequence, choose your favorite color");
            userColor = Console.ReadLine().ToLower();
            FortuneTellMethods.Exit(userColor);
            string carType = FortuneTellMethods.Transportation(userColor);

            Console.WriteLine("Please enter the month you were born. Enter 999 to restart, or 888 to quit");
            userBirthMonth = int.Parse(Console.ReadLine());

            double moneyTotal = FortuneTellMethods.Retirement(userBirthMonth);

            FortuneTellMethods.GoodFortune();

            Console.WriteLine(userNameFirst + userNameLast + " will retire in " + workYears + " with " + moneyTotal + " in the bank, a vacation home in " + vacationLocation + " and a " + carType + ".");

        }
        //static void EscapeRestart(string entry)
        //{
        //  
        //}


        static string Exit(string entry)
        {
            string exitResponse = entry;
            switch (entry)
            {

                case "exit":
                    {
                        Environment.Exit(0);
                        return " ";
                    }
                case "restart":
                    {
                        FortuneTellMethods.FortuneTeller();
                        return " ";
                    }

                default:

                    { return exitResponse; }

            }
        }

        //Console.WriteLine("do you want to play again?");
        //userResponse = Console.ReadLine().ToLower();
        //if (answer = "exit")

        //return ;

        static string Greeting(string first, string last)
        {
            //if (first == "exit")
            //{ FortuneTellMethods.Exit(); }
            string longGreeting = "Greetings," + first + " " + last + ".  I will tell you your fortune.";
            return longGreeting;


        }

        static int Retirement(int retirement)
        {

            int workYears = retirement % 2;

            switch (workYears)
            {
                case 1:
                    workYears = 30;
                    break;
                default:
                    workYears = 35;
                    break;
            }

            return workYears;

        }
        static string VacationHome(int siblings)
        {
            string location = "home";

            switch (siblings)
            {
                case 0:
                    location = "Seattle";
                    break;
                case 1:
                    location = "Sandusky";
                    break;
                case 2:
                    location = "Toledo";
                    break;
                case 3:
                    location = "Detroit";
                    break;
            }

            if (siblings < 0)
                location = "North Korea";
            if (siblings > 3)
                location = "Florida";

            return location;
        }

        static string Transportation(string color)
        {

            string userVehicle = "car";
            switch (color)
            {
                case "red":
                    userVehicle = "1967 VW Beetle";
                    break;
                case "orange":
                    userVehicle = "1969 Dodge Charger";
                    break;

                case "yellow":
                    userVehicle = "2002 Daewoo Lanos";
                    break;
                case "green":
                    userVehicle = "Mercedes-AMG GT R";
                    break;
                case "blue":
                    userVehicle = "2006 Honda Civic";
                    break;
                case "indigo":
                    userVehicle = "2010 Chevy Cruze";
                    break;
                case "violet":
                    userVehicle = "2011 Porsche Carrera";
                    break;
                case "help":
                    Console.WriteLine("Choose from red, orange, yellow, green, blue, indigo, violet.");
                    break;
                default:
                    Console.WriteLine("Choose from red, orange, yellow, green, blue, indigo, violet.");
                    break;

            }

            color = Console.ReadLine().ToLower();

            switch (color)

            {
                case "red":
                    break;
                case "orange":
                    break;
                case "yellow":
                    break;
                case "green":
                    break;
                case "indigo":
                    break;
                case "violet":
                    break;


            }

            switch (color)
            {
                case "red":
                    userVehicle = "1967 VW Beetle";
                    break;
                case "orange":
                    userVehicle = "1969 Dodge Charger";
                    break;

                case "yellow":
                    userVehicle = "2002 Daewoo Lanos";
                    break;
                case "green":
                    userVehicle = "Mercedes-AMG GT R";
                    break;
                case "blue":
                    userVehicle = "2006 Honda Civic";
                    break;
                case "indigo":
                    userVehicle = "2010 Chevy Cruze";
                    break;
                case "violet":
                    userVehicle = "2011 Porsche Carrera";
                    break;
            }


            return userVehicle;
        }
        static double RetireMoney(int birthMonth)
        {


            double moneyTotal = 1.00;

            if ((birthMonth <= 0) || (birthMonth >= 13))
            {
                return moneyTotal = 0.00;
            }
            if ((birthMonth >= 1) && (birthMonth <= 4))

            {
                return moneyTotal = 1000000.00;
            }


            if ((birthMonth >= 9) && (birthMonth <= 12))
            {
                return moneyTotal = 5000000.00;
            }

            else if ((birthMonth >= 5) && (birthMonth <= 8))
            {
                return moneyTotal = 9000000.00;
            }
            return moneyTotal;
        }

        static void GoodFortune()
        { Console.WriteLine("Wow! That is a great fortune!"); }

        static void FortuneTeller()
        {
            string userNameFirst;
            string userNameLast;
            //string userResponse = " ";
            int userAge = 0;
            int userBirthMonth;
            int workYears;
            int userSiblings;
            string userColor;
            //string returnResponse = FortuneTellMethods.Exit();
            Console.WriteLine("Welcome to Fortune Teller! Press EXIT to escape at any time, or enter RESTART to restart.  What is your first name?");
            userNameFirst = Console.ReadLine().ToLower();
            FortuneTellMethods.Exit(userNameFirst);
            Console.WriteLine("Hello " + userNameFirst + ", what is your last name?");
            userNameLast = Console.ReadLine().ToLower();
            Console.WriteLine(FortuneTellMethods.Greeting(userNameFirst, userNameLast));

            Console.WriteLine("Please enter your current age");
            userAge = int.Parse(Console.ReadLine());
            FortuneTellMethods.Retirement(userAge);
            workYears = FortuneTellMethods.Retirement(userAge);

            Console.WriteLine("How many siblings do you have?");
            userSiblings = int.Parse(Console.ReadLine());
            string vacationLocation = FortuneTellMethods.VacationHome(userSiblings);

            Console.WriteLine("From the ROYGBIV sequence, choose your favorite color");
            userColor = Console.ReadLine().ToLower();
            string carType = FortuneTellMethods.Transportation(userColor);

            Console.WriteLine("Please enter the month you were born.");
            userBirthMonth = int.Parse(Console.ReadLine());
            double moneyTotal = FortuneTellMethods.Retirement(userBirthMonth);

            FortuneTellMethods.GoodFortune();

            Console.WriteLine(userNameFirst + userNameLast + " will retire in " + workYears + " with " + moneyTotal + " in the bank, a vacation home in " + vacationLocation + " and a " + carType + ".");
        }
    }




}




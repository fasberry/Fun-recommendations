using System;
using System.Collections.Generic;

namespace FunPlaces { }
   class MainClass
{
    static void Main(String[] args)
    {
        string[] choices = new string[] { "Action", "Chilling", "Danger", "Good Food" };
        string[] options = new string[] { "Stock Car Racing", "Hiking", "Skydiving", "To Taco Bell" };
        string[] people = new string[] { "0", "1-4", "5-10", "11+" };
        string[] travel = new string[] { "Sneakers", "A Sedan", "A Volkswagen bus", "An Airplane" };

        //Build Specifications:
        //1. Greet the user and then prompt them with the different options
        //2. Take input from the user. If it matches one of your options, print a message
        //saying your recommendation. If the input doesn’t match any options you
        //have, print a message telling the user the input was not understood.
        //3. Change your output based on both the desired activity and the number of
        //people.
        //4. Print a message saying goodbye to the user.
        //Hint: Console.WriteLine() and Console.ReadLine() will be handy for this deliverable.

        string bestOptionForUser = "";
        Console.WriteLine("What are you in the Mood for? Here are you options:");
        Console.WriteLine("Enter: Action, Chilling, Danger, Good Food");
        string Mood = Console.ReadLine();

        for (int i = 0; i < choices.Length; i++)
        {
            if (Mood.ToLower() == choices[i].ToLower()) ;
            {
                bestOptionForUser = options[i];


            }
        }
        Console.WriteLine("How Many People are you you bringing with you?", "Enter a number");
        string numFriendsAsString = Console.ReadLine();
        int numFriends = Convert.ToInt32(numFriendsAsString);

        
        string transportationMethod;

        if (numFriends == 0) ;
        transportationMethod = NewMethod(travel);

        else if (numFriends < 5)
        {
            ;
        }

        transportationMethod = travel[1];
        
        else if (numFriends < 11) ;
        (transportationMethod travel[2]);
{}
        else transportationMethod = travel[3];

        Console.WriteLine {
            " If you're in the mood for " + Mood + ", "you should go", + bestOptionForUser;


   Console.ReadKey();
            Console.ReadLine();

        }

    }

    private static string NewMethod(string[] travel)
    {
        string transportationMethod;
        { transportationMethod = travel[0]; };
        return transportationMethod;
    }
}   

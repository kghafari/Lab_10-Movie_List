using System;
using System.Collections.Generic;

namespace Lab_10_Movie_List
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //task: list movies by category

            //store a list of 10 Movies (object data type Movie)

            List<Movie> movieList = new List<Movie>
            {
                new Movie("The Shining", "Horror"),
                new Movie("Gangs of New York", "Drama"),
                new Movie("The Matrix", "Scifi"),
                new Movie("Gattica", "Scifi"),
                new Movie("Isle of Dogs", "Animated"),
                new Movie("A Dark Song", "Horror"),
                new Movie("Glee: The Movie", "Horror"),
                new Movie("Howl's Moving Castle", "Animated"),
                new Movie("The Irishman", "Drama"),
                new Movie("Rosemary's Baby", "Horror"),
            };


            bool userContinue = true;
            while (userContinue)
            {
              string userInput = GetUserInput("What genere are you interested in?\nHorror\tScifi\tDrama\tAnimated");

                Console.WriteLine();
                Movie.PrintMoviesByType(movieList, userInput);
                Console.WriteLine();

                userContinue = KeepGoing("Would you like to continue? (y/n)", "n", "y");
            }

        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static bool KeepGoing(string message, string option1, string option2)
        {
            string keepGoing = GetUserInput(message);
            if (keepGoing == option1)
            {
                return false;
            }
            else if (keepGoing == option2)
            {
                return true;
            }
            else
            {

                return KeepGoing(message, option1, option2);
            }
        }

    }
}

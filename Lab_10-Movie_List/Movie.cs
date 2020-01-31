using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10_Movie_List
{
    class Movie
    {
        //fields
        private string title;
        private string category;

        //properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Category
        {
            get { return title; }
            set { title = value; }
        }

        //constructors
        public Movie()
        {

        }

        public Movie(string _title, string _category)
        {
            title = _title;
            category = _category;
        }

        //methods
        public static void PrintMoviesByType(List<Movie> movieList, string categorySelected)
        {
            categorySelected.ToLower();
            foreach (Movie movie in movieList)
            {
                if (categorySelected == movie.category.ToLower() || categorySelected == movie.category)
                {
                    Console.WriteLine($"{movie.title}");
                }
            }
        }
    }
}

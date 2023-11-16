internal class MovieLibrary
{
    Movie[] movies;

    //Initialize our array when the library is created
    public MovieLibrary()
    {
        movies = new Movie[1];
    }
    //Adds new movies to our library and expands our array
    public void AddNewMovie(Movie movie)
    {
        movies[movies.Length - 1] = movie;
        //Increase the size of the array
        //Create a temp array and copy movies over
        Movie[] temp = new Movie[movies.Length];
        for(var i = 0; i < movies.Length; ++i)
        {
            temp[i] = movies[i];
        }
        //Create a NEW array with a greater size
        movies = new Movie[temp.Length + 1];
        //Copy the original array into this new one
        for (var i = 0; i < temp.Length; ++i)
        {
            movies[i] = temp[i];
        }
    }
    //Get the details of a movie by where it's stored in our array, a private function only we use
    private void DisplayMovieDetails(int index)
    {
        if (index < 0 || index > movies.Length)
        {
            Console.WriteLine("Movie doesn't exist");
        }
        else
        {
            Console.WriteLine($"{movies[index].title} was released in {movies[index].year} and is about {movies[index].description}");
        }
    }
    //A public facing method for DisplayDetails that can get details by the name of the movie
    public void DisplayDetails(string title)
    {
        bool foundMatch = false;
        int index = -1;

        for(var i = 0; i < movies.Length; ++i)
        {
            if (movies[i].title.ToLower() == title.ToLower())
            {
                foundMatch = true;
                index = i;
                break;
            }
        }

        if (foundMatch)
        {
            DisplayMovieDetails(index);
        }
        else
        {
            DisplayMovieDetails(-1);
        }
    }
    public Movie GetMovie(string title)
    {
        for(var i = 0; i < movies.Length; ++i)
        {
            if (movies[i].title.ToLower() == title.ToLower())
            {
                return movies[i];
            }
        }
        return null;
    }
    public void DeleteMovie(string title)
    {
        //Find the movie to delete
        int indexToDelete = -1;
        for (var i = 0; i < movies.Length; ++i)
        {
            if (movies[i].title.ToLower() == title.ToLower())
            {
                indexToDelete = i;
                movies[i] = null;
                break;
            }
        }

        //If no movie exists, get out of this method
        if (indexToDelete == -1)
        {
            Console.WriteLine("Movie doesn't exist");
            return;
        }

        //Copy movies
        Movie[] tempMovies = new Movie[movies.Length - 1];
        int counter = 0;
        for(var i = 0; i <  tempMovies.Length; ++i)
        {
            if (movies[i] != null)
            {
                tempMovies[counter] = movies[i];
                ++counter;
            }
        }

        //Recopy the updated list to our original array
        movies = new Movie[tempMovies.Length - 1];
        for(var i = 0; i < tempMovies.Length - 1; ++i)
        {
            movies[i] = tempMovies[i];
        }
    }
    public void GreetUser()
    {
        Console.WriteLine("Welcome to your movie library!");
    }
    public void DisplayInstructions()
    {
        Console.WriteLine("1 - Add a new movie\n2 - Display a movies details\n3 - Edit a movie\n4 - Delete a movie");
    }
    public int GetSize()
    {
        return movies.Length;
    }
}
MovieLibrary myLibrary = new();
myLibrary.GreetUser();
int userInput;
string movieSearch;
Movie movie;
while(true)
{
    myLibrary.DisplayInstructions();
    userInput = int.Parse(Console.ReadLine());

    if (userInput == 1)
    {
        Movie tempMovie = new();

        Console.WriteLine("Please give me the movie title.");
        tempMovie.title = Console.ReadLine();

        Console.WriteLine("What year was it released?");
        tempMovie.year = int.Parse(Console.ReadLine());

        myLibrary.AddNewMovie(tempMovie);
        Console.WriteLine("Movie added to your library!");
    }
    else if (userInput == 2)
    {
        Console.WriteLine("Which movie do you want to see details for? Enter a name");
        movieSearch = Console.ReadLine();

        myLibrary.DisplayDetails(movieSearch);
    }
    else if (userInput == 3)
    {
        Console.WriteLine("Let's edit one of your movies. Which one? Type the name of the movie.");
        movieSearch = Console.ReadLine();

        movie = myLibrary.GetMovie(movieSearch);
        if (movie == null)
        {
            Console.WriteLine("Movie not found.");
            break;
        }

        Console.WriteLine($"Which property of {movie.title} do you want to edit?\n1 - Title\n2 - Year\n3 - Month\n4 - Day\n5 - Rating\n6 - Description");
        userInput = int.Parse(Console.ReadLine());

        if (userInput == 1)
        {
            Console.WriteLine("Enter the new title now.");
            movie.title = Console.ReadLine();
        }
        else if (userInput == 2)
        {
            Console.WriteLine("Enter the new year now.");
            movie.year = int.Parse(Console.ReadLine());
        }
        else if (userInput == 3)
        {
            Console.WriteLine("Enter the new month now.");
            movie.month = int.Parse(Console.ReadLine());
        }
        else if (userInput == 4)
        {
            Console.WriteLine("Enter the new day now");
            movie.day = int.Parse(Console.ReadLine());
        }
        else if (userInput == 5)
        {
            Console.WriteLine("Enter the new rating now");
            movie.rating = int.Parse(Console.ReadLine());
        }
        else if (userInput == 6)
        {
            Console.WriteLine("Enter the new description now");
            movie.description = Console.ReadLine();
        }
    }
    else if (userInput == 4)
    {
        Console.WriteLine("Type the name of the movie you want to delete and I'll take care of it.");
        movieSearch = Console.ReadLine();

        myLibrary.DeleteMovie(movieSearch);
    }
}
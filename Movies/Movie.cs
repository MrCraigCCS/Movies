class Movie
{
    public string title;
    public int year;
    public int month;
    public int day;
    public double rating;
    public string description;

    public Movie()
    {

    }
    public Movie(string title, int year)
    {
        this.title = title;
        this.year = year;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"{title} was released in {year} and is about {description}");
    }
}
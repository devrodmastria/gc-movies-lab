//author: Rod M
//task: Unit 4 - Lab 1 - Movies Database

using MoviesLab;

bool reloadMovies = true;
Console.WriteLine("Welcome to the Alphabetical Movie Database!");
Console.WriteLine("-----------------------------------------");

List<string> categories = new List<string>() {"animated", "drama", "horror", "scifi", "documentary"};

List<Movie> movieList = new List<Movie>()
{
    new Movie("MovieF", "animated"),
    new Movie("MovieE", "animated"),

    new Movie("MovieG", "drama"),
    new Movie("MovieD", "drama"),

    new Movie("MovieH", "horror"),
    new Movie("MovieC", "horror"),

    new Movie("MovieI", "scifi"),
    new Movie("MovieB", "scifi"),

    new Movie("MovieJ", "documentary"),
    new Movie("MovieA", "documentary")
};

Console.WriteLine("There are {0} great movies available.", movieList.Count);

while (reloadMovies)
{
    Console.WriteLine("What category are you looking for?");

    foreach (string cat in categories) Console.WriteLine("> {0}", cat);

    while (true)
    {
        Console.WriteLine();
        string choice = Console.ReadLine();
        choice = choice.ToLower().Trim();
        if (categories.Contains(choice))
        {
            Console.WriteLine();
            Console.WriteLine("The following {0} titles are available:", choice);

            // setting up list in alphabetical order
            movieList.Sort((movie1, movie2) => string.Compare(movie1.title, movie2.title));

            foreach (Movie item in movieList) if (item.category == choice) { Console.WriteLine(item.title); }
            Console.WriteLine();
            break;
        }
        else
        {
            Console.WriteLine("You entered '{0}' - Please enter valid category", choice);
        }

    }

    Console.WriteLine();
    Console.WriteLine("Would you like to search another category? yes/no");

    string choice2 = Console.ReadLine();
    choice2 = choice2.ToLower().Trim();
    if (choice2.Contains("y"))
    {
        Console.WriteLine();
        reloadMovies = true;
    }
    else reloadMovies = false;
}


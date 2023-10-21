namespace ConsoleApp1;

public static class RandomGenerator
{
    static Random random = new Random();
    
    public static List<Employee> GenerateEmployees(int count)
    {
        var list = new List<Employee>();

        for (int i = 0; i < count; i++)
        {
            var name = GetRandomName();
        
            var rnd = random.Next(0, 3);

            var genres = Enum.GetValues<Genre>();
            var rndGenres = genres.OrderBy(x => random.Next(0, 9999)).Take(random.Next(1, genres.Length)).ToArray();

            IRoles role = rnd switch
            {
                1 => new Cashier(),
                2 => new Sales(),
                _ => new InventoryManager(rndGenres),
            };

            Employee employee = new Employee(role, name);
            list.Add(employee);
        }

        return list;
    }

    public static List<Book> GenerateBooks(int count, int minPrice, int maxPrice)
    {
        var list = new List<Book>();

        for (int i = 0; i < count; i++)
        {
            var name = GetRandomName();
            var title = GetRandomTitle();
            var genre = Enum.GetValues<Genre>().MinBy(x => random.Next(0, 9999));
            var book = new Book(title, name, genre, random.Next(minPrice, maxPrice));
            
            list.Add(book);
        }

        return list;
    }

    private static string GetRandomName()
    {
        var name = names[random.Next(0, names.Length)];
        var surname = surnames[random.Next(0, surnames.Length)];
        return name + " " + surname;
    }

    private static string GetRandomTitle()
    {
        var first = firstWords[random.Next(0, firstWords.Length)];
        var second = secondWords[random.Next(0, secondWords.Length)];
        var third = thirdWords[random.Next(0, thirdWords.Length)];

        return $"{first} {second} {third}";
    }

    private static string[] names =
    {
        "Alice", "Bob", "Charlie", "Diana", "Eve", "Frank", "Grace", "Harry", "Ivy", "Jack"
    };
    
    private static string[] surnames =
    {
        "Smith", "Kim", "Garcia", "Patel", "Brown", "Schmidt", "Nguyen", "Silva", "Martinez", "Khan",
        "Wang", "Rodriguez", "Jones", "Singh", "Lee", "Perez", "Sanchez", "Johnson", "Murphy", "Novak"
    };

    private static string[] firstWords =
    {
        "My", "The", "A", "One", "That", "His", "Her", "An", "This", "Some"
    };

    private static string[] secondWords =
    {
        "Big", "Small", "Tall", "Fast", "Red", "Silent", "Rusty", "Bright", "Dark", "Mighty"
    };

    private static string[] thirdWords =
    {
        "Ball", "Rocket", "Car", "Tree", "Bike", "Shoe", "Book", "Guitar", "Hat", "Kite"
    };
}
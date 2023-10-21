namespace ConsoleApp1;

public class BookStore
{
    private List<Book> books = new List<Book>();
    private List<Employee> employees = new List<Employee>();

    public void PrintEmployeesNameAndGenre()
    {
        Console.WriteLine();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    public void GetBookCountForEachGenre()
    {
        Dictionary<Genre, int> counters = new();
        
        for (int i = 0; i < books.Count; i++)
        {
            Book book = books[i];
            Genre bookGenre = book.GetGenre();

            if (!counters.ContainsKey(bookGenre)) counters.Add(bookGenre, 1);
            else counters[bookGenre] = counters[bookGenre] + 1;
        }

        foreach (var counterPair in counters)
        {
            int counter = counterPair.Value;
            Genre genre = counterPair.Key;
            Console.WriteLine(counter + ", " + genre);
        }
        
    }

    public void GetInventoryManageValue()
    {
        foreach (var employee in employees)
        {
            IRoles role = employee.role;
            if (role is InventoryManager im)
            {
                
            }
        }
    }
}
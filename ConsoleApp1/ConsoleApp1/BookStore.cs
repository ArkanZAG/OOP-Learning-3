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
            float totalBookPrice = 0;

            if (role is InventoryManager inventoryManager)
            {
                Genre[] genres = inventoryManager.genres;

                foreach (var genre in genres)
                {
                    foreach (var book in books)
                    {
                        if (genre == book.GetGenre())
                        {
                            float bookPrice = book.GetPrice();
                            totalBookPrice = totalBookPrice + bookPrice;
                        }
                    }
                }
                Console.WriteLine("Nama Employee : " + employee.employeesName + " " + "Total Book Price : " + totalBookPrice);
            }
        }
    }
    
    
    // Goal : mencari nilai total harga dr genre yang di tangguhkan kepada masing-masing inventorymanager
    // mencari tahu genre apa saja yang di tangguhkan kepada masing-masing inventorymanager
    // - cari employee dengan role inventorymanager dengan foreach
    // - buat int TotalBookPrice
    // - ambil genre dari inventorymanager 
    
    // mencari tahu total harga buku di genre yang di tangguhkan kepada masing-masing inventorymanager
    // - access list<books> dengan foreach untuk mengecheck genre buku teresebut sama dengan genre yang di tangguhkan kepada inventorymanager
    // - kalau benar, harga buku tersebut akan di simpan dan di tambahkan ke TotalBookPrice.
}
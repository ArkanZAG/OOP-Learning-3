using ConsoleApp1;

BookStore bookStore = new BookStore();
List<Book> newBooks = RandomGenerator.GenerateBooks(50, 100, 1000);
List<Employee> newEmployee = RandomGenerator.GenerateEmployees(5);
foreach (var book in newBooks)
{
    bookStore.AddBook(book);
    Console.WriteLine(book.Describe());
}
foreach (var employee in newEmployee)
{
    bookStore.AddEmployee(employee);
}

bookStore.GetBookCountForEachGenre();
bookStore.GetInventoryManageValue();
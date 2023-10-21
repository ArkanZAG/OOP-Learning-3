using ConsoleApp1;

BookStore bookStore = new BookStore();
List<Book> newBooks = RandomGenerator.GenerateBooks(50, 100, 1000);
foreach (var book in newBooks)
{
    bookStore.AddBook(book);
    Console.WriteLine(book.Describe());
}

bookStore.GetBookCountForEachGenre();
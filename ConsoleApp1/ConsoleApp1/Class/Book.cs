namespace ConsoleApp1;

public class Book
{
    private string title;
    private string author;
    private Genre genre;
    private float price;


    public Book(string title, string author, Genre genre, float price)
    {
        this.title = title;
        this.author = author;
        this.genre = genre;
        this.price = price;
    }

    public string Describe()
    {
        return "Tittle : " + title + " " +"Author : "+ author+" "+"Genre : "+ genre.ToString() +" "+"Price : " + price.ToString();
    }

    public Genre GetGenre()
    {
        return genre;
    }

    public float GetPrice()
    {
        return price;
    }
}
namespace ConsoleApp1;

public class InventoryManager : IRoles
{
    public Genre []genres;

    public InventoryManager(Genre[] genres)
    {
        this.genres = genres;
    }

    public void DoJob()
    {
        for (int i = 0; i < genres.Length; i++)
        {
            Console.WriteLine(genres[i]);
        }
    }
}
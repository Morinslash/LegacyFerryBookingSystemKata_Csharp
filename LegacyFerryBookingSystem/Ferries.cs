using System.Text.Json;
using System.Text.Json.Serialization;

public class Ferries
{
    private readonly List<Ferry> _ferries = new List<Ferry>();

    public Ferries()
    {
        var file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "ferries.txt");
        var reader = new StreamReader(file).ReadToEnd();
        _ferries= JsonSerializer.Deserialize<List<Ferry>>(reader);
    }

    public List<Ferry> All()
    {
        return _ferries;
    }
}
using System.Text.Json;

public class Ports
{
    private readonly List<Port> _ports = new List<Port>();

    public Ports()
    {
        var reader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "ports.txt"));
        _ports= JsonSerializer.Deserialize<List<Port>>(reader.ReadToEnd());
    }

    public List<Port> All()
    {
        return _ports;
    }
}
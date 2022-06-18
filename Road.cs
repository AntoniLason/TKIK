namespace TKIK;

public class Road
{
    private string id;
    private string type;
    private string from;
    private string to;
    
    public Road(string id, string type, string from, string to)
    {
        this.id = id;
        this.type = type;
        this.from = from;
        this.to = to;
    }
    public string getId()
    {
        return id;
    }
    public string getType()
    {
        return type;
    }
    public string getFrom()
    {
        return from;
    }
    public string getTo()
    {
        return to;
    }
}
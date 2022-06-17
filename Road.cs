namespace TKIK;

public class Road
{
    public string id;
    public string type;
    public string from;
    public string to;
    
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
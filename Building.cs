namespace TKIK;

public class Building
{
    private string id;
    private string type;

    private List<string> nodes = new List<string>();
    
    public Building(string id, string type)
    {
        this.id = id;
        this.type = type;
    }
    public Building(string id, string type, List<string> nodes)
    {
        this.id = id;
        this.type = type;
        this.nodes = nodes;
    }
    
    public void setNodes(List<string> nodes)
    {
        this.nodes = nodes;
    }
    
    public void AddNode(string node)
    {
        nodes.Add(node);
    }
    
    public string getId()
    {
        return id;
    }
    
    public string getType()
    {
        return type;
    }
    
    public List<string> getNodes()
    {
        return nodes;
    }
}
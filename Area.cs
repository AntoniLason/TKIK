namespace TKIK;

public class Area
{
    public string id;
    public string type;
    
    public List<string> nodes = new List<string>();
    
    public Area(string id, string type)
    {
        this.id = id;
        this.type = type;
    }
    
    public Area(string id, string type, List<string> nodes)
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
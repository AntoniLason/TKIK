using TKIK.Language;

namespace TKIK;

public class MapVisitor : mapBaseVisitor<object?>
{
    private Dictionary<string, object?> Variables { get; } = new ();
    
    public override object? VisitPoint(mapParser.PointContext context)
    {
        var name = "point";
        var lat = Visit(context.lat());
        var longi = Visit(context.longi());
        var coorditnation = new Coordinate(lat, longi);
        
        Variables.Add(name, coorditnation);
        return null;
    }
}
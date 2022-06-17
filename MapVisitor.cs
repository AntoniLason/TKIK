using TKIK.Language;

namespace TKIK;

public class MapVisitor : mapBaseVisitor<object?>
{
    private Dictionary<string, object?> Variables { get; } = new ();
    
    public override object? VisitPoint(mapParser.PointContext context)
    {
        var name =context.IDENTIFIER().GetText();
        var lat = Visit(context.latitude());
        var longi = Visit(context.longitude());
        var coorditnation = new Coordinate(lat, longi);
        
        Variables.Add(name, coorditnation);
        return null;
    }
}
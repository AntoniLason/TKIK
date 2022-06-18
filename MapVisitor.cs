using Antlr4.Runtime.Tree;
using TKIK.Language;

namespace TKIK;

public class MapVisitor : mapBaseVisitor<object?>
{
    private Dictionary<string, Coordinate> Points { get; } = new (); // dictionary of points
    
    public override object? VisitPoint(mapParser.PointContext context)
    {
        var name =context.IDENTIFIER().GetText();
        var lat = VisitLatitude(context.latitude());
        var longi = VisitLongitude(context.longitude());
        var coorditnation = new Coordinate(lat, longi);
        
        Points.Add(name, coorditnation);
        return null;
    }

    public int VisitLatitude(mapParser.LatitudeContext context)
    {
        if (context.INTEGER() is {} i)
            return int.Parse(i.GetText());
        
        throw new InvalidDataException();
    }
    
    public int VisitLongitude(mapParser.LongitudeContext context)
    {
        if (context.INTEGER() is {} i)
            return int.Parse(i.GetText());

        throw new InvalidDataException();
    }

    private Dictionary<string, Road> Roads { get; } = new ();    //dictionary of roads and their properties
    public override object? VisitRoad(mapParser.RoadContext context)
    {
        var type = context.ROADTYPE().GetText();
        var name = context.IDENTIFIER(0).GetText();
        var start = context.IDENTIFIER(1).GetText();
        var end = context.IDENTIFIER(2).GetText();
        
        var road = new Road( name, type,start, end);
        
        Roads.Add(name, road);
        
        return null;

    }
    
    private Dictionary<string, Building> Buildings { get; } = new ();

    public override object? VisitBuilding(mapParser.BuildingContext context)
    {
        var type = context.BUILDINGTYPE().GetText();
        var name = context.IDENTIFIER(0).GetText();
        
        var building = new Building(name, type);
        
        List<string> points = context.IDENTIFIER().ToList().Select(x => x.GetText()).ToList();
        points.RemoveAt(0);
        building.setNodes(points);
        
        Buildings.Add(name, building);
        return null;
    }
    
    private Dictionary<string, Area> Areas { get; } = new ();

    public override object? VisitArea(mapParser.AreaContext context)
    {
        var type = context.AREATYPE().GetText();
        var name = context.IDENTIFIER(0).GetText();
        
        var points = context.IDENTIFIER().ToList().Select(x => x.GetText()).ToList();
        
        points.RemoveAt(0);
        var area = new Area(name, type, points);
        
        Areas.Add(name, area);
        return null;
    }

    public Dictionary<string, Coordinate> getPoints()
    {
        return Points;
    }
    
    public Dictionary<string, Road> getRoads()
    {
        return Roads;
    }
    
    public Dictionary<string, Building> getBuildings()
    {
        return Buildings;
    }
    
    public Dictionary<string, Area> getAreas()
    {
        return Areas;
    }

}
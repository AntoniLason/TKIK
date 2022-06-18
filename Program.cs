using Antlr4.Runtime;
using TKIK;
using TKIK.Language;

var fileName = "Language\\test1.map";

var fileContent = File.ReadAllText(fileName);

var inputStream = new AntlrInputStream(fileContent);

var mapLexer = new mapLexer(inputStream);
var commonTokenStream = new CommonTokenStream(mapLexer);
var mapParser = new mapParser(commonTokenStream);

var mapContext = mapParser.program();
var visitor = new MapVisitor();
visitor.Visit(mapContext);

// Check if visitor worked
var a = visitor.getPoints();
foreach(KeyValuePair<string, Coordinate> pair in a)
{
    Console.WriteLine(pair.Key + " " + pair.Value.getx() + " " + pair.Value.gety());
}

var b = visitor.getRoads();
foreach(KeyValuePair<string, Road> pair in b)
{
    Console.WriteLine(pair.Key + " " + pair.Value.getId() + " " + pair.Value.getType() + " " + pair.Value.getFrom() + " " + pair.Value.getTo());
}

var x = visitor.getBuildings();
foreach(KeyValuePair<string, Building> pair in x)
{
    Console.Write(pair.Key + " " + pair.Value.getId() + " " + pair.Value.getType() + " " );
    foreach (string node in pair.Value.getNodes())
    {
        Console.Write(node + " ");
    }
    Console.WriteLine();
}

var y = visitor.getAreas();
foreach(KeyValuePair<string, Area> pait in y)
{
    Console.Write(pait.Key + " " + pait.Value.getId() + " " + pait.Value.getType() + " " );
    foreach(string node in pait.Value.getNodes())
    {
        Console.Write(node + " ");
    }
    Console.WriteLine();
}
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
    Console.WriteLine(pair.Key + " " + pair.Value.getId() + " " + pair.Value.getType() + " " + pair.Value.getNodes());
}
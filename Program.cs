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
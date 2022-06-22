using Antlr4.Runtime;
using TKIK;
using TKIK.Language;

Console.WriteLine(" select file or type \"console\" for console imput in case of error program upload test1.map ");
string? control = Console.ReadLine();

string fileContent;

if (control != null && control.Equals("test1"))
{
    var fileName = "Language\\test1.map";
    fileContent = File.ReadAllText(fileName);
}
else if (control != null && control.Equals("test2"))
{
    var fileName = "Language\\test2.map";
    fileContent = File.ReadAllText(fileName);
}
else if (control != null && control.Equals("test3"))
{
    var fileName = "Language\\test3.map";
    fileContent = File.ReadAllText(fileName);
}
else if (control != null && control.Equals("console"))
{
    Console.WriteLine(" Type EOF and press Enter to end");
    string? buffer = "";
    string? buffer2;
    while (true)
    {
        buffer2 = Console.ReadLine();
        if (buffer2 != null && !buffer2.Equals("EOF"))
        {
            buffer += buffer2;
            buffer += "\n";
        }
        else
        {
            fileContent = buffer;
            break;
        }
    }
        
}
else
{
    var fileName = "Language\\test1.map";
    fileContent = File.ReadAllText(fileName);
}



var inputStream = new AntlrInputStream(fileContent);

var mapLexer = new mapLexer(inputStream);
var commonTokenStream = new CommonTokenStream(mapLexer);
var mapParser = new mapParser(commonTokenStream);

var mapContext = mapParser.program();
var visitor = new MapVisitor();
visitor.Visit(mapContext);

// Check if visitor worked
Console.WriteLine("debug message");
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

//Render od Kamili
Renderer renderer = new Renderer();
renderer.Run(visitor, 900, 900, true);

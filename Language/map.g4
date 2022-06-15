grammar map;

//parser
program: line+ EOF;

line: 
road
|point
|area
|building
;

usuwaniePrzypisaniaPunktu
:
DISCONNECT ID 
| DISCONNECT lat longi  
| DISCONNECT listofpoints 
;

area:
AREATYPE listofpoints
;

building:
BUILDINGTYPE listofpoints
;

listofpoints:
ID
|
lat longi
|
point
|
listofpoints COMA ID
|
listofpoints COMA lat longi
| 
listofpoints COMA point
|
listofpoints EOL ID
|
listofpoints EOL lat longi
| 
listofpoints EOL point
;

road:
ROADTYPE point point
|
ROADTYPE lat longi lat longi
|
ROADTYPE listofpoints
;

point:
POINT ID lat longi 
;

lat: 
NORTH INTIGER
|
SOUTH INTIGER
;

longi:  
EAST INTIGER
|
WEST INTIGER
;
//lekser

// podstawowe
EOL:  '\r'? '\n' | '\r';

WHITESPACE : ' ' -> skip ;

NEWLINE : ('\r'? '\n' | '\r')+ ;

fragment DIGIT : [0-9] ;

fragment CHAR: [a-zA-Z];

FLOAT: DIGIT+ ([.,] DIGIT+)? ;

INTIGER: [0-9]+ ;

OPENCURLYBRACKET:'{';
CLOSECURLYBRACKER:'}';
COMA: ',';


//point id
ID: CHAR+DIGIT*;

POINT: 'POINT' | 'point';

//kierunki
NORTH:'N' | 'n';
EAST :'E' | 'e';
WEST: 'w' | 'W';
SOUTH: 'S' | 's' ;

//Typy dróg
fragment HIGHWAY:'HIGHWAY';
fragment EXPRESSWAY:'EXPRESSWAY';
fragment TRUNKROAD:'TRUNKROAD';
fragment REGIONALROAD:'REGIONALROAD';
fragment COUNTRYROAD:'COUNTRYROAD';
ROADTYPE: HIGHWAY | EXPRESSWAY | TRUNKROAD | REGIONALROAD | COUNTRYROAD ;

//Duże obiekty
fragment BUILDING:'BUILDING';
fragment BRIDGE:'BRIDGE';
fragment TUNNEL:'TUNNEL';
BUILDINGTYPE: BUILDING | BRIDGE | TUNNEL;

//Obszary
fragment GREANAREA:'GREANAREA';
fragment INDUSTRIALAREA:'INDUSTRIALAREA';
fragment BUILDINGONAREA:'BUILDINGONAREA';
fragment WATER:'WATER';
AREATYPE : GREANAREA | INDUSTRIALAREA | BUILDINGONAREA | WATER ;

//przypisanie, usunięcie
DISCONNECT: 'DISCONNECT';
CONNECT: 'CONNECT' ;

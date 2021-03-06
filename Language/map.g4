grammar map;

program: line* EOF;

line:
point 
|road 
|building
|area
|coment
;

coment: '//' CHAR* '//';

building:
BUILDINGTYPE IDENTIFIER '(' IDENTIFIER* ')'
;

area:
AREATYPE IDENTIFIER '(' IDENTIFIER* ')'
;

point: 
POINT IDENTIFIER latitude longitude;

latitude:
INTEGER;

longitude:
INTEGER;

road:
ROADTYPE IDENTIFIER latitude longitude latitude longitude
|ROADTYPE IDENTIFIER IDENTIFIER IDENTIFIER
;
//

fragment HIGHWAY:'HIGHWAY' | 'highway';
fragment EXPRESSWAY:'EXPRESSWAY' | 'expressway';
fragment TRUNKROAD:'TRUNKROAD' | 'trunkroad';
fragment REGIONALROAD:'REGIONALROAD' | 'regionalroad';
fragment COUNTRYROAD:'COUNTRYROAD' | 'countryroad';
ROADTYPE: HIGHWAY | EXPRESSWAY | TRUNKROAD | REGIONALROAD | COUNTRYROAD ;


fragment BUILDING:'BUILDING' | 'building';
fragment BRIDGE:'BRIDGE' | 'bridge';
fragment TUNNEL:'TUNNEL'| 'tunnel';
BUILDINGTYPE: BUILDING | BRIDGE | TUNNEL;


fragment GREANAREA:'GREANAREA' | 'grenarea';
fragment INDUSTRIALAREA:'INDUSTRIALAREA' | 'industrialarea';
fragment BUILDINGONAREA:'BUILDINGONAREA' | 'buildingonarea';
fragment WATER:'WATER'| 'water';
AREATYPE : GREANAREA | INDUSTRIALAREA | BUILDINGONAREA | WATER ;

POINT:
'POINT' | 'point';

INTEGER:
'-'? DIGIT+;

DIGIT:
[0-9];

IDENTIFIER:
[a-zA-Z_][a-zA-Z0-9_]*;

CHAR:
[a-zA-Z0-9_];


//białe znaki
//EOL:  '\r'? '\n' | '\r' ;

WHITESPACE : ' ' -> skip ;

NEWLINE : ('\r'? '\n' | '\r')+ -> skip;
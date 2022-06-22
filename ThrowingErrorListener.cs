using System.Diagnostics.SymbolStore;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;

namespace TKIK;

//chyba nie działa
public class ThrowingErrorListener : BaseErrorListener
{
    public static ThrowingErrorListener INSTANCE = new ThrowingErrorListener();

    public override void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine,
        string msg, RecognitionException e)
    {
        throw new ParseCanceledException("line: " + line + " char: " + charPositionInLine + " " + offendingSymbol);
    }
}
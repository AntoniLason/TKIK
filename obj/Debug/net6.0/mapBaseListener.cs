//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from F:\Programowanie\PlayingWithANTLR\TKIK\TKIK\Language\map.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace TKIK.Language {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ImapListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class mapBaseListener : ImapListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="mapParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgram([NotNull] mapParser.ProgramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="mapParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgram([NotNull] mapParser.ProgramContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="mapParser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLine([NotNull] mapParser.LineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="mapParser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLine([NotNull] mapParser.LineContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="mapParser.coment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComent([NotNull] mapParser.ComentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="mapParser.coment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComent([NotNull] mapParser.ComentContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="mapParser.building"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBuilding([NotNull] mapParser.BuildingContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="mapParser.building"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBuilding([NotNull] mapParser.BuildingContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="mapParser.area"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArea([NotNull] mapParser.AreaContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="mapParser.area"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArea([NotNull] mapParser.AreaContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="mapParser.point"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPoint([NotNull] mapParser.PointContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="mapParser.point"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPoint([NotNull] mapParser.PointContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="mapParser.latitude"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLatitude([NotNull] mapParser.LatitudeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="mapParser.latitude"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLatitude([NotNull] mapParser.LatitudeContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="mapParser.longitude"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLongitude([NotNull] mapParser.LongitudeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="mapParser.longitude"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLongitude([NotNull] mapParser.LongitudeContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="mapParser.road"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRoad([NotNull] mapParser.RoadContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="mapParser.road"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRoad([NotNull] mapParser.RoadContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace TKIK.Language

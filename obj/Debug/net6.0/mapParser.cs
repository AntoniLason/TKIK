﻿//------------------------------------------------------------------------------
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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class mapParser : Parser {
	public const int
		EOL=1, WHITESPACE=2, NEWLINE=3, FLOAT=4, INTIGER=5, OPENCURLYBRACKET=6, 
		CLOSECURLYBRACKER=7, COMA=8, ID=9, POINT=10, NORTH=11, EAST=12, WEST=13, 
		SOUTH=14, ROADTYPE=15, BUILDINGTYPE=16, AREATYPE=17, DISCONNECT=18, CONNECT=19;
	public const int
		RULE_program = 0, RULE_line = 1, RULE_usuwaniePrzypisaniaPunktu = 2, RULE_area = 3, 
		RULE_building = 4, RULE_listofpoints = 5, RULE_road = 6, RULE_point = 7, 
		RULE_lat = 8, RULE_longi = 9;
	public static readonly string[] ruleNames = {
		"program", "line", "usuwaniePrzypisaniaPunktu", "area", "building", "listofpoints", 
		"road", "point", "lat", "longi"
	};

	private static readonly string[] _LiteralNames = {
		null, null, "' '", null, null, null, "'{'", "'}'", "','", null, null, 
		null, null, null, null, null, null, null, "'DISCONNECT'", "'CONNECT'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "EOL", "WHITESPACE", "NEWLINE", "FLOAT", "INTIGER", "OPENCURLYBRACKET", 
		"CLOSECURLYBRACKER", "COMA", "ID", "POINT", "NORTH", "EAST", "WEST", "SOUTH", 
		"ROADTYPE", "BUILDINGTYPE", "AREATYPE", "DISCONNECT", "CONNECT"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "map.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public mapParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class ProgramContext : ParserRuleContext {
		public ITerminalNode Eof() { return GetToken(mapParser.Eof, 0); }
		public LineContext[] line() {
			return GetRuleContexts<LineContext>();
		}
		public LineContext line(int i) {
			return GetRuleContext<LineContext>(i);
		}
		public ProgramContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_program; } }
		public override void EnterRule(IParseTreeListener listener) {
			ImapListener typedListener = listener as ImapListener;
			if (typedListener != null) typedListener.EnterProgram(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImapListener typedListener = listener as ImapListener;
			if (typedListener != null) typedListener.ExitProgram(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImapVisitor<TResult> typedVisitor = visitor as ImapVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProgram(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgramContext program() {
		ProgramContext _localctx = new ProgramContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_program);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 21;
			_errHandler.Sync(this);
			_la = _input.La(1);
			do {
				{
				{
				State = 20; line();
				}
				}
				State = 23;
				_errHandler.Sync(this);
				_la = _input.La(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << POINT) | (1L << ROADTYPE) | (1L << BUILDINGTYPE) | (1L << AREATYPE))) != 0) );
			State = 25; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LineContext : ParserRuleContext {
		public RoadContext road() {
			return GetRuleContext<RoadContext>(0);
		}
		public PointContext point() {
			return GetRuleContext<PointContext>(0);
		}
		public AreaContext area() {
			return GetRuleContext<AreaContext>(0);
		}
		public BuildingContext building() {
			return GetRuleContext<BuildingContext>(0);
		}
		public LineContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_line; } }
		public override void EnterRule(IParseTreeListener listener) {
			ImapListener typedListener = listener as ImapListener;
			if (typedListener != null) typedListener.EnterLine(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImapListener typedListener = listener as ImapListener;
			if (typedListener != null) typedListener.ExitLine(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImapVisitor<TResult> typedVisitor = visitor as ImapVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLine(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LineContext line() {
		LineContext _localctx = new LineContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_line);
		try {
			State = 31;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case ROADTYPE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 27; road();
				}
				break;
			case POINT:
				EnterOuterAlt(_localctx, 2);
				{
				State = 28; point();
				}
				break;
			case AREATYPE:
				EnterOuterAlt(_localctx, 3);
				{
				State = 29; area();
				}
				break;
			case BUILDINGTYPE:
				EnterOuterAlt(_localctx, 4);
				{
				State = 30; building();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class UsuwaniePrzypisaniaPunktuContext : ParserRuleContext {
		public ITerminalNode DISCONNECT() { return GetToken(mapParser.DISCONNECT, 0); }
		public ITerminalNode ID() { return GetToken(mapParser.ID, 0); }
		public LatContext lat() {
			return GetRuleContext<LatContext>(0);
		}
		public LongiContext longi() {
			return GetRuleContext<LongiContext>(0);
		}
		public ListofpointsContext listofpoints() {
			return GetRuleContext<ListofpointsContext>(0);
		}
		public UsuwaniePrzypisaniaPunktuContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_usuwaniePrzypisaniaPunktu; } }
		public override void EnterRule(IParseTreeListener listener) {
			ImapListener typedListener = listener as ImapListener;
			if (typedListener != null) typedListener.EnterUsuwaniePrzypisaniaPunktu(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImapListener typedListener = listener as ImapListener;
			if (typedListener != null) typedListener.ExitUsuwaniePrzypisaniaPunktu(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImapVisitor<TResult> typedVisitor = visitor as ImapVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitUsuwaniePrzypisaniaPunktu(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public UsuwaniePrzypisaniaPunktuContext usuwaniePrzypisaniaPunktu() {
		UsuwaniePrzypisaniaPunktuContext _localctx = new UsuwaniePrzypisaniaPunktuContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_usuwaniePrzypisaniaPunktu);
		try {
			State = 41;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,2,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 33; Match(DISCONNECT);
				State = 34; Match(ID);
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 35; Match(DISCONNECT);
				State = 36; lat();
				State = 37; longi();
				}
				break;

			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 39; Match(DISCONNECT);
				State = 40; listofpoints(0);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AreaContext : ParserRuleContext {
		public ITerminalNode AREATYPE() { return GetToken(mapParser.AREATYPE, 0); }
		public ListofpointsContext listofpoints() {
			return GetRuleContext<ListofpointsContext>(0);
		}
		public AreaContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_area; } }
		public override void EnterRule(IParseTreeListener listener) {
			ImapListener typedListener = listener as ImapListener;
			if (typedListener != null) typedListener.EnterArea(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImapListener typedListener = listener as ImapListener;
			if (typedListener != null) typedListener.ExitArea(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImapVisitor<TResult> typedVisitor = visitor as ImapVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitArea(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AreaContext area() {
		AreaContext _localctx = new AreaContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_area);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 43; Match(AREATYPE);
			State = 44; listofpoints(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BuildingContext : ParserRuleContext {
		public ITerminalNode BUILDINGTYPE() { return GetToken(mapParser.BUILDINGTYPE, 0); }
		public ListofpointsContext listofpoints() {
			return GetRuleContext<ListofpointsContext>(0);
		}
		public BuildingContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_building; } }
		public override void EnterRule(IParseTreeListener listener) {
			ImapListener typedListener = listener as ImapListener;
			if (typedListener != null) typedListener.EnterBuilding(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImapListener typedListener = listener as ImapListener;
			if (typedListener != null) typedListener.ExitBuilding(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImapVisitor<TResult> typedVisitor = visitor as ImapVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBuilding(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public BuildingContext building() {
		BuildingContext _localctx = new BuildingContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_building);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 46; Match(BUILDINGTYPE);
			State = 47; listofpoints(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ListofpointsContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(mapParser.ID, 0); }
		public LatContext lat() {
			return GetRuleContext<LatContext>(0);
		}
		public LongiContext longi() {
			return GetRuleContext<LongiContext>(0);
		}
		public PointContext point() {
			return GetRuleContext<PointContext>(0);
		}
		public ListofpointsContext listofpoints() {
			return GetRuleContext<ListofpointsContext>(0);
		}
		public ITerminalNode COMA() { return GetToken(mapParser.COMA, 0); }
		public ITerminalNode EOL() { return GetToken(mapParser.EOL, 0); }
		public ListofpointsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_listofpoints; } }
		public override void EnterRule(IParseTreeListener listener) {
			ImapListener typedListener = listener as ImapListener;
			if (typedListener != null) typedListener.EnterListofpoints(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImapListener typedListener = listener as ImapListener;
			if (typedListener != null) typedListener.ExitListofpoints(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImapVisitor<TResult> typedVisitor = visitor as ImapVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitListofpoints(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ListofpointsContext listofpoints() {
		return listofpoints(0);
	}

	private ListofpointsContext listofpoints(int _p) {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = State;
		ListofpointsContext _localctx = new ListofpointsContext(_ctx, _parentState);
		ListofpointsContext _prevctx = _localctx;
		int _startState = 10;
		EnterRecursionRule(_localctx, 10, RULE_listofpoints, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 55;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case ID:
				{
				State = 50; Match(ID);
				}
				break;
			case NORTH:
			case SOUTH:
				{
				State = 51; lat();
				State = 52; longi();
				}
				break;
			case POINT:
				{
				State = 54; point();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			_ctx.stop = _input.Lt(-1);
			State = 81;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,5,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 79;
					_errHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(_input,4,_ctx) ) {
					case 1:
						{
						_localctx = new ListofpointsContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_listofpoints);
						State = 57;
						if (!(Precpred(_ctx, 6))) throw new FailedPredicateException(this, "Precpred(_ctx, 6)");
						State = 58; Match(COMA);
						State = 59; Match(ID);
						}
						break;

					case 2:
						{
						_localctx = new ListofpointsContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_listofpoints);
						State = 60;
						if (!(Precpred(_ctx, 5))) throw new FailedPredicateException(this, "Precpred(_ctx, 5)");
						State = 61; Match(COMA);
						State = 62; lat();
						State = 63; longi();
						}
						break;

					case 3:
						{
						_localctx = new ListofpointsContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_listofpoints);
						State = 65;
						if (!(Precpred(_ctx, 4))) throw new FailedPredicateException(this, "Precpred(_ctx, 4)");
						State = 66; Match(COMA);
						State = 67; point();
						}
						break;

					case 4:
						{
						_localctx = new ListofpointsContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_listofpoints);
						State = 68;
						if (!(Precpred(_ctx, 3))) throw new FailedPredicateException(this, "Precpred(_ctx, 3)");
						State = 69; Match(EOL);
						State = 70; Match(ID);
						}
						break;

					case 5:
						{
						_localctx = new ListofpointsContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_listofpoints);
						State = 71;
						if (!(Precpred(_ctx, 2))) throw new FailedPredicateException(this, "Precpred(_ctx, 2)");
						State = 72; Match(EOL);
						State = 73; lat();
						State = 74; longi();
						}
						break;

					case 6:
						{
						_localctx = new ListofpointsContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_listofpoints);
						State = 76;
						if (!(Precpred(_ctx, 1))) throw new FailedPredicateException(this, "Precpred(_ctx, 1)");
						State = 77; Match(EOL);
						State = 78; point();
						}
						break;
					}
					} 
				}
				State = 83;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,5,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class RoadContext : ParserRuleContext {
		public ITerminalNode ROADTYPE() { return GetToken(mapParser.ROADTYPE, 0); }
		public PointContext[] point() {
			return GetRuleContexts<PointContext>();
		}
		public PointContext point(int i) {
			return GetRuleContext<PointContext>(i);
		}
		public LatContext[] lat() {
			return GetRuleContexts<LatContext>();
		}
		public LatContext lat(int i) {
			return GetRuleContext<LatContext>(i);
		}
		public LongiContext[] longi() {
			return GetRuleContexts<LongiContext>();
		}
		public LongiContext longi(int i) {
			return GetRuleContext<LongiContext>(i);
		}
		public ListofpointsContext listofpoints() {
			return GetRuleContext<ListofpointsContext>(0);
		}
		public RoadContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_road; } }
		public override void EnterRule(IParseTreeListener listener) {
			ImapListener typedListener = listener as ImapListener;
			if (typedListener != null) typedListener.EnterRoad(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImapListener typedListener = listener as ImapListener;
			if (typedListener != null) typedListener.ExitRoad(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImapVisitor<TResult> typedVisitor = visitor as ImapVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRoad(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public RoadContext road() {
		RoadContext _localctx = new RoadContext(_ctx, State);
		EnterRule(_localctx, 12, RULE_road);
		try {
			State = 96;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,6,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 84; Match(ROADTYPE);
				State = 85; point();
				State = 86; point();
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 88; Match(ROADTYPE);
				State = 89; lat();
				State = 90; longi();
				State = 91; lat();
				State = 92; longi();
				}
				break;

			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 94; Match(ROADTYPE);
				State = 95; listofpoints(0);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PointContext : ParserRuleContext {
		public ITerminalNode POINT() { return GetToken(mapParser.POINT, 0); }
		public ITerminalNode ID() { return GetToken(mapParser.ID, 0); }
		public LatContext lat() {
			return GetRuleContext<LatContext>(0);
		}
		public LongiContext longi() {
			return GetRuleContext<LongiContext>(0);
		}
		public PointContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_point; } }
		public override void EnterRule(IParseTreeListener listener) {
			ImapListener typedListener = listener as ImapListener;
			if (typedListener != null) typedListener.EnterPoint(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImapListener typedListener = listener as ImapListener;
			if (typedListener != null) typedListener.ExitPoint(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImapVisitor<TResult> typedVisitor = visitor as ImapVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPoint(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PointContext point() {
		PointContext _localctx = new PointContext(_ctx, State);
		EnterRule(_localctx, 14, RULE_point);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 98; Match(POINT);
			State = 99; Match(ID);
			State = 100; lat();
			State = 101; longi();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LatContext : ParserRuleContext {
		public ITerminalNode NORTH() { return GetToken(mapParser.NORTH, 0); }
		public ITerminalNode INTIGER() { return GetToken(mapParser.INTIGER, 0); }
		public ITerminalNode SOUTH() { return GetToken(mapParser.SOUTH, 0); }
		public LatContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_lat; } }
		public override void EnterRule(IParseTreeListener listener) {
			ImapListener typedListener = listener as ImapListener;
			if (typedListener != null) typedListener.EnterLat(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImapListener typedListener = listener as ImapListener;
			if (typedListener != null) typedListener.ExitLat(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImapVisitor<TResult> typedVisitor = visitor as ImapVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLat(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LatContext lat() {
		LatContext _localctx = new LatContext(_ctx, State);
		EnterRule(_localctx, 16, RULE_lat);
		try {
			State = 107;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case NORTH:
				EnterOuterAlt(_localctx, 1);
				{
				State = 103; Match(NORTH);
				State = 104; Match(INTIGER);
				}
				break;
			case SOUTH:
				EnterOuterAlt(_localctx, 2);
				{
				State = 105; Match(SOUTH);
				State = 106; Match(INTIGER);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LongiContext : ParserRuleContext {
		public ITerminalNode EAST() { return GetToken(mapParser.EAST, 0); }
		public ITerminalNode INTIGER() { return GetToken(mapParser.INTIGER, 0); }
		public ITerminalNode WEST() { return GetToken(mapParser.WEST, 0); }
		public LongiContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_longi; } }
		public override void EnterRule(IParseTreeListener listener) {
			ImapListener typedListener = listener as ImapListener;
			if (typedListener != null) typedListener.EnterLongi(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImapListener typedListener = listener as ImapListener;
			if (typedListener != null) typedListener.ExitLongi(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImapVisitor<TResult> typedVisitor = visitor as ImapVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLongi(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LongiContext longi() {
		LongiContext _localctx = new LongiContext(_ctx, State);
		EnterRule(_localctx, 18, RULE_longi);
		try {
			State = 113;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case EAST:
				EnterOuterAlt(_localctx, 1);
				{
				State = 109; Match(EAST);
				State = 110; Match(INTIGER);
				}
				break;
			case WEST:
				EnterOuterAlt(_localctx, 2);
				{
				State = 111; Match(WEST);
				State = 112; Match(INTIGER);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 5: return listofpoints_sempred((ListofpointsContext)_localctx, predIndex);
		}
		return true;
	}
	private bool listofpoints_sempred(ListofpointsContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(_ctx, 6);

		case 1: return Precpred(_ctx, 5);

		case 2: return Precpred(_ctx, 4);

		case 3: return Precpred(_ctx, 3);

		case 4: return Precpred(_ctx, 2);

		case 5: return Precpred(_ctx, 1);
		}
		return true;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\x15v\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t\t"+
		"\t\x4\n\t\n\x4\v\t\v\x3\x2\x6\x2\x18\n\x2\r\x2\xE\x2\x19\x3\x2\x3\x2\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x5\x3\"\n\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4"+
		"\x3\x4\x3\x4\x5\x4,\n\x4\x3\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\a\x3\a"+
		"\x3\a\x3\a\x3\a\x3\a\x5\a:\n\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a"+
		"\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a"+
		"\a\aR\n\a\f\a\xE\aU\v\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3"+
		"\b\x3\b\x3\b\x5\b\x63\n\b\x3\t\x3\t\x3\t\x3\t\x3\t\x3\n\x3\n\x3\n\x3\n"+
		"\x5\nn\n\n\x3\v\x3\v\x3\v\x3\v\x5\vt\n\v\x3\v\x2\x2\x3\f\f\x2\x2\x4\x2"+
		"\x6\x2\b\x2\n\x2\f\x2\xE\x2\x10\x2\x12\x2\x14\x2\x2\x2}\x2\x17\x3\x2\x2"+
		"\x2\x4!\x3\x2\x2\x2\x6+\x3\x2\x2\x2\b-\x3\x2\x2\x2\n\x30\x3\x2\x2\x2\f"+
		"\x39\x3\x2\x2\x2\xE\x62\x3\x2\x2\x2\x10\x64\x3\x2\x2\x2\x12m\x3\x2\x2"+
		"\x2\x14s\x3\x2\x2\x2\x16\x18\x5\x4\x3\x2\x17\x16\x3\x2\x2\x2\x18\x19\x3"+
		"\x2\x2\x2\x19\x17\x3\x2\x2\x2\x19\x1A\x3\x2\x2\x2\x1A\x1B\x3\x2\x2\x2"+
		"\x1B\x1C\a\x2\x2\x3\x1C\x3\x3\x2\x2\x2\x1D\"\x5\xE\b\x2\x1E\"\x5\x10\t"+
		"\x2\x1F\"\x5\b\x5\x2 \"\x5\n\x6\x2!\x1D\x3\x2\x2\x2!\x1E\x3\x2\x2\x2!"+
		"\x1F\x3\x2\x2\x2! \x3\x2\x2\x2\"\x5\x3\x2\x2\x2#$\a\x14\x2\x2$,\a\v\x2"+
		"\x2%&\a\x14\x2\x2&\'\x5\x12\n\x2\'(\x5\x14\v\x2(,\x3\x2\x2\x2)*\a\x14"+
		"\x2\x2*,\x5\f\a\x2+#\x3\x2\x2\x2+%\x3\x2\x2\x2+)\x3\x2\x2\x2,\a\x3\x2"+
		"\x2\x2-.\a\x13\x2\x2./\x5\f\a\x2/\t\x3\x2\x2\x2\x30\x31\a\x12\x2\x2\x31"+
		"\x32\x5\f\a\x2\x32\v\x3\x2\x2\x2\x33\x34\b\a\x1\x2\x34:\a\v\x2\x2\x35"+
		"\x36\x5\x12\n\x2\x36\x37\x5\x14\v\x2\x37:\x3\x2\x2\x2\x38:\x5\x10\t\x2"+
		"\x39\x33\x3\x2\x2\x2\x39\x35\x3\x2\x2\x2\x39\x38\x3\x2\x2\x2:S\x3\x2\x2"+
		"\x2;<\f\b\x2\x2<=\a\n\x2\x2=R\a\v\x2\x2>?\f\a\x2\x2?@\a\n\x2\x2@\x41\x5"+
		"\x12\n\x2\x41\x42\x5\x14\v\x2\x42R\x3\x2\x2\x2\x43\x44\f\x6\x2\x2\x44"+
		"\x45\a\n\x2\x2\x45R\x5\x10\t\x2\x46G\f\x5\x2\x2GH\a\x3\x2\x2HR\a\v\x2"+
		"\x2IJ\f\x4\x2\x2JK\a\x3\x2\x2KL\x5\x12\n\x2LM\x5\x14\v\x2MR\x3\x2\x2\x2"+
		"NO\f\x3\x2\x2OP\a\x3\x2\x2PR\x5\x10\t\x2Q;\x3\x2\x2\x2Q>\x3\x2\x2\x2Q"+
		"\x43\x3\x2\x2\x2Q\x46\x3\x2\x2\x2QI\x3\x2\x2\x2QN\x3\x2\x2\x2RU\x3\x2"+
		"\x2\x2SQ\x3\x2\x2\x2ST\x3\x2\x2\x2T\r\x3\x2\x2\x2US\x3\x2\x2\x2VW\a\x11"+
		"\x2\x2WX\x5\x10\t\x2XY\x5\x10\t\x2Y\x63\x3\x2\x2\x2Z[\a\x11\x2\x2[\\\x5"+
		"\x12\n\x2\\]\x5\x14\v\x2]^\x5\x12\n\x2^_\x5\x14\v\x2_\x63\x3\x2\x2\x2"+
		"`\x61\a\x11\x2\x2\x61\x63\x5\f\a\x2\x62V\x3\x2\x2\x2\x62Z\x3\x2\x2\x2"+
		"\x62`\x3\x2\x2\x2\x63\xF\x3\x2\x2\x2\x64\x65\a\f\x2\x2\x65\x66\a\v\x2"+
		"\x2\x66g\x5\x12\n\x2gh\x5\x14\v\x2h\x11\x3\x2\x2\x2ij\a\r\x2\x2jn\a\a"+
		"\x2\x2kl\a\x10\x2\x2ln\a\a\x2\x2mi\x3\x2\x2\x2mk\x3\x2\x2\x2n\x13\x3\x2"+
		"\x2\x2op\a\xE\x2\x2pt\a\a\x2\x2qr\a\xF\x2\x2rt\a\a\x2\x2so\x3\x2\x2\x2"+
		"sq\x3\x2\x2\x2t\x15\x3\x2\x2\x2\v\x19!+\x39QS\x62ms";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace TKIK.Language
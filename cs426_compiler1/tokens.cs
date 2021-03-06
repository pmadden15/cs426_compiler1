/* This file was generated by SableCC (http://www.sablecc.org/). */

using System;
using System.Collections;
using System.Text;

using  comp5210.analysis;

namespace comp5210.node {


public sealed class TShout : Token
{
    public TShout(string text)
    {
        Text = text;
    }

    public TShout(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TShout(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTShout(this);
    }
}

public sealed class TWhitespace : Token
{
    public TWhitespace(string text)
    {
        Text = text;
    }

    public TWhitespace(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TWhitespace(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTWhitespace(this);
    }
}

public sealed class TComment : Token
{
    public TComment(string text)
    {
        Text = text;
    }

    public TComment(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TComment(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTComment(this);
    }
}

public sealed class TClass : Token
{
    public TClass(string text)
    {
        Text = text;
    }

    public TClass(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TClass(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTClass(this);
    }
}

public sealed class TPublic : Token
{
    public TPublic(string text)
    {
        Text = text;
    }

    public TPublic(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TPublic(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTPublic(this);
    }
}

public sealed class TPrivate : Token
{
    public TPrivate(string text)
    {
        Text = text;
    }

    public TPrivate(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TPrivate(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTPrivate(this);
    }
}

public sealed class TReturn : Token
{
    public TReturn(string text)
    {
        Text = text;
    }

    public TReturn(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TReturn(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTReturn(this);
    }
}

public sealed class TMainProgram : Token
{
    public TMainProgram(string text)
    {
        Text = text;
    }

    public TMainProgram(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TMainProgram(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTMainProgram(this);
    }
}

public sealed class TLParenthesis : Token
{
    public TLParenthesis(string text)
    {
        Text = text;
    }

    public TLParenthesis(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TLParenthesis(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTLParenthesis(this);
    }
}

public sealed class TRParenthesis : Token
{
    public TRParenthesis(string text)
    {
        Text = text;
    }

    public TRParenthesis(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TRParenthesis(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTRParenthesis(this);
    }
}

public sealed class TLSqBracket : Token
{
    public TLSqBracket(string text)
    {
        Text = text;
    }

    public TLSqBracket(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TLSqBracket(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTLSqBracket(this);
    }
}

public sealed class TRSqBracket : Token
{
    public TRSqBracket(string text)
    {
        Text = text;
    }

    public TRSqBracket(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TRSqBracket(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTRSqBracket(this);
    }
}

public sealed class TLCuBracket : Token
{
    public TLCuBracket(string text)
    {
        Text = text;
    }

    public TLCuBracket(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TLCuBracket(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTLCuBracket(this);
    }
}

public sealed class TRCuBracket : Token
{
    public TRCuBracket(string text)
    {
        Text = text;
    }

    public TRCuBracket(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TRCuBracket(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTRCuBracket(this);
    }
}

public sealed class TExponent : Token
{
    public TExponent(string text)
    {
        Text = text;
    }

    public TExponent(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TExponent(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTExponent(this);
    }
}

public sealed class TSeperator : Token
{
    public TSeperator(string text)
    {
        Text = text;
    }

    public TSeperator(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TSeperator(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTSeperator(this);
    }
}

public sealed class TAddition : Token
{
    public TAddition(string text)
    {
        Text = text;
    }

    public TAddition(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TAddition(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTAddition(this);
    }
}

public sealed class TSubtraction : Token
{
    public TSubtraction(string text)
    {
        Text = text;
    }

    public TSubtraction(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TSubtraction(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTSubtraction(this);
    }
}

public sealed class TMultiplication : Token
{
    public TMultiplication(string text)
    {
        Text = text;
    }

    public TMultiplication(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TMultiplication(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTMultiplication(this);
    }
}

public sealed class TDivision : Token
{
    public TDivision(string text)
    {
        Text = text;
    }

    public TDivision(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TDivision(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTDivision(this);
    }
}

public sealed class TAndSign : Token
{
    public TAndSign(string text)
    {
        Text = text;
    }

    public TAndSign(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TAndSign(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTAndSign(this);
    }
}

public sealed class TOrSign : Token
{
    public TOrSign(string text)
    {
        Text = text;
    }

    public TOrSign(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TOrSign(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTOrSign(this);
    }
}

public sealed class TNotSign : Token
{
    public TNotSign(string text)
    {
        Text = text;
    }

    public TNotSign(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TNotSign(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTNotSign(this);
    }
}

public sealed class TEquivalent : Token
{
    public TEquivalent(string text)
    {
        Text = text;
    }

    public TEquivalent(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TEquivalent(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTEquivalent(this);
    }
}

public sealed class TGreaterOrEqual : Token
{
    public TGreaterOrEqual(string text)
    {
        Text = text;
    }

    public TGreaterOrEqual(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TGreaterOrEqual(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTGreaterOrEqual(this);
    }
}

public sealed class TLesserOrEqual : Token
{
    public TLesserOrEqual(string text)
    {
        Text = text;
    }

    public TLesserOrEqual(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TLesserOrEqual(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTLesserOrEqual(this);
    }
}

public sealed class TGreater : Token
{
    public TGreater(string text)
    {
        Text = text;
    }

    public TGreater(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TGreater(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTGreater(this);
    }
}

public sealed class TLess : Token
{
    public TLess(string text)
    {
        Text = text;
    }

    public TLess(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TLess(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTLess(this);
    }
}

public sealed class TEqual : Token
{
    public TEqual(string text)
    {
        Text = text;
    }

    public TEqual(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TEqual(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTEqual(this);
    }
}

public sealed class TSemicolon : Token
{
    public TSemicolon(string text)
    {
        Text = text;
    }

    public TSemicolon(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TSemicolon(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTSemicolon(this);
    }
}

public sealed class TConstToken : Token
{
    public TConstToken(string text)
    {
        Text = text;
    }

    public TConstToken(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TConstToken(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTConstToken(this);
    }
}

public sealed class TFloat : Token
{
    public TFloat(string text)
    {
        Text = text;
    }

    public TFloat(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TFloat(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTFloat(this);
    }
}

public sealed class TInteger : Token
{
    public TInteger(string text)
    {
        Text = text;
    }

    public TInteger(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TInteger(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTInteger(this);
    }
}

public sealed class TString : Token
{
    public TString(string text)
    {
        Text = text;
    }

    public TString(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TString(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTString(this);
    }
}

public sealed class TIf : Token
{
    public TIf(string text)
    {
        Text = text;
    }

    public TIf(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TIf(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTIf(this);
    }
}

public sealed class TElse : Token
{
    public TElse(string text)
    {
        Text = text;
    }

    public TElse(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TElse(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTElse(this);
    }
}

public sealed class TWhile : Token
{
    public TWhile(string text)
    {
        Text = text;
    }

    public TWhile(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TWhile(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTWhile(this);
    }
}

public sealed class TId : Token
{
    public TId(string text)
    {
        Text = text;
    }

    public TId(string text, int line, int pos)
    {
        Text = text;
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
      return new TId(Text, Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseTId(this);
    }
}


public abstract class Token : Node
{
    private string text;
    private int line;
    private int pos;

    public virtual string Text
    {
      get { return text; }
      set { text = value; }
    }

    public int Line
    {
      get { return line; }
      set { line = value; }
    }

    public int Pos
    {
      get { return pos; }
      set { pos = value; }
    }

    public override string ToString()
    {
        return text + " ";
    }

    internal override void RemoveChild(Node child)
    {
    }

    internal override void ReplaceChild(Node oldChild, Node newChild)
    {
    }
}

public sealed class EOF : Token
{
    public EOF()
    {
        Text = "";
    }

    public EOF(int line, int pos)
    {
        Text = "";
        Line = line;
        Pos = pos;
    }

    public override Object Clone()
    {
        return new EOF(Line, Pos);
    }

    public override void Apply(Switch sw)
    {
        ((Analysis) sw).CaseEOF(this);
    }
}
}

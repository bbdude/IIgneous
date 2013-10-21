
/* <stmt> := var <ident> = <expr>
	| <ident> = <expr>
	| for <ident> = <expr> to <expr> do <stmt> end
	| read_int <ident>
	| print <expr>
	| <stmt> ; <stmt>
  */
public abstract class Stmt
{
}

// var <ident> = <expr>
public class DeclareVar : Stmt
{
    public string Ident;
    public Expr Expr;
}

// print <expr>
public class Print : Stmt
{
    public Expr Expr;
}

// <ident> = <expr>
public class Assign : Stmt
{
    public string Ident;
    public Expr Expr;
}

// for <ident> = <expr> to <expr> do <stmt> end
public class ForLoop : Stmt
{
    public string Ident;
    public Expr From;
    public Expr To;
    public Stmt Body;
}
// for <ident> = <expr> to <expr> do <stmt> end
public class Check : Stmt
{
    public Expr Expr;
    public Stmt Body;
}
public class PadLeft : Stmt
{
    public Expr Expr;
    public Expr Padding;
}
//pause <ident> = ( <expr> )
public class Pause : Stmt
{
    public string Ident;
    public Expr Expr;
}
public class Clear : Stmt
{
    public Expr Expr;
}

public class Pause : Stmt
{
    public string Ident;
    public int time;
    public Expr From;
    public Expr To;
    public Stmt Body;
}

public class Pause : Stmt
{
    public string Ident;
    public int time;
    public Expr From;
    public Expr To;
    public Stmt Body;
}

public class Pause : Stmt
{
    public string Ident;
    public int time;
    public Expr From;
    public Expr To;
    public Stmt Body;
}

// read_int <ident>
public class ReadInt : Stmt
{
    public string Ident;
}
public class ReadString : Stmt
{
    public string Ident;
}

// <stmt> ; <stmt>
public class Sequence : Stmt
{
    public Stmt First;
    public Stmt Second;
}

/* <expr> := <string>
 *  | <int>
 *  | <arith_expr>
 *  | <ident>
 */
public abstract class Expr
{
}

// <string> := " <string_elem>* "
public class StringLiteral : Expr
{
    public string Value;
}

// <string> := " <string_elem>* "
public class FloatLiteral : Expr
{
    public float Value;
}

// <int> := <digit>+
public class IntLiteral : Expr
{
    public int Value;
}
// <int> := <digit>+
public class BoolLiteral : Expr
{
    public bool Value;
}

// <ident> := <char> <ident_rest>*
// <ident_rest> := <char> | <digit>
public class Variable : Expr
{
    public string Ident;
}

// <bin_expr> := <expr> <bin_op> <expr>
public class BinExpr : Expr
{
    public Expr Left;
    public Expr Right;
    public BinOp Op;
}

// <bin_op> := + | - | * | /
public enum BinOp
{
    Add,
    Sub,
    Mul,
    Div
}
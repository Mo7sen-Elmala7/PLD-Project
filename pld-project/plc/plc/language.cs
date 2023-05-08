using com.calitha.commons;
using System.Runtime.Serialization;

namespace com.calitha.goldparser
{

    [Serializable()]
    public class SymbolException : System.Exception
    {
        public SymbolException(string message) : base(message)
        {
        }

        public SymbolException(string message,
            Exception inner) : base(message, inner)
        {
        }

        protected SymbolException(SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }

    }

    [Serializable()]
    public class RuleException : System.Exception
    {

        public RuleException(string message) : base(message)
        {
        }

        public RuleException(string message,
                             Exception inner) : base(message, inner)
        {
        }

        protected RuleException(SerializationInfo info,
                                StreamingContext context) : base(info, context)
        {
        }

    }

    enum SymbolConstants : int
    {
        SYMBOL_EOF = 0, // (EOF)
        SYMBOL_ERROR = 1, // (Error)
        SYMBOL_WHITESPACE = 2, // Whitespace
        SYMBOL_MINUS = 3, // '-'
        SYMBOL_MINUSMINUS = 4, // '--'
        SYMBOL_EXCLAMEQ = 5, // '!='
        SYMBOL_PERCENT = 6, // '%'
        SYMBOL_LPAREN = 7, // '('
        SYMBOL_RPAREN = 8, // ')'
        SYMBOL_TIMES = 9, // '*'
        SYMBOL_TIMESTIMES = 10, // '**'
        SYMBOL_DIV = 11, // '/'
        SYMBOL_COLON = 12, // ':'
        SYMBOL_SEMI = 13, // ';'
        SYMBOL_LBRACE = 14, // '{'
        SYMBOL_RBRACE = 15, // '}'
        SYMBOL_PLUS = 16, // '+'
        SYMBOL_PLUSPLUS = 17, // '++'
        SYMBOL_LT = 18, // '<'
        SYMBOL_EQ = 19, // '='
        SYMBOL_EQEQ = 20, // '=='
        SYMBOL_GT = 21, // '>'
        SYMBOL_BREAK = 22, // break
        SYMBOL_CASE = 23, // case
        SYMBOL_CHAR = 24, // char
        SYMBOL_DEFAULT = 25, // default
        SYMBOL_DIGIT = 26, // Digit
        SYMBOL_DOUBLE = 27, // double
        SYMBOL_ELSE = 28, // else
        SYMBOL_FLOAT = 29, // float
        SYMBOL_FOR = 30, // for
        SYMBOL_ID = 31, // Id
        SYMBOL_IF = 32, // if
        SYMBOL_INT = 33, // int
        SYMBOL_STRING = 34, // string
        SYMBOL_SWITCH = 35, // switch
        SYMBOL_ASSIGN = 36, // <assign>
        SYMBOL_BODY = 37, // <body>
        SYMBOL_BREAK_STMT = 38, // <break_stmt>
        SYMBOL_CASE_ITEM = 39, // <case_item>
        SYMBOL_CASE_LIST = 40, // <case_list>
        SYMBOL_CONCEPT = 41, // <concept>
        SYMBOL_COND = 42, // <cond>
        SYMBOL_DATA = 43, // <data>
        SYMBOL_DIGIT2 = 44, // <digit>
        SYMBOL_EXP = 45, // <exp>
        SYMBOL_EXPR = 46, // <expr>
        SYMBOL_FACTOR = 47, // <factor>
        SYMBOL_FOR_STMT = 48, // <for_stmt>
        SYMBOL_ID2 = 49, // <id>
        SYMBOL_IF_STMT = 50, // <if_stmt>
        SYMBOL_OP = 51, // <op>
        SYMBOL_PROGRAM = 52, // <program>
        SYMBOL_STEP = 53, // <step>
        SYMBOL_SWITCH_STMT = 54, // <switch_stmt>
        SYMBOL_TERM = 55  // <term>
    };

    enum RuleConstants : int
    {
        RULE_PROGRAM_LBRACE_RBRACE = 0, // <program> ::= '{' <body> '}'
        RULE_BODY = 1, // <body> ::= <concept>
        RULE_BODY2 = 2, // <body> ::= <concept> <body>
        RULE_CONCEPT = 3, // <concept> ::= <assign>
        RULE_CONCEPT2 = 4, // <concept> ::= <if_stmt>
        RULE_CONCEPT3 = 5, // <concept> ::= <for_stmt>
        RULE_ASSIGN_EQ_SEMI = 6, // <assign> ::= <id> '=' <expr> ';'
        RULE_ID_ID = 7, // <id> ::= Id
        RULE_EXPR_PLUS = 8, // <expr> ::= <expr> '+' <term>
        RULE_EXPR_MINUS = 9, // <expr> ::= <expr> '-' <term>
        RULE_EXPR = 10, // <expr> ::= <term>
        RULE_TERM_TIMES = 11, // <term> ::= <term> '*' <factor>
        RULE_TERM_DIV = 12, // <term> ::= <term> '/' <factor>
        RULE_TERM_PERCENT = 13, // <term> ::= <term> '%' <factor>
        RULE_TERM = 14, // <term> ::= <factor>
        RULE_FACTOR_TIMESTIMES = 15, // <factor> ::= <factor> '**' <exp>
        RULE_FACTOR = 16, // <factor> ::= <exp>
        RULE_DIGIT_DIGIT = 17, // <digit> ::= Digit
        RULE_EXP_LPAREN_RPAREN = 18, // <exp> ::= '(' <expr> ')'
        RULE_EXP = 19, // <exp> ::= <id>
        RULE_EXP2 = 20, // <exp> ::= <digit>
        RULE_IF_STMT_IF_LPAREN_RPAREN_LBRACE_RBRACE = 21, // <if_stmt> ::= if '(' <cond> ')' '{' <body> '}'
        RULE_IF_STMT_IF_LPAREN_RPAREN_LBRACE_RBRACE_ELSE_LBRACE_RBRACE = 22, // <if_stmt> ::= if '(' <cond> ')' '{' <body> '}' else '{' <body> '}'
        RULE_COND = 23, // <cond> ::= <expr> <op> <expr>
        RULE_OP_LT = 24, // <op> ::= '<'
        RULE_OP_GT = 25, // <op> ::= '>'
        RULE_OP_EQEQ = 26, // <op> ::= '=='
        RULE_OP_EXCLAMEQ = 27, // <op> ::= '!='
        RULE_FOR_STMT_FOR_LPAREN_SEMI_SEMI_RPAREN_LBRACE_RBRACE = 28, // <for_stmt> ::= for '(' <data> <assign> ';' <cond> ';' <step> ')' '{' <body> '}'
        RULE_DATA_INT = 29, // <data> ::= int
        RULE_DATA_FLOAT = 30, // <data> ::= float
        RULE_DATA_DOUBLE = 31, // <data> ::= double
        RULE_DATA_STRING = 32, // <data> ::= string
        RULE_DATA_CHAR = 33, // <data> ::= char
        RULE_STEP_PLUSPLUS = 34, // <step> ::= <id> '++'
        RULE_STEP_MINUSMINUS = 35, // <step> ::= <id> '--'
        RULE_STEP_MINUSMINUS2 = 36, // <step> ::= '--' <id>
        RULE_STEP_PLUSPLUS2 = 37, // <step> ::= '++' <id>
        RULE_STEP = 38, // <step> ::= <assign>
        RULE_SWITCH_STMT_SWITCH_LPAREN_RPAREN_LBRACE_RBRACE = 39, // <switch_stmt> ::= switch '(' <expr> ')' '{' <case_list> '}'
        RULE_CASE_LIST = 40, // <case_list> ::= <case_item>
        RULE_CASE_LIST2 = 41, // <case_list> ::= <case_item> <case_list>
        RULE_CASE_ITEM_CASE_COLON = 42, // <case_item> ::= case <expr> ':' <body> <break_stmt>
        RULE_CASE_ITEM_DEFAULT_COLON = 43, // <case_item> ::= default ':' <body>
        RULE_BREAK_STMT_BREAK_SEMI = 44  // <break_stmt> ::= break ';'
    };

    public class MyParser
    {
        private LALRParser parser;

        ListBox lst;

        public MyParser(string filename, ListBox lst)
        {
            FileStream stream = new FileStream(filename,
                                               FileMode.Open,
                                               FileAccess.Read,
                                               FileShare.Read);
            this.lst = lst;
            Init(stream);
            stream.Close();
        }

        public MyParser(string baseName, string resourceName)
        {
            byte[] buffer = ResourceUtil.GetByteArrayResource(
                System.Reflection.Assembly.GetExecutingAssembly(),
                baseName,
                resourceName);
            MemoryStream stream = new MemoryStream(buffer);
            Init(stream);
            stream.Close();
        }

        public MyParser(Stream stream)
        {
            Init(stream);
        }

        private void Init(Stream stream)
        {
            CGTReader reader = new CGTReader(stream);
            parser = reader.CreateNewParser();
            parser.TrimReductions = false;
            parser.StoreTokens = LALRParser.StoreTokensMode.NoUserObject;

            parser.OnTokenError += new LALRParser.TokenErrorHandler(TokenErrorEvent);
            parser.OnParseError += new LALRParser.ParseErrorHandler(ParseErrorEvent);
        }

        public void Parse(string source)
        {
            NonterminalToken token = parser.Parse(source);
            if (token != null)
            {
                Object obj = CreateObject(token);
                //todo: Use your object any way you like
            }
        }

        private Object CreateObject(Token token)
        {
            if (token is TerminalToken)
                return CreateObjectFromTerminal((TerminalToken)token);
            else
                return CreateObjectFromNonterminal((NonterminalToken)token);
        }

        private Object CreateObjectFromTerminal(TerminalToken token)
        {
            switch (token.Symbol.Id)
            {
                case (int)SymbolConstants.SYMBOL_EOF:
                    //(EOF)
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_ERROR:
                    //(Error)
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_WHITESPACE:
                    //Whitespace
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_MINUS:
                    //'-'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_MINUSMINUS:
                    //'--'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_EXCLAMEQ:
                    //'!='
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_PERCENT:
                    //'%'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_LPAREN:
                    //'('
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_RPAREN:
                    //')'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_TIMES:
                    //'*'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_TIMESTIMES:
                    //'**'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_DIV:
                    //'/'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_COLON:
                    //':'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_SEMI:
                    //';'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_LBRACE:
                    //'{'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_RBRACE:
                    //'}'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_PLUS:
                    //'+'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_PLUSPLUS:
                    //'++'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_LT:
                    //'<'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_EQ:
                    //'='
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_EQEQ:
                    //'=='
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_GT:
                    //'>'
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_BREAK:
                    //break
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_CASE:
                    //case
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_CHAR:
                    //char
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_DEFAULT:
                    //default
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_DIGIT:
                    //Digit
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_DOUBLE:
                    //double
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_ELSE:
                    //else
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_FLOAT:
                    //float
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_FOR:
                    //for
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_ID:
                    //Id
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_IF:
                    //if
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_INT:
                    //int
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_STRING:
                    //string
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_SWITCH:
                    //switch
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_ASSIGN:
                    //<assign>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_BODY:
                    //<body>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_BREAK_STMT:
                    //<break_stmt>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_CASE_ITEM:
                    //<case_item>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_CASE_LIST:
                    //<case_list>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_CONCEPT:
                    //<concept>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_COND:
                    //<cond>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_DATA:
                    //<data>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_DIGIT2:
                    //<digit>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_EXP:
                    //<exp>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_EXPR:
                    //<expr>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_FACTOR:
                    //<factor>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_FOR_STMT:
                    //<for_stmt>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_ID2:
                    //<id>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_IF_STMT:
                    //<if_stmt>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_OP:
                    //<op>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_PROGRAM:
                    //<program>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_STEP:
                    //<step>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_SWITCH_STMT:
                    //<switch_stmt>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

                case (int)SymbolConstants.SYMBOL_TERM:
                    //<term>
                    //todo: Create a new object that corresponds to the symbol
                    return null;

            }
            throw new SymbolException("Unknown symbol");
        }

        public Object CreateObjectFromNonterminal(NonterminalToken token)
        {
            switch (token.Rule.Id)
            {
                case (int)RuleConstants.RULE_PROGRAM_LBRACE_RBRACE:
                    //<program> ::= '{' <body> '}'
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_BODY:
                    //<body> ::= <concept>
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_BODY2:
                    //<body> ::= <concept> <body>
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_CONCEPT:
                    //<concept> ::= <assign>
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_CONCEPT2:
                    //<concept> ::= <if_stmt>
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_CONCEPT3:
                    //<concept> ::= <for_stmt>
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_ASSIGN_EQ_SEMI:
                    //<assign> ::= <id> '=' <expr> ';'
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_ID_ID:
                    //<id> ::= Id
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_EXPR_PLUS:
                    //<expr> ::= <expr> '+' <term>
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_EXPR_MINUS:
                    //<expr> ::= <expr> '-' <term>
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_EXPR:
                    //<expr> ::= <term>
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_TERM_TIMES:
                    //<term> ::= <term> '*' <factor>
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_TERM_DIV:
                    //<term> ::= <term> '/' <factor>
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_TERM_PERCENT:
                    //<term> ::= <term> '%' <factor>
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_TERM:
                    //<term> ::= <factor>
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_FACTOR_TIMESTIMES:
                    //<factor> ::= <factor> '**' <exp>
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_FACTOR:
                    //<factor> ::= <exp>
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_DIGIT_DIGIT:
                    //<digit> ::= Digit
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_EXP_LPAREN_RPAREN:
                    //<exp> ::= '(' <expr> ')'
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_EXP:
                    //<exp> ::= <id>
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_EXP2:
                    //<exp> ::= <digit>
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_IF_STMT_IF_LPAREN_RPAREN_LBRACE_RBRACE:
                    //<if_stmt> ::= if '(' <cond> ')' '{' <body> '}'
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_IF_STMT_IF_LPAREN_RPAREN_LBRACE_RBRACE_ELSE_LBRACE_RBRACE:
                    //<if_stmt> ::= if '(' <cond> ')' '{' <body> '}' else '{' <body> '}'
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_COND:
                    //<cond> ::= <expr> <op> <expr>
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_OP_LT:
                    //<op> ::= '<'
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_OP_GT:
                    //<op> ::= '>'
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_OP_EQEQ:
                    //<op> ::= '=='
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_OP_EXCLAMEQ:
                    //<op> ::= '!='
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_FOR_STMT_FOR_LPAREN_SEMI_SEMI_RPAREN_LBRACE_RBRACE:
                    //<for_stmt> ::= for '(' <data> <assign> ';' <cond> ';' <step> ')' '{' <body> '}'
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_DATA_INT:
                    //<data> ::= int
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_DATA_FLOAT:
                    //<data> ::= float
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_DATA_DOUBLE:
                    //<data> ::= double
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_DATA_STRING:
                    //<data> ::= string
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_DATA_CHAR:
                    //<data> ::= char
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_STEP_PLUSPLUS:
                    //<step> ::= <id> '++'
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_STEP_MINUSMINUS:
                    //<step> ::= <id> '--'
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_STEP_MINUSMINUS2:
                    //<step> ::= '--' <id>
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_STEP_PLUSPLUS2:
                    //<step> ::= '++' <id>
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_STEP:
                    //<step> ::= <assign>
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_SWITCH_STMT_SWITCH_LPAREN_RPAREN_LBRACE_RBRACE:
                    //<switch_stmt> ::= switch '(' <expr> ')' '{' <case_list> '}'
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_CASE_LIST:
                    //<case_list> ::= <case_item>
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_CASE_LIST2:
                    //<case_list> ::= <case_item> <case_list>
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_CASE_ITEM_CASE_COLON:
                    //<case_item> ::= case <expr> ':' <body> <break_stmt>
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_CASE_ITEM_DEFAULT_COLON:
                    //<case_item> ::= default ':' <body>
                    //todo: Create a new object using the stored tokens.
                    return null;

                case (int)RuleConstants.RULE_BREAK_STMT_BREAK_SEMI:
                    //<break_stmt> ::= break ';'
                    //todo: Create a new object using the stored tokens.
                    return null;

            }
            throw new RuleException("Unknown rule");
        }

        private void TokenErrorEvent(LALRParser parser, TokenErrorEventArgs args)
        {
            string message = "Token error with input: '" + args.Token.ToString() + "'";
            //todo: Report message to UI?
        }

        private void ParseErrorEvent(LALRParser parser, ParseErrorEventArgs args)
        {
            string message = "Parse error caused by token: '" + args.UnexpectedToken.ToString() + " in line: " + args.UnexpectedToken.Location.LineNr;
            lst.Items.Add(message);
            string message2 = "Expected Token: " + args.ExpectedTokens.ToString();
            lst.Items.Add(message2);
            //todo: Report message to UI?
        }

    }
}

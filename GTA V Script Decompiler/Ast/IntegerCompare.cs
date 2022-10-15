﻿namespace Decompiler.Ast
{
    internal abstract class IntegerCompare : AstToken
    {
        readonly AstToken Lhs;
        readonly AstToken Rhs;

        protected IntegerCompare(Function func, AstToken rhs, AstToken lhs) : base(func)
        {
            Lhs = lhs;
            Rhs = rhs;
            Lhs.HintType(ref Rhs.GetTypeContainer());
        }

        protected abstract string Operator { get; }

        public override ref TypeContainer GetTypeContainer()
        {
            return ref Types.BOOL.GetContainer();
        }

        public override string ToString()
        {
            return $"{Lhs} {Operator} {Rhs}";
        }
    }

    internal class IntegerEq : IntegerCompare
    {
        public IntegerEq(Function func, AstToken rhs, AstToken lhs) : base(func, rhs, lhs)
        {
        }

        protected override string Operator => "==";
    }

    internal class IntegerNe : IntegerCompare
    {
        public IntegerNe(Function func, AstToken rhs, AstToken lhs) : base(func, rhs, lhs)
        {
        }

        protected override string Operator => "!=";
    }

    internal class IntegerLt : IntegerCompare
    {
        public IntegerLt(Function func, AstToken rhs, AstToken lhs) : base(func, rhs, lhs)
        {
        }

        protected override string Operator => "<";
    }

    internal class IntegerLe : IntegerCompare
    {
        public IntegerLe(Function func, AstToken rhs, AstToken lhs) : base(func, rhs, lhs)
        {
        }

        protected override string Operator => "<=";
    }

    internal class IntegerGt : IntegerCompare
    {
        public IntegerGt(Function func, AstToken rhs, AstToken lhs) : base(func, rhs, lhs)
        {
        }

        protected override string Operator => ">";
    }

    internal class IntegerGe : IntegerCompare
    {
        public IntegerGe(Function func, AstToken rhs, AstToken lhs) : base(func, rhs, lhs)
        {
        }

        protected override string Operator => ">=";
    }
}

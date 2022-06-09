using System;

using R5T.F0000;
using R5T.F0003;


namespace R5T.F0006
{
    public static class Instances
    {
        public static IStringOperator StringOperator { get; } = F0000.StringOperator.Instance;
        public static ISyntaxNodeOperator SyntaxNodeOperator { get; } = F0003.SyntaxNodeOperator.Instance;
    }
}

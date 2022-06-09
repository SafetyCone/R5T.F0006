using System;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.Magyar.Extensions;

using R5T.T0132;


namespace R5T.F0006
{
    [FunctionalityMarker]
    public partial interface ISyntaxParser : IFunctionalityMarker,
        F0005.ISyntaxParser
    {
        /// <summary>
        /// Method establishing a framework for parsing text to syntax nodes.
        /// </summary>
        public TNode Parse<TNode>(
            Func<string> source,
            Func<string, string> preParse,
            Func<string, TNode> parse,
            Func<TNode, TNode> postParse)
            where TNode : SyntaxNode
        {
            var text = source();

            var preParseText = preParse(text);

            var node = parse(preParseText);

            var output = postParse(node);
            return output;
        }

        public TNode Parse<TNode>(
            string text,
            Func<string, string> preParse,
            Func<string, TNode> parse,
            Func<TNode, TNode> postParse)
            where TNode : SyntaxNode
        {
            var preParseText = preParse(text);

            var node = parse(preParseText);

            var output = postParse(node);
            return output;
        }

        public TNode Parse<TNode>(
            string text,
            Func<string, TNode> parse)
            where TNode : SyntaxNode
        {
            var output = this.Parse(
                text,
                Instances.StringOperator.Trim,
                parse,
                Instances.SyntaxNodeOperator.MoveDescendantTrailingTriviaToLeadingTrivia);

            return output;
        }

        public new ClassDeclarationSyntax ParseClass(
            string text)
        {
            var output = this.Parse(
                text,
                this.As<F0005.ISyntaxParser>().ParseClass);

            return output;
        }
    }
}

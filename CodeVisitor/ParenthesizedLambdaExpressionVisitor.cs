using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;

namespace CodeVisitor
    {
        class ParenthesizedLambdaExpressionVisitor : CSharpSyntaxRewriter
        {
            public ParenthesizedLambdaExpressionVisitor()
            {
                Classes = new List<ParenthesizedLambdaExpressionSyntax>();
            }

            public List<ParenthesizedLambdaExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax node)
            {
                node = (ParenthesizedLambdaExpressionSyntax)base.VisitParenthesizedLambdaExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
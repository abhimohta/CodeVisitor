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
        class SimpleLambdaExpressionVisitor : CSharpSyntaxRewriter
        {
            public SimpleLambdaExpressionVisitor()
            {
                Classes = new List<SimpleLambdaExpressionSyntax>();
            }

            public List<SimpleLambdaExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax node)
            {
                node = (SimpleLambdaExpressionSyntax)base.VisitSimpleLambdaExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
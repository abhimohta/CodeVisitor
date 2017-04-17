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
        class LiteralExpressionVisitor : CSharpSyntaxRewriter
        {
            public LiteralExpressionVisitor()
            {
                Classes = new List<LiteralExpressionSyntax>();
            }

            public List<LiteralExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitLiteralExpression(LiteralExpressionSyntax node)
            {
                node = (LiteralExpressionSyntax)base.VisitLiteralExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
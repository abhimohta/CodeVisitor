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
        class ParenthesizedExpressionVisitor : CSharpSyntaxRewriter
        {
            public ParenthesizedExpressionVisitor()
            {
                Classes = new List<ParenthesizedExpressionSyntax>();
            }

            public List<ParenthesizedExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitParenthesizedExpression(ParenthesizedExpressionSyntax node)
            {
                node = (ParenthesizedExpressionSyntax)base.VisitParenthesizedExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
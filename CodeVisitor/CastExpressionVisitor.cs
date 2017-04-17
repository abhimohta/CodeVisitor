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
        class CastExpressionVisitor : CSharpSyntaxRewriter
        {
            public CastExpressionVisitor()
            {
                Classes = new List<CastExpressionSyntax>();
            }

            public List<CastExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitCastExpression(CastExpressionSyntax node)
            {
                node = (CastExpressionSyntax)base.VisitCastExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
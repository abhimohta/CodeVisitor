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
        class RefValueExpressionVisitor : CSharpSyntaxRewriter
        {
            public RefValueExpressionVisitor()
            {
                Classes = new List<RefValueExpressionSyntax>();
            }

            public List<RefValueExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitRefValueExpression(RefValueExpressionSyntax node)
            {
                node = (RefValueExpressionSyntax)base.VisitRefValueExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
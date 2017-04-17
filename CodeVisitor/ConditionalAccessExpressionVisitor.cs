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
        class ConditionalAccessExpressionVisitor : CSharpSyntaxRewriter
        {
            public ConditionalAccessExpressionVisitor()
            {
                Classes = new List<ConditionalAccessExpressionSyntax>();
            }

            public List<ConditionalAccessExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitConditionalAccessExpression(ConditionalAccessExpressionSyntax node)
            {
                node = (ConditionalAccessExpressionSyntax)base.VisitConditionalAccessExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
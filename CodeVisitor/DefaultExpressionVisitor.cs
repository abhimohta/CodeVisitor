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
        class DefaultExpressionVisitor : CSharpSyntaxRewriter
        {
            public DefaultExpressionVisitor()
            {
                Classes = new List<DefaultExpressionSyntax>();
            }

            public List<DefaultExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitDefaultExpression(DefaultExpressionSyntax node)
            {
                node = (DefaultExpressionSyntax)base.VisitDefaultExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
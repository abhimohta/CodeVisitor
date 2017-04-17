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
        class AnonymousMethodExpressionVisitor : CSharpSyntaxRewriter
        {
            public AnonymousMethodExpressionVisitor()
            {
                Classes = new List<AnonymousMethodExpressionSyntax>();
            }

            public List<AnonymousMethodExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitAnonymousMethodExpression(AnonymousMethodExpressionSyntax node)
            {
                node = (AnonymousMethodExpressionSyntax)base.VisitAnonymousMethodExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
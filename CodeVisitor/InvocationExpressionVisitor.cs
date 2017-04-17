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
        class InvocationExpressionVisitor : CSharpSyntaxRewriter
        {
            public InvocationExpressionVisitor()
            {
                Classes = new List<InvocationExpressionSyntax>();
            }

            public List<InvocationExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitInvocationExpression(InvocationExpressionSyntax node)
            {
                node = (InvocationExpressionSyntax)base.VisitInvocationExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
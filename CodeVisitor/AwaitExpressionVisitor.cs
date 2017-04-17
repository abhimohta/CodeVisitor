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
        class AwaitExpressionVisitor : CSharpSyntaxRewriter
        {
            public AwaitExpressionVisitor()
            {
                Classes = new List<AwaitExpressionSyntax>();
            }

            public List<AwaitExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitAwaitExpression(AwaitExpressionSyntax node)
            {
                node = (AwaitExpressionSyntax)base.VisitAwaitExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
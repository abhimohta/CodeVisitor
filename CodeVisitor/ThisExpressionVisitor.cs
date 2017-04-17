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
        class ThisExpressionVisitor : CSharpSyntaxRewriter
        {
            public ThisExpressionVisitor()
            {
                Classes = new List<ThisExpressionSyntax>();
            }

            public List<ThisExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitThisExpression(ThisExpressionSyntax node)
            {
                node = (ThisExpressionSyntax)base.VisitThisExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
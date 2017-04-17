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
        class CheckedExpressionVisitor : CSharpSyntaxRewriter
        {
            public CheckedExpressionVisitor()
            {
                Classes = new List<CheckedExpressionSyntax>();
            }

            public List<CheckedExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitCheckedExpression(CheckedExpressionSyntax node)
            {
                node = (CheckedExpressionSyntax)base.VisitCheckedExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
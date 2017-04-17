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
        class SizeOfExpressionVisitor : CSharpSyntaxRewriter
        {
            public SizeOfExpressionVisitor()
            {
                Classes = new List<SizeOfExpressionSyntax>();
            }

            public List<SizeOfExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitSizeOfExpression(SizeOfExpressionSyntax node)
            {
                node = (SizeOfExpressionSyntax)base.VisitSizeOfExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
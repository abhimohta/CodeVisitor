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
        class BinaryExpressionVisitor : CSharpSyntaxRewriter
        {
            public BinaryExpressionVisitor()
            {
                Classes = new List<BinaryExpressionSyntax>();
            }

            public List<BinaryExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitBinaryExpression(BinaryExpressionSyntax node)
            {
                node = (BinaryExpressionSyntax)base.VisitBinaryExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
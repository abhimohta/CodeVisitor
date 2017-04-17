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
        class ConditionalExpressionVisitor : CSharpSyntaxRewriter
        {
            public ConditionalExpressionVisitor()
            {
                Classes = new List<ConditionalExpressionSyntax>();
            }

            public List<ConditionalExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitConditionalExpression(ConditionalExpressionSyntax node)
            {
                node = (ConditionalExpressionSyntax)base.VisitConditionalExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
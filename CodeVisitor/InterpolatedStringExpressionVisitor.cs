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
        class InterpolatedStringExpressionVisitor : CSharpSyntaxRewriter
        {
            public InterpolatedStringExpressionVisitor()
            {
                Classes = new List<InterpolatedStringExpressionSyntax>();
            }

            public List<InterpolatedStringExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitInterpolatedStringExpression(InterpolatedStringExpressionSyntax node)
            {
                node = (InterpolatedStringExpressionSyntax)base.VisitInterpolatedStringExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
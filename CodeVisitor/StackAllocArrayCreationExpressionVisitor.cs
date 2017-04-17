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
        class StackAllocArrayCreationExpressionVisitor : CSharpSyntaxRewriter
        {
            public StackAllocArrayCreationExpressionVisitor()
            {
                Classes = new List<StackAllocArrayCreationExpressionSyntax>();
            }

            public List<StackAllocArrayCreationExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitStackAllocArrayCreationExpression(StackAllocArrayCreationExpressionSyntax node)
            {
                node = (StackAllocArrayCreationExpressionSyntax)base.VisitStackAllocArrayCreationExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
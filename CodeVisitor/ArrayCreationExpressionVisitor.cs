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
        class ArrayCreationExpressionVisitor : CSharpSyntaxRewriter
        {
            public ArrayCreationExpressionVisitor()
            {
                Classes = new List<ArrayCreationExpressionSyntax>();
            }

            public List<ArrayCreationExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitArrayCreationExpression(ArrayCreationExpressionSyntax node)
            {
                node = (ArrayCreationExpressionSyntax)base.VisitArrayCreationExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
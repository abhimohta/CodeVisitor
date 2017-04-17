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
        class AnonymousObjectCreationExpressionVisitor : CSharpSyntaxRewriter
        {
            public AnonymousObjectCreationExpressionVisitor()
            {
                Classes = new List<AnonymousObjectCreationExpressionSyntax>();
            }

            public List<AnonymousObjectCreationExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitAnonymousObjectCreationExpression(AnonymousObjectCreationExpressionSyntax node)
            {
                node = (AnonymousObjectCreationExpressionSyntax)base.VisitAnonymousObjectCreationExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
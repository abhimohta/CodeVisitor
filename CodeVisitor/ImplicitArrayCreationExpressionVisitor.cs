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
        class ImplicitArrayCreationExpressionVisitor : CSharpSyntaxRewriter
        {
            public ImplicitArrayCreationExpressionVisitor()
            {
                Classes = new List<ImplicitArrayCreationExpressionSyntax>();
            }

            public List<ImplicitArrayCreationExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitImplicitArrayCreationExpression(ImplicitArrayCreationExpressionSyntax node)
            {
                node = (ImplicitArrayCreationExpressionSyntax)base.VisitImplicitArrayCreationExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
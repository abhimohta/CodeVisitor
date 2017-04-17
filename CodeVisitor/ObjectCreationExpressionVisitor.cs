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
        class ObjectCreationExpressionVisitor : CSharpSyntaxRewriter
        {
            public ObjectCreationExpressionVisitor()
            {
                Classes = new List<ObjectCreationExpressionSyntax>();
            }

            public List<ObjectCreationExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitObjectCreationExpression(ObjectCreationExpressionSyntax node)
            {
                node = (ObjectCreationExpressionSyntax)base.VisitObjectCreationExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
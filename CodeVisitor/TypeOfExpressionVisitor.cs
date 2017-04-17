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
        class TypeOfExpressionVisitor : CSharpSyntaxRewriter
        {
            public TypeOfExpressionVisitor()
            {
                Classes = new List<TypeOfExpressionSyntax>();
            }

            public List<TypeOfExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitTypeOfExpression(TypeOfExpressionSyntax node)
            {
                node = (TypeOfExpressionSyntax)base.VisitTypeOfExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
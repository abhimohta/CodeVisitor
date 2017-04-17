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
        class ElementAccessExpressionVisitor : CSharpSyntaxRewriter
        {
            public ElementAccessExpressionVisitor()
            {
                Classes = new List<ElementAccessExpressionSyntax>();
            }

            public List<ElementAccessExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitElementAccessExpression(ElementAccessExpressionSyntax node)
            {
                node = (ElementAccessExpressionSyntax)base.VisitElementAccessExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
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
        class ElementBindingExpressionVisitor : CSharpSyntaxRewriter
        {
            public ElementBindingExpressionVisitor()
            {
                Classes = new List<ElementBindingExpressionSyntax>();
            }

            public List<ElementBindingExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitElementBindingExpression(ElementBindingExpressionSyntax node)
            {
                node = (ElementBindingExpressionSyntax)base.VisitElementBindingExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
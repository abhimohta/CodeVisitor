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
        class OrderingVisitor : CSharpSyntaxRewriter
        {
            public OrderingVisitor()
            {
                Classes = new List<OrderingSyntax>();
            }

            public List<OrderingSyntax> Classes { get; set; }

            public override SyntaxNode VisitOrdering(OrderingSyntax node)
            {
                node = (OrderingSyntax)base.VisitOrdering(node);
                Classes.Add(node);
                return node;
            }
        }
    }
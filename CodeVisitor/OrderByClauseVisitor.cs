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
        class OrderByClauseVisitor : CSharpSyntaxRewriter
        {
            public OrderByClauseVisitor()
            {
                Classes = new List<OrderByClauseSyntax>();
            }

            public List<OrderByClauseSyntax> Classes { get; set; }

            public override SyntaxNode VisitOrderByClause(OrderByClauseSyntax node)
            {
                node = (OrderByClauseSyntax)base.VisitOrderByClause(node);
                Classes.Add(node);
                return node;
            }
        }
    }
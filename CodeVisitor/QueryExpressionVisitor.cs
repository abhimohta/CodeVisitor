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
        class QueryExpressionVisitor : CSharpSyntaxRewriter
        {
            public QueryExpressionVisitor()
            {
                Classes = new List<QueryExpressionSyntax>();
            }

            public List<QueryExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitQueryExpression(QueryExpressionSyntax node)
            {
                node = (QueryExpressionSyntax)base.VisitQueryExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
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
        class QueryBodyVisitor : CSharpSyntaxRewriter
        {
            public QueryBodyVisitor()
            {
                Classes = new List<QueryBodySyntax>();
            }

            public List<QueryBodySyntax> Classes { get; set; }

            public override SyntaxNode VisitQueryBody(QueryBodySyntax node)
            {
                node = (QueryBodySyntax)base.VisitQueryBody(node);
                Classes.Add(node);
                return node;
            }
        }
    }
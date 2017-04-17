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
        class QueryContinuationVisitor : CSharpSyntaxRewriter
        {
            public QueryContinuationVisitor()
            {
                Classes = new List<QueryContinuationSyntax>();
            }

            public List<QueryContinuationSyntax> Classes { get; set; }

            public override SyntaxNode VisitQueryContinuation(QueryContinuationSyntax node)
            {
                node = (QueryContinuationSyntax)base.VisitQueryContinuation(node);
                Classes.Add(node);
                return node;
            }
        }
    }
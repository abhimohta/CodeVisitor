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
        class TryStatementVisitor : CSharpSyntaxRewriter
        {
            public TryStatementVisitor()
            {
                Classes = new List<TryStatementSyntax>();
            }

            public List<TryStatementSyntax> Classes { get; set; }

            public override SyntaxNode VisitTryStatement(TryStatementSyntax node)
            {
                node = (TryStatementSyntax)base.VisitTryStatement(node);
                Classes.Add(node);
                return node;
            }
        }
    }
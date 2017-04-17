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
        class CatchFilterClauseVisitor : CSharpSyntaxRewriter
        {
            public CatchFilterClauseVisitor()
            {
                Classes = new List<CatchFilterClauseSyntax>();
            }

            public List<CatchFilterClauseSyntax> Classes { get; set; }

            public override SyntaxNode VisitCatchFilterClause(CatchFilterClauseSyntax node)
            {
                node = (CatchFilterClauseSyntax)base.VisitCatchFilterClause(node);
                Classes.Add(node);
                return node;
            }
        }
    }
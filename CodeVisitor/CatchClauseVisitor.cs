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
        class CatchClauseVisitor : CSharpSyntaxRewriter
        {
            public CatchClauseVisitor()
            {
                Classes = new List<CatchClauseSyntax>();
            }

            public List<CatchClauseSyntax> Classes { get; set; }

            public override SyntaxNode VisitCatchClause(CatchClauseSyntax node)
            {
                node = (CatchClauseSyntax)base.VisitCatchClause(node);
                Classes.Add(node);
                return node;
            }
        }
    }
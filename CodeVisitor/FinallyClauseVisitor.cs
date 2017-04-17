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
        class FinallyClauseVisitor : CSharpSyntaxRewriter
        {
            public FinallyClauseVisitor()
            {
                Classes = new List<FinallyClauseSyntax>();
            }

            public List<FinallyClauseSyntax> Classes { get; set; }

            public override SyntaxNode VisitFinallyClause(FinallyClauseSyntax node)
            {
                node = (FinallyClauseSyntax)base.VisitFinallyClause(node);
                Classes.Add(node);
                return node;
            }
        }
    }
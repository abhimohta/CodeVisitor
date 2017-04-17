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
        class LetClauseVisitor : CSharpSyntaxRewriter
        {
            public LetClauseVisitor()
            {
                Classes = new List<LetClauseSyntax>();
            }

            public List<LetClauseSyntax> Classes { get; set; }

            public override SyntaxNode VisitLetClause(LetClauseSyntax node)
            {
                node = (LetClauseSyntax)base.VisitLetClause(node);
                Classes.Add(node);
                return node;
            }
        }
    }
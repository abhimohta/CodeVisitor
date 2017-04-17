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
        class ElseClauseVisitor : CSharpSyntaxRewriter
        {
            public ElseClauseVisitor()
            {
                Classes = new List<ElseClauseSyntax>();
            }

            public List<ElseClauseSyntax> Classes { get; set; }

            public override SyntaxNode VisitElseClause(ElseClauseSyntax node)
            {
                node = (ElseClauseSyntax)base.VisitElseClause(node);
                Classes.Add(node);
                return node;
            }
        }
    }
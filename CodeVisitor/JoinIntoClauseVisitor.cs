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
        class JoinIntoClauseVisitor : CSharpSyntaxRewriter
        {
            public JoinIntoClauseVisitor()
            {
                Classes = new List<JoinIntoClauseSyntax>();
            }

            public List<JoinIntoClauseSyntax> Classes { get; set; }

            public override SyntaxNode VisitJoinIntoClause(JoinIntoClauseSyntax node)
            {
                node = (JoinIntoClauseSyntax)base.VisitJoinIntoClause(node);
                Classes.Add(node);
                return node;
            }
        }
    }
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
        class JoinClauseVisitor : CSharpSyntaxRewriter
        {
            public JoinClauseVisitor()
            {
                Classes = new List<JoinClauseSyntax>();
            }

            public List<JoinClauseSyntax> Classes { get; set; }

            public override SyntaxNode VisitJoinClause(JoinClauseSyntax node)
            {
                node = (JoinClauseSyntax)base.VisitJoinClause(node);
                Classes.Add(node);
                return node;
            }
        }
    }
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
        class GroupClauseVisitor : CSharpSyntaxRewriter
        {
            public GroupClauseVisitor()
            {
                Classes = new List<GroupClauseSyntax>();
            }

            public List<GroupClauseSyntax> Classes { get; set; }

            public override SyntaxNode VisitGroupClause(GroupClauseSyntax node)
            {
                node = (GroupClauseSyntax)base.VisitGroupClause(node);
                Classes.Add(node);
                return node;
            }
        }
    }
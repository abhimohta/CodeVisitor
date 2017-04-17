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
        class EqualsValueClauseVisitor : CSharpSyntaxRewriter
        {
            public EqualsValueClauseVisitor()
            {
                Classes = new List<EqualsValueClauseSyntax>();
            }

            public List<EqualsValueClauseSyntax> Classes { get; set; }

            public override SyntaxNode VisitEqualsValueClause(EqualsValueClauseSyntax node)
            {
                node = (EqualsValueClauseSyntax)base.VisitEqualsValueClause(node);
                Classes.Add(node);
                return node;
            }
        }
    }
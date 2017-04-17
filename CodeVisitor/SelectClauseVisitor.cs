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
        class SelectClauseVisitor : CSharpSyntaxRewriter
        {
            public SelectClauseVisitor()
            {
                Classes = new List<SelectClauseSyntax>();
            }

            public List<SelectClauseSyntax> Classes { get; set; }

            public override SyntaxNode VisitSelectClause(SelectClauseSyntax node)
            {
                node = (SelectClauseSyntax)base.VisitSelectClause(node);
                Classes.Add(node);
                return node;
            }
        }
    }
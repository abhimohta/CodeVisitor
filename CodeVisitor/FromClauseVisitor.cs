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
        class FromClauseVisitor : CSharpSyntaxRewriter
        {
            public FromClauseVisitor()
            {
                Classes = new List<FromClauseSyntax>();
            }

            public List<FromClauseSyntax> Classes { get; set; }

            public override SyntaxNode VisitFromClause(FromClauseSyntax node)
            {
                node = (FromClauseSyntax)base.VisitFromClause(node);
                Classes.Add(node);
                return node;
            }
        }
    }
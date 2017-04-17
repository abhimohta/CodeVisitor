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
        class BreakStatementVisitor : CSharpSyntaxRewriter
        {
            public BreakStatementVisitor()
            {
                Classes = new List<BreakStatementSyntax>();
            }

            public List<BreakStatementSyntax> Classes { get; set; }

            public override SyntaxNode VisitBreakStatement(BreakStatementSyntax node)
            {
                node = (BreakStatementSyntax)base.VisitBreakStatement(node);
                Classes.Add(node);
                return node;
            }
        }
    }
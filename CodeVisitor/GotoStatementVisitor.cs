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
        class GotoStatementVisitor : CSharpSyntaxRewriter
        {
            public GotoStatementVisitor()
            {
                Classes = new List<GotoStatementSyntax>();
            }

            public List<GotoStatementSyntax> Classes { get; set; }

            public override SyntaxNode VisitGotoStatement(GotoStatementSyntax node)
            {
                node = (GotoStatementSyntax)base.VisitGotoStatement(node);
                Classes.Add(node);
                return node;
            }
        }
    }
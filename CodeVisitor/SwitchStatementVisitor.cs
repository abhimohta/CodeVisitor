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
        class SwitchStatementVisitor : CSharpSyntaxRewriter
        {
            public SwitchStatementVisitor()
            {
                Classes = new List<SwitchStatementSyntax>();
            }

            public List<SwitchStatementSyntax> Classes { get; set; }

            public override SyntaxNode VisitSwitchStatement(SwitchStatementSyntax node)
            {
                node = (SwitchStatementSyntax)base.VisitSwitchStatement(node);
                Classes.Add(node);
                return node;
            }
        }
    }
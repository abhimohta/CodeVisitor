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
        class IfStatementVisitor : CSharpSyntaxRewriter
        {
            public IfStatementVisitor()
            {
                Classes = new List<IfStatementSyntax>();
            }

            public List<IfStatementSyntax> Classes { get; set; }

            public override SyntaxNode VisitIfStatement(IfStatementSyntax node)
            {
                node = (IfStatementSyntax)base.VisitIfStatement(node);
                Classes.Add(node);
                return node;
            }
        }
    }
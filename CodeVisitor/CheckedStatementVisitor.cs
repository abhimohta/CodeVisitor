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
        class CheckedStatementVisitor : CSharpSyntaxRewriter
        {
            public CheckedStatementVisitor()
            {
                Classes = new List<CheckedStatementSyntax>();
            }

            public List<CheckedStatementSyntax> Classes { get; set; }

            public override SyntaxNode VisitCheckedStatement(CheckedStatementSyntax node)
            {
                node = (CheckedStatementSyntax)base.VisitCheckedStatement(node);
                Classes.Add(node);
                return node;
            }
        }
    }
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
        class UsingStatementVisitor : CSharpSyntaxRewriter
        {
            public UsingStatementVisitor()
            {
                Classes = new List<UsingStatementSyntax>();
            }

            public List<UsingStatementSyntax> Classes { get; set; }

            public override SyntaxNode VisitUsingStatement(UsingStatementSyntax node)
            {
                node = (UsingStatementSyntax)base.VisitUsingStatement(node);
                Classes.Add(node);
                return node;
            }
        }
    }
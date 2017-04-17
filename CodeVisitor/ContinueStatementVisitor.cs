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
        class ContinueStatementVisitor : CSharpSyntaxRewriter
        {
            public ContinueStatementVisitor()
            {
                Classes = new List<ContinueStatementSyntax>();
            }

            public List<ContinueStatementSyntax> Classes { get; set; }

            public override SyntaxNode VisitContinueStatement(ContinueStatementSyntax node)
            {
                node = (ContinueStatementSyntax)base.VisitContinueStatement(node);
                Classes.Add(node);
                return node;
            }
        }
    }
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
        class EmptyStatementVisitor : CSharpSyntaxRewriter
        {
            public EmptyStatementVisitor()
            {
                Classes = new List<EmptyStatementSyntax>();
            }

            public List<EmptyStatementSyntax> Classes { get; set; }

            public override SyntaxNode VisitEmptyStatement(EmptyStatementSyntax node)
            {
                node = (EmptyStatementSyntax)base.VisitEmptyStatement(node);
                Classes.Add(node);
                return node;
            }
        }
    }
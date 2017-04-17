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
        class UnsafeStatementVisitor : CSharpSyntaxRewriter
        {
            public UnsafeStatementVisitor()
            {
                Classes = new List<UnsafeStatementSyntax>();
            }

            public List<UnsafeStatementSyntax> Classes { get; set; }

            public override SyntaxNode VisitUnsafeStatement(UnsafeStatementSyntax node)
            {
                node = (UnsafeStatementSyntax)base.VisitUnsafeStatement(node);
                Classes.Add(node);
                return node;
            }
        }
    }
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
        class LockStatementVisitor : CSharpSyntaxRewriter
        {
            public LockStatementVisitor()
            {
                Classes = new List<LockStatementSyntax>();
            }

            public List<LockStatementSyntax> Classes { get; set; }

            public override SyntaxNode VisitLockStatement(LockStatementSyntax node)
            {
                node = (LockStatementSyntax)base.VisitLockStatement(node);
                Classes.Add(node);
                return node;
            }
        }
    }
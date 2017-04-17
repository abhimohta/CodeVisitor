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
        class ThrowStatementVisitor : CSharpSyntaxRewriter
        {
            public ThrowStatementVisitor()
            {
                Classes = new List<ThrowStatementSyntax>();
            }

            public List<ThrowStatementSyntax> Classes { get; set; }

            public override SyntaxNode VisitThrowStatement(ThrowStatementSyntax node)
            {
                node = (ThrowStatementSyntax)base.VisitThrowStatement(node);
                Classes.Add(node);
                return node;
            }
        }
    }
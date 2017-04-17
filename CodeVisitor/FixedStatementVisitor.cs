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
        class FixedStatementVisitor : CSharpSyntaxRewriter
        {
            public FixedStatementVisitor()
            {
                Classes = new List<FixedStatementSyntax>();
            }

            public List<FixedStatementSyntax> Classes { get; set; }

            public override SyntaxNode VisitFixedStatement(FixedStatementSyntax node)
            {
                node = (FixedStatementSyntax)base.VisitFixedStatement(node);
                Classes.Add(node);
                return node;
            }
        }
    }
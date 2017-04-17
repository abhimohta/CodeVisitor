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
        class GlobalStatementVisitor : CSharpSyntaxRewriter
        {
            public GlobalStatementVisitor()
            {
                Classes = new List<GlobalStatementSyntax>();
            }

            public List<GlobalStatementSyntax> Classes { get; set; }

            public override SyntaxNode VisitGlobalStatement(GlobalStatementSyntax node)
            {
                node = (GlobalStatementSyntax)base.VisitGlobalStatement(node);
                Classes.Add(node);
                return node;
            }
        }
    }
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
        class YieldStatementVisitor : CSharpSyntaxRewriter
        {
            public YieldStatementVisitor()
            {
                Classes = new List<YieldStatementSyntax>();
            }

            public List<YieldStatementSyntax> Classes { get; set; }

            public override SyntaxNode VisitYieldStatement(YieldStatementSyntax node)
            {
                node = (YieldStatementSyntax)base.VisitYieldStatement(node);
                Classes.Add(node);
                return node;
            }
        }
    }
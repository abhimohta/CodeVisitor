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
        class DoStatementVisitor : CSharpSyntaxRewriter
        {
            public DoStatementVisitor()
            {
                Classes = new List<DoStatementSyntax>();
            }

            public List<DoStatementSyntax> Classes { get; set; }

            public override SyntaxNode VisitDoStatement(DoStatementSyntax node)
            {
                node = (DoStatementSyntax)base.VisitDoStatement(node);
                Classes.Add(node);
                return node;
            }
        }
    }
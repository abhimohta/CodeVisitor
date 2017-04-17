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
        class ForEachStatementVisitor : CSharpSyntaxRewriter
        {
            public ForEachStatementVisitor()
            {
                Classes = new List<ForEachStatementSyntax>();
            }

            public List<ForEachStatementSyntax> Classes { get; set; }

            public override SyntaxNode VisitForEachStatement(ForEachStatementSyntax node)
            {
                node = (ForEachStatementSyntax)base.VisitForEachStatement(node);
                Classes.Add(node);
                return node;
            }
        }
    }
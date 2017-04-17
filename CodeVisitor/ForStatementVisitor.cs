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
        class ForStatementVisitor : CSharpSyntaxRewriter
        {
            public ForStatementVisitor()
            {
                Classes = new List<ForStatementSyntax>();
            }

            public List<ForStatementSyntax> Classes { get; set; }

            public override SyntaxNode VisitForStatement(ForStatementSyntax node)
            {
                node = (ForStatementSyntax)base.VisitForStatement(node);
                Classes.Add(node);
                return node;
            }
        }
    }
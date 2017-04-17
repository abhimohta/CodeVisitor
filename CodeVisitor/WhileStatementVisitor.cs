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
        class WhileStatementVisitor : CSharpSyntaxRewriter
        {
            public WhileStatementVisitor()
            {
                Classes = new List<WhileStatementSyntax>();
            }

            public List<WhileStatementSyntax> Classes { get; set; }

            public override SyntaxNode VisitWhileStatement(WhileStatementSyntax node)
            {
                node = (WhileStatementSyntax)base.VisitWhileStatement(node);
                Classes.Add(node);
                return node;
            }
        }
    }
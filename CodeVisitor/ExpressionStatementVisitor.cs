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
        class ExpressionStatementVisitor : CSharpSyntaxRewriter
        {
            public ExpressionStatementVisitor()
            {
                Classes = new List<ExpressionStatementSyntax>();
            }

            public List<ExpressionStatementSyntax> Classes { get; set; }

            public override SyntaxNode VisitExpressionStatement(ExpressionStatementSyntax node)
            {
                node = (ExpressionStatementSyntax)base.VisitExpressionStatement(node);
                Classes.Add(node);
                return node;
            }
        }
    }
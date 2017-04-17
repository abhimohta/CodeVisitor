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
        class ReturnStatementVisitor : CSharpSyntaxRewriter
        {
            public ReturnStatementVisitor()
            {
                Classes = new List<ReturnStatementSyntax>();
            }

            public List<ReturnStatementSyntax> Classes { get; set; }

            public override SyntaxNode VisitReturnStatement(ReturnStatementSyntax node)
            {
                node = (ReturnStatementSyntax)base.VisitReturnStatement(node);
                Classes.Add(node);
                return node;
            }
        }
    }
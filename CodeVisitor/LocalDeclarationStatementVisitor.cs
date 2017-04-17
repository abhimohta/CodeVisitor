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
        class LocalDeclarationStatementVisitor : CSharpSyntaxRewriter
        {
            public LocalDeclarationStatementVisitor()
            {
                Classes = new List<LocalDeclarationStatementSyntax>();
            }

            public List<LocalDeclarationStatementSyntax> Classes { get; set; }

            public override SyntaxNode VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
            {
                node = (LocalDeclarationStatementSyntax)base.VisitLocalDeclarationStatement(node);
                Classes.Add(node);
                return node;
            }
        }
    }
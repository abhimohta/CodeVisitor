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
        class OperatorDeclarationVisitor : CSharpSyntaxRewriter
        {
            public OperatorDeclarationVisitor()
            {
                Classes = new List<OperatorDeclarationSyntax>();
            }

            public List<OperatorDeclarationSyntax> Classes { get; set; }

            public override SyntaxNode VisitOperatorDeclaration(OperatorDeclarationSyntax node)
            {
                node = (OperatorDeclarationSyntax)base.VisitOperatorDeclaration(node);
                Classes.Add(node);
                return node;
            }
        }
    }
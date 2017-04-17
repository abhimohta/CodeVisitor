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
        class MethodDeclarationVisitor : CSharpSyntaxRewriter
        {
            public MethodDeclarationVisitor()
            {
                Classes = new List<MethodDeclarationSyntax>();
            }

            public List<MethodDeclarationSyntax> Classes { get; set; }

            public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
            {
                node = (MethodDeclarationSyntax)base.VisitMethodDeclaration(node);
                Classes.Add(node);
                return node;
            }
        }
    }
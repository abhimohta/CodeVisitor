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
        class NamespaceDeclarationVisitor : CSharpSyntaxRewriter
        {
            public NamespaceDeclarationVisitor()
            {
                Classes = new List<NamespaceDeclarationSyntax>();
            }

            public List<NamespaceDeclarationSyntax> Classes { get; set; }

            public override SyntaxNode VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
            {
                node = (NamespaceDeclarationSyntax)base.VisitNamespaceDeclaration(node);
                Classes.Add(node);
                return node;
            }
        }
    }
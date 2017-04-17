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
        class InterfaceDeclarationVisitor : CSharpSyntaxRewriter
        {
            public InterfaceDeclarationVisitor()
            {
                Classes = new List<InterfaceDeclarationSyntax>();
            }

            public List<InterfaceDeclarationSyntax> Classes { get; set; }

            public override SyntaxNode VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
            {
                node = (InterfaceDeclarationSyntax)base.VisitInterfaceDeclaration(node);
                Classes.Add(node);
                return node;
            }
        }
    }
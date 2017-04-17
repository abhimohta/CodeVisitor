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
        class AccessorDeclarationVisitor : CSharpSyntaxRewriter
        {
            public AccessorDeclarationVisitor()
            {
                Classes = new List<AccessorDeclarationSyntax>();
            }

            public List<AccessorDeclarationSyntax> Classes { get; set; }

            public override SyntaxNode VisitAccessorDeclaration(AccessorDeclarationSyntax node)
            {
                node = (AccessorDeclarationSyntax)base.VisitAccessorDeclaration(node);
                Classes.Add(node);
                return node;
            }
        }
    }
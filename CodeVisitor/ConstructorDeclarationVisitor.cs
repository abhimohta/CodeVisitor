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
        class ConstructorDeclarationVisitor : CSharpSyntaxRewriter
        {
            public ConstructorDeclarationVisitor()
            {
                Classes = new List<ConstructorDeclarationSyntax>();
            }

            public List<ConstructorDeclarationSyntax> Classes { get; set; }

            public override SyntaxNode VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
            {
                node = (ConstructorDeclarationSyntax)base.VisitConstructorDeclaration(node);
                Classes.Add(node);
                return node;
            }
        }
    }
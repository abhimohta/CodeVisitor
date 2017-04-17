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
        class EnumDeclarationVisitor : CSharpSyntaxRewriter
        {
            public EnumDeclarationVisitor()
            {
                Classes = new List<EnumDeclarationSyntax>();
            }

            public List<EnumDeclarationSyntax> Classes { get; set; }

            public override SyntaxNode VisitEnumDeclaration(EnumDeclarationSyntax node)
            {
                node = (EnumDeclarationSyntax)base.VisitEnumDeclaration(node);
                Classes.Add(node);
                return node;
            }
        }
    }
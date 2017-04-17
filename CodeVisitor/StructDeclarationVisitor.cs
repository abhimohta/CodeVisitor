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
        class StructDeclarationVisitor : CSharpSyntaxRewriter
        {
            public StructDeclarationVisitor()
            {
                Classes = new List<StructDeclarationSyntax>();
            }

            public List<StructDeclarationSyntax> Classes { get; set; }

            public override SyntaxNode VisitStructDeclaration(StructDeclarationSyntax node)
            {
                node = (StructDeclarationSyntax)base.VisitStructDeclaration(node);
                Classes.Add(node);
                return node;
            }
        }
    }
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
        class FieldDeclarationVisitor : CSharpSyntaxRewriter
        {
            public FieldDeclarationVisitor()
            {
                Classes = new List<FieldDeclarationSyntax>();
            }

            public List<FieldDeclarationSyntax> Classes { get; set; }

            public override SyntaxNode VisitFieldDeclaration(FieldDeclarationSyntax node)
            {
                node = (FieldDeclarationSyntax)base.VisitFieldDeclaration(node);
                Classes.Add(node);
                return node;
            }
        }
    }
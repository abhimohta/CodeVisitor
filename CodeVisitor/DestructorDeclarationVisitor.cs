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
        class DestructorDeclarationVisitor : CSharpSyntaxRewriter
        {
            public DestructorDeclarationVisitor()
            {
                Classes = new List<DestructorDeclarationSyntax>();
            }

            public List<DestructorDeclarationSyntax> Classes { get; set; }

            public override SyntaxNode VisitDestructorDeclaration(DestructorDeclarationSyntax node)
            {
                node = (DestructorDeclarationSyntax)base.VisitDestructorDeclaration(node);
                Classes.Add(node);
                return node;
            }
        }
    }
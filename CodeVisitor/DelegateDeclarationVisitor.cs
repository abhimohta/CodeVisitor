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
        class DelegateDeclarationVisitor : CSharpSyntaxRewriter
        {
            public DelegateDeclarationVisitor()
            {
                Classes = new List<DelegateDeclarationSyntax>();
            }

            public List<DelegateDeclarationSyntax> Classes { get; set; }

            public override SyntaxNode VisitDelegateDeclaration(DelegateDeclarationSyntax node)
            {
                node = (DelegateDeclarationSyntax)base.VisitDelegateDeclaration(node);
                Classes.Add(node);
                return node;
            }
        }
    }
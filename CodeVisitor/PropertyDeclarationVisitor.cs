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
        class PropertyDeclarationVisitor : CSharpSyntaxRewriter
        {
            public PropertyDeclarationVisitor()
            {
                Classes = new List<PropertyDeclarationSyntax>();
            }

            public List<PropertyDeclarationSyntax> Classes { get; set; }

            public override SyntaxNode VisitPropertyDeclaration(PropertyDeclarationSyntax node)
            {
                node = (PropertyDeclarationSyntax)base.VisitPropertyDeclaration(node);
                Classes.Add(node);
                return node;
            }
        }
    }
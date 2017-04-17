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
        class AttributeTargetSpecifierVisitor : CSharpSyntaxRewriter
        {
            public AttributeTargetSpecifierVisitor()
            {
                Classes = new List<AttributeTargetSpecifierSyntax>();
            }

            public List<AttributeTargetSpecifierSyntax> Classes { get; set; }

            public override SyntaxNode VisitAttributeTargetSpecifier(AttributeTargetSpecifierSyntax node)
            {
                node = (AttributeTargetSpecifierSyntax)base.VisitAttributeTargetSpecifier(node);
                Classes.Add(node);
                return node;
            }
        }
    }
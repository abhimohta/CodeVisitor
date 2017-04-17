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
        class AttributeArgumentListVisitor : CSharpSyntaxRewriter
        {
            public AttributeArgumentListVisitor()
            {
                Classes = new List<AttributeArgumentListSyntax>();
            }

            public List<AttributeArgumentListSyntax> Classes { get; set; }

            public override SyntaxNode VisitAttributeArgumentList(AttributeArgumentListSyntax node)
            {
                node = (AttributeArgumentListSyntax)base.VisitAttributeArgumentList(node);
                Classes.Add(node);
                return node;
            }
        }
    }
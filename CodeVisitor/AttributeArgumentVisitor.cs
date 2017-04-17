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
        class AttributeArgumentVisitor : CSharpSyntaxRewriter
        {
            public AttributeArgumentVisitor()
            {
                Classes = new List<AttributeArgumentSyntax>();
            }

            public List<AttributeArgumentSyntax> Classes { get; set; }

            public override SyntaxNode VisitAttributeArgument(AttributeArgumentSyntax node)
            {
                node = (AttributeArgumentSyntax)base.VisitAttributeArgument(node);
                Classes.Add(node);
                return node;
            }
        }
    }
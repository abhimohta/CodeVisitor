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
        class AttributeVisitor : CSharpSyntaxRewriter
        {
            public AttributeVisitor()
            {
                Classes = new List<AttributeSyntax>();
            }

            public List<AttributeSyntax> Classes { get; set; }

            public override SyntaxNode VisitAttribute(AttributeSyntax node)
            {
                node = (AttributeSyntax)base.VisitAttribute(node);
                Classes.Add(node);
                return node;
            }
        }
    }
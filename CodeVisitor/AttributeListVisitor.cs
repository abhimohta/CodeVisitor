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
        class AttributeListVisitor : CSharpSyntaxRewriter
        {
            public AttributeListVisitor()
            {
                Classes = new List<AttributeListSyntax>();
            }

            public List<AttributeListSyntax> Classes { get; set; }

            public override SyntaxNode VisitAttributeList(AttributeListSyntax node)
            {
                node = (AttributeListSyntax)base.VisitAttributeList(node);
                Classes.Add(node);
                return node;
            }
        }
    }
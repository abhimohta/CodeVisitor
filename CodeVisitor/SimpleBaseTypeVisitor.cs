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
        class SimpleBaseTypeVisitor : CSharpSyntaxRewriter
        {
            public SimpleBaseTypeVisitor()
            {
                Classes = new List<SimpleBaseTypeSyntax>();
            }

            public List<SimpleBaseTypeSyntax> Classes { get; set; }

            public override SyntaxNode VisitSimpleBaseType(SimpleBaseTypeSyntax node)
            {
                node = (SimpleBaseTypeSyntax)base.VisitSimpleBaseType(node);
                Classes.Add(node);
                return node;
            }
        }
    }
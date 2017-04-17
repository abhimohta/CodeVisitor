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
        class NullableTypeVisitor : CSharpSyntaxRewriter
        {
            public NullableTypeVisitor()
            {
                Classes = new List<NullableTypeSyntax>();
            }

            public List<NullableTypeSyntax> Classes { get; set; }

            public override SyntaxNode VisitNullableType(NullableTypeSyntax node)
            {
                node = (NullableTypeSyntax)base.VisitNullableType(node);
                Classes.Add(node);
                return node;
            }
        }
    }
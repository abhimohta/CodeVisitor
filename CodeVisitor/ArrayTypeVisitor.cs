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
        class ArrayTypeVisitor : CSharpSyntaxRewriter
        {
            public ArrayTypeVisitor()
            {
                Classes = new List<ArrayTypeSyntax>();
            }

            public List<ArrayTypeSyntax> Classes { get; set; }

            public override SyntaxNode VisitArrayType(ArrayTypeSyntax node)
            {
                node = (ArrayTypeSyntax)base.VisitArrayType(node);
                Classes.Add(node);
                return node;
            }
        }
    }
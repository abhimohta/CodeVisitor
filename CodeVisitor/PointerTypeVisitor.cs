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
        class PointerTypeVisitor : CSharpSyntaxRewriter
        {
            public PointerTypeVisitor()
            {
                Classes = new List<PointerTypeSyntax>();
            }

            public List<PointerTypeSyntax> Classes { get; set; }

            public override SyntaxNode VisitPointerType(PointerTypeSyntax node)
            {
                node = (PointerTypeSyntax)base.VisitPointerType(node);
                Classes.Add(node);
                return node;
            }
        }
    }
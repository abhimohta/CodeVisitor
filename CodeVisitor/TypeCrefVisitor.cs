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
        class TypeCrefVisitor : CSharpSyntaxRewriter
        {
            public TypeCrefVisitor()
            {
                Classes = new List<TypeCrefSyntax>();
            }

            public List<TypeCrefSyntax> Classes { get; set; }

            public override SyntaxNode VisitTypeCref(TypeCrefSyntax node)
            {
                node = (TypeCrefSyntax)base.VisitTypeCref(node);
                Classes.Add(node);
                return node;
            }
        }
    }
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
        class TypeArgumentListVisitor : CSharpSyntaxRewriter
        {
            public TypeArgumentListVisitor()
            {
                Classes = new List<TypeArgumentListSyntax>();
            }

            public List<TypeArgumentListSyntax> Classes { get; set; }

            public override SyntaxNode VisitTypeArgumentList(TypeArgumentListSyntax node)
            {
                node = (TypeArgumentListSyntax)base.VisitTypeArgumentList(node);
                Classes.Add(node);
                return node;
            }
        }
    }
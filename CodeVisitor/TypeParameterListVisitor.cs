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
        class TypeParameterListVisitor : CSharpSyntaxRewriter
        {
            public TypeParameterListVisitor()
            {
                Classes = new List<TypeParameterListSyntax>();
            }

            public List<TypeParameterListSyntax> Classes { get; set; }

            public override SyntaxNode VisitTypeParameterList(TypeParameterListSyntax node)
            {
                node = (TypeParameterListSyntax)base.VisitTypeParameterList(node);
                Classes.Add(node);
                return node;
            }
        }
    }
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
        class TypeParameterVisitor : CSharpSyntaxRewriter
        {
            public TypeParameterVisitor()
            {
                Classes = new List<TypeParameterSyntax>();
            }

            public List<TypeParameterSyntax> Classes { get; set; }

            public override SyntaxNode VisitTypeParameter(TypeParameterSyntax node)
            {
                node = (TypeParameterSyntax)base.VisitTypeParameter(node);
                Classes.Add(node);
                return node;
            }
        }
    }
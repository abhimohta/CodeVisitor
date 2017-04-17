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
        class PredefinedTypeVisitor : CSharpSyntaxRewriter
        {
            public PredefinedTypeVisitor()
            {
                Classes = new List<PredefinedTypeSyntax>();
            }

            public List<PredefinedTypeSyntax> Classes { get; set; }

            public override SyntaxNode VisitPredefinedType(PredefinedTypeSyntax node)
            {
                node = (PredefinedTypeSyntax)base.VisitPredefinedType(node);
                Classes.Add(node);
                return node;
            }
        }
    }
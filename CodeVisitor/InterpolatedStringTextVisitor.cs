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
        class InterpolatedStringTextVisitor : CSharpSyntaxRewriter
        {
            public InterpolatedStringTextVisitor()
            {
                Classes = new List<InterpolatedStringTextSyntax>();
            }

            public List<InterpolatedStringTextSyntax> Classes { get; set; }

            public override SyntaxNode VisitInterpolatedStringText(InterpolatedStringTextSyntax node)
            {
                node = (InterpolatedStringTextSyntax)base.VisitInterpolatedStringText(node);
                Classes.Add(node);
                return node;
            }
        }
    }
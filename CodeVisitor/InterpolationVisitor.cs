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
        class InterpolationVisitor : CSharpSyntaxRewriter
        {
            public InterpolationVisitor()
            {
                Classes = new List<InterpolationSyntax>();
            }

            public List<InterpolationSyntax> Classes { get; set; }

            public override SyntaxNode VisitInterpolation(InterpolationSyntax node)
            {
                node = (InterpolationSyntax)base.VisitInterpolation(node);
                Classes.Add(node);
                return node;
            }
        }
    }
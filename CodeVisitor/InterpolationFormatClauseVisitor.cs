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
        class InterpolationFormatClauseVisitor : CSharpSyntaxRewriter
        {
            public InterpolationFormatClauseVisitor()
            {
                Classes = new List<InterpolationFormatClauseSyntax>();
            }

            public List<InterpolationFormatClauseSyntax> Classes { get; set; }

            public override SyntaxNode VisitInterpolationFormatClause(InterpolationFormatClauseSyntax node)
            {
                node = (InterpolationFormatClauseSyntax)base.VisitInterpolationFormatClause(node);
                Classes.Add(node);
                return node;
            }
        }
    }
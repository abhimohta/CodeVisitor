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
        class InterpolationAlignmentClauseVisitor : CSharpSyntaxRewriter
        {
            public InterpolationAlignmentClauseVisitor()
            {
                Classes = new List<InterpolationAlignmentClauseSyntax>();
            }

            public List<InterpolationAlignmentClauseSyntax> Classes { get; set; }

            public override SyntaxNode VisitInterpolationAlignmentClause(InterpolationAlignmentClauseSyntax node)
            {
                node = (InterpolationAlignmentClauseSyntax)base.VisitInterpolationAlignmentClause(node);
                Classes.Add(node);
                return node;
            }
        }
    }
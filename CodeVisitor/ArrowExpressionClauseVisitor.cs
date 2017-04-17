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
        class ArrowExpressionClauseVisitor : CSharpSyntaxRewriter
        {
            public ArrowExpressionClauseVisitor()
            {
                Classes = new List<ArrowExpressionClauseSyntax>();
            }

            public List<ArrowExpressionClauseSyntax> Classes { get; set; }

            public override SyntaxNode VisitArrowExpressionClause(ArrowExpressionClauseSyntax node)
            {
                node = (ArrowExpressionClauseSyntax)base.VisitArrowExpressionClause(node);
                Classes.Add(node);
                return node;
            }
        }
    }
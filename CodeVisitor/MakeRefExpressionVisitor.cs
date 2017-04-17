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
        class MakeRefExpressionVisitor : CSharpSyntaxRewriter
        {
            public MakeRefExpressionVisitor()
            {
                Classes = new List<MakeRefExpressionSyntax>();
            }

            public List<MakeRefExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitMakeRefExpression(MakeRefExpressionSyntax node)
            {
                node = (MakeRefExpressionSyntax)base.VisitMakeRefExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
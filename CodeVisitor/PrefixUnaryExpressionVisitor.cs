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
        class PrefixUnaryExpressionVisitor : CSharpSyntaxRewriter
        {
            public PrefixUnaryExpressionVisitor()
            {
                Classes = new List<PrefixUnaryExpressionSyntax>();
            }

            public List<PrefixUnaryExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitPrefixUnaryExpression(PrefixUnaryExpressionSyntax node)
            {
                node = (PrefixUnaryExpressionSyntax)base.VisitPrefixUnaryExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
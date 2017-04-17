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
        class RefTypeExpressionVisitor : CSharpSyntaxRewriter
        {
            public RefTypeExpressionVisitor()
            {
                Classes = new List<RefTypeExpressionSyntax>();
            }

            public List<RefTypeExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitRefTypeExpression(RefTypeExpressionSyntax node)
            {
                node = (RefTypeExpressionSyntax)base.VisitRefTypeExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
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
        class BaseExpressionVisitor : CSharpSyntaxRewriter
        {
            public BaseExpressionVisitor()
            {
                Classes = new List<BaseExpressionSyntax>();
            }

            public List<BaseExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitBaseExpression(BaseExpressionSyntax node)
            {
                node = (BaseExpressionSyntax)base.VisitBaseExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
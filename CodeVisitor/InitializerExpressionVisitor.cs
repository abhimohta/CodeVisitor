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
        class InitializerExpressionVisitor : CSharpSyntaxRewriter
        {
            public InitializerExpressionVisitor()
            {
                Classes = new List<InitializerExpressionSyntax>();
            }

            public List<InitializerExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitInitializerExpression(InitializerExpressionSyntax node)
            {
                node = (InitializerExpressionSyntax)base.VisitInitializerExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
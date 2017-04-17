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
        class PostfixUnaryExpressionVisitor : CSharpSyntaxRewriter
        {
            public PostfixUnaryExpressionVisitor()
            {
                Classes = new List<PostfixUnaryExpressionSyntax>();
            }

            public List<PostfixUnaryExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitPostfixUnaryExpression(PostfixUnaryExpressionSyntax node)
            {
                node = (PostfixUnaryExpressionSyntax)base.VisitPostfixUnaryExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
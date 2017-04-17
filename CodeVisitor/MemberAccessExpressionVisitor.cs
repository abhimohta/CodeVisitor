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
        class MemberAccessExpressionVisitor : CSharpSyntaxRewriter
        {
            public MemberAccessExpressionVisitor()
            {
                Classes = new List<MemberAccessExpressionSyntax>();
            }

            public List<MemberAccessExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
            {
                node = (MemberAccessExpressionSyntax)base.VisitMemberAccessExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
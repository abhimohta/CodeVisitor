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
        class MemberBindingExpressionVisitor : CSharpSyntaxRewriter
        {
            public MemberBindingExpressionVisitor()
            {
                Classes = new List<MemberBindingExpressionSyntax>();
            }

            public List<MemberBindingExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitMemberBindingExpression(MemberBindingExpressionSyntax node)
            {
                node = (MemberBindingExpressionSyntax)base.VisitMemberBindingExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
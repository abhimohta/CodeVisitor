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
        class AssignmentExpressionVisitor : CSharpSyntaxRewriter
        {
            public AssignmentExpressionVisitor()
            {
                Classes = new List<AssignmentExpressionSyntax>();
            }

            public List<AssignmentExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitAssignmentExpression(AssignmentExpressionSyntax node)
            {
                node = (AssignmentExpressionSyntax)base.VisitAssignmentExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
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
        class OmittedArraySizeExpressionVisitor : CSharpSyntaxRewriter
        {
            public OmittedArraySizeExpressionVisitor()
            {
                Classes = new List<OmittedArraySizeExpressionSyntax>();
            }

            public List<OmittedArraySizeExpressionSyntax> Classes { get; set; }

            public override SyntaxNode VisitOmittedArraySizeExpression(OmittedArraySizeExpressionSyntax node)
            {
                node = (OmittedArraySizeExpressionSyntax)base.VisitOmittedArraySizeExpression(node);
                Classes.Add(node);
                return node;
            }
        }
    }
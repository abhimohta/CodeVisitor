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
        class ConversionOperatorMemberCrefVisitor : CSharpSyntaxRewriter
        {
            public ConversionOperatorMemberCrefVisitor()
            {
                Classes = new List<ConversionOperatorMemberCrefSyntax>();
            }

            public List<ConversionOperatorMemberCrefSyntax> Classes { get; set; }

            public override SyntaxNode VisitConversionOperatorMemberCref(ConversionOperatorMemberCrefSyntax node)
            {
                node = (ConversionOperatorMemberCrefSyntax)base.VisitConversionOperatorMemberCref(node);
                Classes.Add(node);
                return node;
            }
        }
    }
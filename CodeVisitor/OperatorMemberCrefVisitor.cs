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
        class OperatorMemberCrefVisitor : CSharpSyntaxRewriter
        {
            public OperatorMemberCrefVisitor()
            {
                Classes = new List<OperatorMemberCrefSyntax>();
            }

            public List<OperatorMemberCrefSyntax> Classes { get; set; }

            public override SyntaxNode VisitOperatorMemberCref(OperatorMemberCrefSyntax node)
            {
                node = (OperatorMemberCrefSyntax)base.VisitOperatorMemberCref(node);
                Classes.Add(node);
                return node;
            }
        }
    }
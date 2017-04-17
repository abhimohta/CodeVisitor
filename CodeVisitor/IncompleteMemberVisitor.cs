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
        class IncompleteMemberVisitor : CSharpSyntaxRewriter
        {
            public IncompleteMemberVisitor()
            {
                Classes = new List<IncompleteMemberSyntax>();
            }

            public List<IncompleteMemberSyntax> Classes { get; set; }

            public override SyntaxNode VisitIncompleteMember(IncompleteMemberSyntax node)
            {
                node = (IncompleteMemberSyntax)base.VisitIncompleteMember(node);
                Classes.Add(node);
                return node;
            }
        }
    }
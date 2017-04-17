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
        class NameMemberCrefVisitor : CSharpSyntaxRewriter
        {
            public NameMemberCrefVisitor()
            {
                Classes = new List<NameMemberCrefSyntax>();
            }

            public List<NameMemberCrefSyntax> Classes { get; set; }

            public override SyntaxNode VisitNameMemberCref(NameMemberCrefSyntax node)
            {
                node = (NameMemberCrefSyntax)base.VisitNameMemberCref(node);
                Classes.Add(node);
                return node;
            }
        }
    }
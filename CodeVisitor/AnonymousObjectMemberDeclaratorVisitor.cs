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
        class AnonymousObjectMemberDeclaratorVisitor : CSharpSyntaxRewriter
        {
            public AnonymousObjectMemberDeclaratorVisitor()
            {
                Classes = new List<AnonymousObjectMemberDeclaratorSyntax>();
            }

            public List<AnonymousObjectMemberDeclaratorSyntax> Classes { get; set; }

            public override SyntaxNode VisitAnonymousObjectMemberDeclarator(AnonymousObjectMemberDeclaratorSyntax node)
            {
                node = (AnonymousObjectMemberDeclaratorSyntax)base.VisitAnonymousObjectMemberDeclarator(node);
                Classes.Add(node);
                return node;
            }
        }
    }
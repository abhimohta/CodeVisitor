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
        class EventFieldDeclarationVisitor : CSharpSyntaxRewriter
        {
            public EventFieldDeclarationVisitor()
            {
                Classes = new List<EventFieldDeclarationSyntax>();
            }

            public List<EventFieldDeclarationSyntax> Classes { get; set; }

            public override SyntaxNode VisitEventFieldDeclaration(EventFieldDeclarationSyntax node)
            {
                node = (EventFieldDeclarationSyntax)base.VisitEventFieldDeclaration(node);
                Classes.Add(node);
                return node;
            }
        }
    }
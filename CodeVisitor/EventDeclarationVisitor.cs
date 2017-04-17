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
        class EventDeclarationVisitor : CSharpSyntaxRewriter
        {
            public EventDeclarationVisitor()
            {
                Classes = new List<EventDeclarationSyntax>();
            }

            public List<EventDeclarationSyntax> Classes { get; set; }

            public override SyntaxNode VisitEventDeclaration(EventDeclarationSyntax node)
            {
                node = (EventDeclarationSyntax)base.VisitEventDeclaration(node);
                Classes.Add(node);
                return node;
            }
        }
    }
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
        class IdentifierNameVisitor : CSharpSyntaxRewriter
        {
            public IdentifierNameVisitor()
            {
                Classes = new List<IdentifierNameSyntax>();
            }

            public List<IdentifierNameSyntax> Classes { get; set; }

            public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax node)
            {
                node = (IdentifierNameSyntax)base.VisitIdentifierName(node);
                Classes.Add(node);
                return node;
            }
        }
    }
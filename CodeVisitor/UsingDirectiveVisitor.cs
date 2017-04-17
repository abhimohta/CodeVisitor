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
        class UsingDirectiveVisitor : CSharpSyntaxRewriter
        {
            public UsingDirectiveVisitor()
            {
                Classes = new List<UsingDirectiveSyntax>();
            }

            public List<UsingDirectiveSyntax> Classes { get; set; }

            public override SyntaxNode VisitUsingDirective(UsingDirectiveSyntax node)
            {
                node = (UsingDirectiveSyntax)base.VisitUsingDirective(node);
                Classes.Add(node);
                return node;
            }
        }
    }
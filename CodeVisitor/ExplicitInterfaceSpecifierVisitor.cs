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
        class ExplicitInterfaceSpecifierVisitor : CSharpSyntaxRewriter
        {
            public ExplicitInterfaceSpecifierVisitor()
            {
                Classes = new List<ExplicitInterfaceSpecifierSyntax>();
            }

            public List<ExplicitInterfaceSpecifierSyntax> Classes { get; set; }

            public override SyntaxNode VisitExplicitInterfaceSpecifier(ExplicitInterfaceSpecifierSyntax node)
            {
                node = (ExplicitInterfaceSpecifierSyntax)base.VisitExplicitInterfaceSpecifier(node);
                Classes.Add(node);
                return node;
            }
        }
    }
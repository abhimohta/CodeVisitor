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
        class ConstructorInitializerVisitor : CSharpSyntaxRewriter
        {
            public ConstructorInitializerVisitor()
            {
                Classes = new List<ConstructorInitializerSyntax>();
            }

            public List<ConstructorInitializerSyntax> Classes { get; set; }

            public override SyntaxNode VisitConstructorInitializer(ConstructorInitializerSyntax node)
            {
                node = (ConstructorInitializerSyntax)base.VisitConstructorInitializer(node);
                Classes.Add(node);
                return node;
            }
        }
    }
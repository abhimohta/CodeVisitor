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
        class ConversionOperatorDeclarationVisitor : CSharpSyntaxRewriter
        {
            public ConversionOperatorDeclarationVisitor()
            {
                Classes = new List<ConversionOperatorDeclarationSyntax>();
            }

            public List<ConversionOperatorDeclarationSyntax> Classes { get; set; }

            public override SyntaxNode VisitConversionOperatorDeclaration(ConversionOperatorDeclarationSyntax node)
            {
                node = (ConversionOperatorDeclarationSyntax)base.VisitConversionOperatorDeclaration(node);
                Classes.Add(node);
                return node;
            }
        }
    }
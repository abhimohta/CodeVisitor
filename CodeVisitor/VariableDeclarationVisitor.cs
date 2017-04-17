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
        class VariableDeclarationVisitor : CSharpSyntaxRewriter
        {
            public VariableDeclarationVisitor()
            {
                Classes = new List<VariableDeclarationSyntax>();
            }

            public List<VariableDeclarationSyntax> Classes { get; set; }

            public override SyntaxNode VisitVariableDeclaration(VariableDeclarationSyntax node)
            {
                node = (VariableDeclarationSyntax)base.VisitVariableDeclaration(node);
                Classes.Add(node);
                return node;
            }
        }
    }
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
        class CatchDeclarationVisitor : CSharpSyntaxRewriter
        {
            public CatchDeclarationVisitor()
            {
                Classes = new List<CatchDeclarationSyntax>();
            }

            public List<CatchDeclarationSyntax> Classes { get; set; }

            public override SyntaxNode VisitCatchDeclaration(CatchDeclarationSyntax node)
            {
                node = (CatchDeclarationSyntax)base.VisitCatchDeclaration(node);
                Classes.Add(node);
                return node;
            }
        }
    }
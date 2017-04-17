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
        class EnumMemberDeclarationVisitor : CSharpSyntaxRewriter
        {
            public EnumMemberDeclarationVisitor()
            {
                Classes = new List<EnumMemberDeclarationSyntax>();
            }

            public List<EnumMemberDeclarationSyntax> Classes { get; set; }

            public override SyntaxNode VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
            {
                node = (EnumMemberDeclarationSyntax)base.VisitEnumMemberDeclaration(node);
                Classes.Add(node);
                return node;
            }
        }
    }
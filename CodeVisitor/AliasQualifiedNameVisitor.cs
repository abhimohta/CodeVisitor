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
        class AliasQualifiedNameVisitor : CSharpSyntaxRewriter
        {
            public AliasQualifiedNameVisitor()
            {
                Classes = new List<AliasQualifiedNameSyntax>();
            }

            public List<AliasQualifiedNameSyntax> Classes { get; set; }

            public override SyntaxNode VisitAliasQualifiedName(AliasQualifiedNameSyntax node)
            {
                node = (AliasQualifiedNameSyntax)base.VisitAliasQualifiedName(node);
                Classes.Add(node);
                return node;
            }
        }
    }
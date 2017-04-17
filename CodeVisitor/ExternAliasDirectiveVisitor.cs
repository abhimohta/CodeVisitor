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
        class ExternAliasDirectiveVisitor : CSharpSyntaxRewriter
        {
            public ExternAliasDirectiveVisitor()
            {
                Classes = new List<ExternAliasDirectiveSyntax>();
            }

            public List<ExternAliasDirectiveSyntax> Classes { get; set; }

            public override SyntaxNode VisitExternAliasDirective(ExternAliasDirectiveSyntax node)
            {
                node = (ExternAliasDirectiveSyntax)base.VisitExternAliasDirective(node);
                Classes.Add(node);
                return node;
            }
        }
    }